using Clyde_Conservatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clyde_Conservatory
{
    /// <summary>
    /// Used to load and save data related to cages, units, animals, and keepers.
    /// </summary>
    public static class FileManager
    {
        /// <summary>
        /// Loads cages from a text file
        /// </summary>
        /// <param name="filePath">The path to the text file containing cages data</param>
        /// <returns>A list of cages</returns>
        public static List<Cage> LoadCages(string filePath)
        {
            List<Cage> cages = new List<Cage>();

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] cage = line.Split("-");
                    cages.Add(new Cage(Convert.ToInt32(cage[0]), cage[1], cage[2], cage[3], Convert.ToInt32(cage[4]), cage[5]));
                }
            }
            return cages;
        }

        /// <summary>
        /// Loads units from a text file and assigns them to cages
        /// </summary>
        /// <param name="filePath">The path to the text file containing unit data</param>
        /// <param name="cages">The list of cages to which units will be assigned</param>
        /// <returns>A list of units</returns>
        public static void LoadUnits(string filePath, List<Cage> cages)
        {
            List<Unit> units = new List<Unit>();
            using(StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] cageUnits = line.Split("-");

                    // Find the Cage the unit is a part of
                    Cage cage = cages.FirstOrDefault(c => c.CageNumber == Convert.ToInt32(cageUnits[0]));
                    cage.Units = new List<Unit>();

                    // Add all units belonging to the cage to the list of units
                    for (int i = 1; i < cageUnits.Length; i++)
                    {
                        Unit unit = new Unit(Convert.ToInt32(cageUnits[i]));
                        unit.Cage = cage;
                        cage.Units.Add(unit);
                        units.Add(unit);
                    }
                }
            }           
        }

        /// <summary>
        /// Loads animals from a text file and assigns them to units
        /// </summary>
        /// <param name="filePath">The path to the text file containing animal data</param>
        /// <param name="cages">The list of cages from which animals will be assigned to units</param>
        /// <returns>A list of animals</returns>
        public static List<Animal> LoadAnimals(string filePath, List<Cage> cages)
        {
            List<Animal> animals = new List<Animal>();
            using(StreamReader streamReader = new StreamReader(filePath)) 
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] animal = line.Split("-");
                    Animal a = CreateAnimal(animal);
                    animals.Add(a);
                    AssignAnimalToUnit(animal, cages, a);
                }
            }
            return animals;
        }

        /// <summary>
        /// Instantiates an Animal
        /// </summary>
        /// <param name="animal">An array of strings containing animal data.</param>
        /// <returns>An animal object.</returns>
        private static Animal CreateAnimal(string[] animal)
        {
            Animal a = null;


            if (animal[0] == "M")       // If animal is a Mammal
            {
                a = new Mammal(Convert.ToInt32(animal[1]), animal[2], animal[3], Convert.ToDateTime(animal[4]), Convert.ToChar(animal[5]),
                                Convert.ToChar(animal[6]), Convert.ToDateTime(animal[7]), Convert.ToInt32(animal[8]), Convert.ToChar(animal[9]),
                                Convert.ToDouble(animal[10]));
            }
            else if (animal[0] == "R")  // If animal is a Reptile
            {
                a = new Reptile(Convert.ToInt32(animal[1]), animal[2], animal[3], Convert.ToDateTime(animal[4]), Convert.ToChar(animal[5]),
                                Convert.ToChar(animal[6]), Convert.ToDateTime(animal[7]), Convert.ToInt32(animal[8]), Convert.ToChar(animal[9]),
                                Convert.ToDouble(animal[10]), animal[11], Convert.ToDouble(animal[12]));
            }
            else if (animal[0] == "F")  // If animal is a Flying bird
            {
                a = new Bird(Convert.ToInt32(animal[1]), animal[2], animal[3], Convert.ToDateTime(animal[4]), Convert.ToChar(animal[5]),
                                Convert.ToChar(animal[6]), Convert.ToDateTime(animal[7]), Convert.ToInt32(animal[8]), Convert.ToChar(animal[9]),
                                Convert.ToDouble(animal[10]), animal[11], animal[12], Convert.ToDouble(animal[13]), Convert.ToDouble(animal[14]));
            }
            else if (animal[0] == "N") // If animal is a Non Flying Bird
            {
                a = new Bird(Convert.ToInt32(animal[1]), animal[2], animal[3], Convert.ToDateTime(animal[4]), Convert.ToChar(animal[5]),
                                Convert.ToChar(animal[6]), Convert.ToDateTime(animal[7]), Convert.ToInt32(animal[8]), Convert.ToChar(animal[9]),
                                Convert.ToDouble(animal[10]), animal[11], animal[12], animal[13], Convert.ToDouble(animal[14]));
            }

            return a;
        }

        /// <summary>
        /// Assigns an animal to a unit
        /// </summary>
        /// <param name="animal">An array of strings containing animal data.</param>
        /// <param name="cages">The list of cages where animals will be assigned to units</param>
        /// <param name="a">The animal to be assigned to a unit.</param>
        private static void AssignAnimalToUnit(string[] animal, List<Cage> cages, Animal a)
        {
            if (animal[6] != "L" && animal[6] != "N")   // If animal is currently in conservatory (Not Loaned out and not 'N')
            {
                // Find the cage that has the unit the animal is in
                int cageNum = Convert.ToInt32(animal[animal.Length - 2]) / 10;
                Cage cage = cages.FirstOrDefault(c => c.CageNumber == cageNum);
                Unit unit = cage.Units.Find(u => u.UnitId == Convert.ToInt32(animal[animal.Length - 2]));

                a.EmergencyShare = Convert.ToBoolean(animal[animal.Length - 1]);
                a.UnitAllocation = unit;

                if (unit.SuitableAnimals.Count == 0) // if unit does not have a set suitability yet
                {
                    unit.CheckAnimalSuitability(a);
                }
                unit.UpdateCageAnimals(a);
            }
        }

        /// <summary>
        /// Loads mating records from a text file and assigns them to mammals
        /// </summary>
        /// <param name="filePath">The path to the text file containing mating records</param>
        /// <param name="animals">The list of animals where mating records will be assigned</param>
        public static void LoadMates(string filePath, List<Animal> animals)
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] record = line.Split("-");

                    int animalId = int.Parse(record[0]);
                    int[] mates = record.Skip(1).Select(int.Parse).ToArray();

                    Mammal a = animals.OfType<Mammal>().FirstOrDefault(a => a.AnimalId == animalId);

                    foreach (int mateID in mates)
                    {
                        Mammal mate = animals.OfType<Mammal>().FirstOrDefault(m => m.AnimalId == mateID);
                        a.MatedWith.Add(mate);
                    }
                }
            }
        }

        /// <summary>
        /// Loads dates of birth given for mammals from a text file
        /// </summary>
        /// <param name="filePath">The path to the text file containing dates of birth given</param>
        /// <param name="animals">The list of animals where the dates will be assigned</param>
        public static void LoadBirthDates(string filePath, List<Animal> animals)
        {
            using(StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] record = line.Split("-");

                    int animalId = int.Parse(record[0]);

                    DateTime[] dates = record.Skip(1).Select(DateTime.Parse).ToArray();
                    Mammal a = animals.OfType<Mammal>().FirstOrDefault(a => a.AnimalId == animalId);

                    foreach (DateTime date in dates)
                    {
                        a.GaveBirthOn.Add(date);
                    }
                }
            }
        }

        /// <summary>
        /// Loads Keepers from a text file and assigns them to units
        /// </summary>
        /// <param name="filePath">The path to the text file containing Keepers data</param>
        /// <param name="cages">The list of cages to which keepers keepers will be assigned to</param>
        /// <returns>A list of keepers</returns>
        public static List<Keeper> LoadKeepers(string filePath, List<Cage> cages)
        {
            List<Keeper> keepers = new List<Keeper>();
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] keeper = line.Split("-");

                    Keeper k = new Keeper(Convert.ToInt32(keeper[0]), keeper[1], keeper[2], keeper[3], keeper[4], keeper[5],
                                        Convert.ToInt32(keeper[6]));

                    AssignKeepertoUnits(keeper, cages, k);

                    keepers.Add(k);
                }
            }
            return keepers;
        }
        /// <summary>
        /// Assigns a keeper to a unit
        /// </summary>
        /// <param name="keeper">An array of strings containing keeper data.</param>
        /// <param name="cages">The list of cages where keepers will be assigned to units</param>
        /// <param name="k">The keeper to be assigned to a unit.</param>
        public static void AssignKeepertoUnits(string[] keeper, List<Cage> cages, Keeper k)
        {
            for (int i = 7; i < keeper.Length; i++)
            {
                Cage cage = cages.FirstOrDefault(c => c.CageNumber == Convert.ToInt32(keeper[i]) / 10);
                Unit unit = cage.Units.FirstOrDefault(u => u.UnitId == Convert.ToInt32(keeper[i]));
                unit.Keepers.Add(k);
                k.Units.Add(unit);
            }
        }

        /// <summary>
        /// Loads animal records from a text file and assigns them to animals
        /// </summary>
        /// <param name="filePath">The path to the text file containing animal records</param>
        /// <param name="animals">The list of animals to which records will be assigned.</param>
        /// <param name="records">The list of records to be updated.</param>
        public static void LoadAnimalRecords(string filePath, List<Animal> animals, List<string> records)
        {
            using(StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] record = line.Split("-");

                    var animal = animals.FirstOrDefault(a => a.AnimalId == Convert.ToInt32(record[0]));
                    if (animal != null)
                    {
                        animal.Records += record[1] + "\n";
                    }

                    // Reorder the string before addding it to records ["dd/mm/yyyy - Animal - id - name: event"]
                    records.Add(record[1].Substring(0, 12) + $"Animal - {animal.AnimalId} - {animal.Name}: " + record[1].Substring(12));
                }
            }
        }

        /// <summary>
        /// Loads keeper records from a file.
        /// </summary>
        /// <param name="filePath">The path to the text file containing keeper records.</param>
        /// <param name="records">The list of records to be updated.</param>
        public static void LoadKeeperRecords(string filePath, List<string> records)
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    records.Add(line);
                }
            }
        }

        /// <summary>
        /// Saves animal data to files.
        /// </summary>
        /// <param name="filePaths">An array of file paths where animal data will be saved.</param>
        /// <param name="animals">The list of animals to be saved</param>
        public static void SaveAnimals(string[] filePaths, List<Animal> animals)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePaths[0]))
            {
                foreach (var animal in animals)
                {
                    // Determine the animal type and get the first character of the type
                    string animalType = animal is Bird b ?
                                        b.OptimumLandSpeed.HasValue ? "N" : "F" :
                                        animal.GetType().Name[0].ToString();

                    // Create a string with the animal data
                    string animalData = $"{animalType}-{animal.AnimalId}-{animal.Name}-{animal.Type}-{animal.BirthDate.ToShortDateString()}-{animal.Sex}-{animal.AcquisitionType}-{animal.AcquisitionDate.ToShortDateString()}-{animal.DangerRating}-{animal.Size}-{animal.InsuranceValue}";

                    // Add additional data based on the animal type
                    if (animal is Reptile reptile)
                    {
                        animalData += $"-{reptile.Environment}-{reptile.HabitatTemperature}";
                    }
                    else if (animal is Bird bird)
                    {
                        animalData += $"-{bird.FeedingRequirement}-{bird.NestEnvironment}";

                        if (bird.Wingspan.HasValue && bird.OptimumFlightSpeed.HasValue)
                        {
                            animalData += $"-{bird.Wingspan}-{bird.OptimumFlightSpeed}";
                        }
                        else if (bird.PreferredHabitat != null && bird.OptimumLandSpeed.HasValue)
                        {
                            animalData += $"-{bird.PreferredHabitat}-{bird.OptimumLandSpeed}";
                        }
                    }

                    // Add additional data based on the animal's current status
                    animalData += animal.AcquisitionType != 'L' && animal.AcquisitionType != 'N' ? $"-{animal.UnitAllocation.UnitId}-{animal.EmergencyShare}" : "";

                    if (animalData != "")
                    {
                        streamWriter.WriteLine(animalData);
                    }
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(filePaths[1]))
            {
                foreach (var mammal in animals.OfType<Mammal>())
                {
                    if (mammal.GaveBirthOn.Count > 0)
                    {
                        string birthDates = $"{mammal.AnimalId}-{string.Join("-", mammal.GaveBirthOn.Select(date => date.ToShortDateString()))}";
                        streamWriter.WriteLine(birthDates);
                    }
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(filePaths[2]))
            {
                foreach (var mammal in animals.OfType<Mammal>())
                {
                    if (mammal.MatedWith.Count > 0)
                    {
                        string mates = $"{mammal.AnimalId}-{string.Join("-", mammal.MatedWith.Select(mate => mate.AnimalId))}";
                        streamWriter.WriteLine(mates);
                    }
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(filePaths[3]))
            {
                foreach (var animal in animals)
                {
                    if (!string.IsNullOrEmpty(animal.Records))
                    {
                        string[] records = animal.Records.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                        foreach (var record in records)
                        {
                            streamWriter.WriteLine($"{animal.AnimalId}-{record}");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Saves keeper data and records to files.
        /// </summary>
        /// <param name="filePaths">An array of file paths where keeper data will be saved.</param>
        /// <param name="keepers">The list of keepers to be saved</param>
        /// <param name="records">The list of records to be saved</param>
        public static void SaveKeepers(string[] filePaths, List<Keeper> keepers, List<string> records)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePaths[0]))
            {
                foreach (var keeper in keepers)
                {
                    // Create a string with the keeper data
                    string keeperData = $"{keeper.KeeperId}-{keeper.Forename}-{keeper.Surname}-{keeper.Address}-{keeper.PhoneNum}-{keeper.Position}-{keeper.MaxNumOfCages}";

                    // Add the units the keeper is assigned to
                    foreach (var unit in keeper.Units)
                    {
                        keeperData += $"-{unit.UnitId}";
                    }

                    streamWriter.WriteLine(keeperData);
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(@"..\..\..\K-Records.txt"))
            {
                foreach (var record in records)
                {
                    if (record.Substring(12, 1) == "K")
                    {
                        streamWriter.WriteLine(record);
                    }
                }
            }
        }

        /// <summary>
        /// Generates a weekly report of all records from the last week and saves it to a file on the desktop.
        /// </summary>
        public static void GenerateWeeklyReport()
        {
            // Get the records from the program
            var records = Program.Records;

            // Filter records from the last week
            var lastWeekRecords = records.Where(record => DateTime.Parse(record.Substring(0, 10)) >= DateTime.Now.AddDays(-7)).ToList();

            // Sort records by date
            lastWeekRecords.Sort((x, y) => DateTime.Parse(x.Substring(0, 10)).CompareTo(DateTime.Parse(y.Substring(0, 10))));

            // Generate the report content
            StringBuilder reportContent = new();
            reportContent.AppendLine("Weekly Report");
            reportContent.AppendLine("=============");
            foreach (var record in lastWeekRecords)
            {
                reportContent.AppendLine(record);
            }

            // Save the report to a file
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"WeeklyReport Week Of {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.txt");
            File.WriteAllText(filePath, reportContent.ToString());
        }
    }
}
