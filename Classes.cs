using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clyde_Conservatory
{
    public abstract class Animal
    {
        protected Animal(int animalId, string name, string type, DateTime birthDate, char sex, char acquisitionType, DateTime acquisitionDate, int dangerRating, char size, double insuranceValue)
        {
            AnimalId = animalId;
            Name = name;        
            Type = type;
            BirthDate = birthDate;
            Sex = sex;
            AcquisitionType = acquisitionType;
            AcquisitionDate = acquisitionDate;
            DangerRating = dangerRating;
            Size = size;
            InsuranceValue = insuranceValue;
        }

        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
        public char Sex { get; set; }
        public char AcquisitionType { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public int DangerRating { get; set; }
        public char Size { get; set; }
        public double InsuranceValue { get; set; }
        public string Records { get; set; }
        public Unit UnitAllocation { get; set; }
        public bool EmergencyShare { get; set; }

        public void PerformHealthCheck(int animalId)
        {
            // Implementation to perform health check
        }

        public void UpdateCageAllocation(int unitId)
        {
            // Implementation to update cage allocation
        }

        public abstract string DisplayUniqueAttributes();
    }

    public class Mammal : Animal
    {
        public Mammal(int animalId, string name, string type, DateTime birthDate, char sex, char acquisitionType, DateTime acquisitionDate, int dangerRating, char size, double insuranceValue)
            : base(animalId, name, type, birthDate, sex, acquisitionType, acquisitionDate, dangerRating, size, insuranceValue)
        {
        }

        public List<Mammal> MatedWith { get; set; } = new List<Mammal>();
        public List<DateTime> GaveBirthOn { get; set; } = new List<DateTime>();

        public override string DisplayUniqueAttributes()
        {
            var matedWithDetails = "Mated With:\n";

            foreach (Animal a in MatedWith)
            {
                matedWithDetails += $"{a.AnimalId} - {a.Name} - {a.Type}\n";
            }

            var dates = "\nGave birth on: \n";

            foreach (DateTime date in GaveBirthOn)
            {
                dates += $"{date.ToShortDateString()}\n";
            }
            return matedWithDetails + dates + $"\n{Records}";


        }

        public void UpdateMatingRecords(int animalId)
        {
            // Implementation to update mating records
        }
    }

    public class Reptile : Animal
    {
        public Reptile(int animalId, string name, string type, DateTime birthDate, char sex, char acquisitionType, DateTime acquisitionDate, int dangerRating, char size, double insuranceValue, string environment, double habitatTemperature)
            : base(animalId, name, type, birthDate, sex, acquisitionType, acquisitionDate, dangerRating, size, insuranceValue)
        {
            Environment = environment;
            HabitatTemperature = habitatTemperature;
        }


        public string Environment { get; set; }
        public double HabitatTemperature { get; set; }

        public override string DisplayUniqueAttributes()
        {
            return $"Environment: {Environment}\nHabitat Temperature: {HabitatTemperature} Celcius Degress";
        }
    }

    public class Bird : Animal
    {
        public Bird(int animalId, string name, string type, DateTime birthDate, char sex, char acquisitionType, DateTime acquisitionDate, int dangerRating, char size, double insuranceValue, string feedingRequirement, string nestEnvironment, double wingspan, double optimumFlightSpeed)
            : base(animalId, name, type, birthDate, sex, acquisitionType, acquisitionDate, dangerRating, size, insuranceValue)
        {

            FeedingRequirement = feedingRequirement;
            NestEnvironment = nestEnvironment;
            Wingspan = wingspan;
            OptimumFlightSpeed = optimumFlightSpeed;
        }   
        public Bird(int animalId, string name, string type, DateTime birthDate, char sex, char acquisitionType, DateTime acquisitionDate, int dangerRating, char size, double insuranceValue, string feedingRequirement, string nestEnvironment, string preferredHabitat, double optimumLandSpeed)
            : base(animalId, name, type, birthDate, sex, acquisitionType, acquisitionDate, dangerRating, size, insuranceValue)
        {
            FeedingRequirement = feedingRequirement;
            NestEnvironment = nestEnvironment;
            PreferredHabitat = preferredHabitat;
            OptimumLandSpeed = optimumLandSpeed;
        }


        public string FeedingRequirement { get; set; }
        public string NestEnvironment { get; set; }
        public double? Wingspan { get; set; }
        public double? OptimumFlightSpeed { get; set; }
        public string? PreferredHabitat { get; set; }
        public double? OptimumLandSpeed { get; set; }

        public override string DisplayUniqueAttributes()
        {
            if (Wingspan.HasValue && OptimumFlightSpeed.HasValue)
            {
                return $"Feeding Requirement: {FeedingRequirement} \nNest Environment: {NestEnvironment} \nWingspan: {Wingspan} CM \nOptimum Flight Speed: {OptimumFlightSpeed} km/h";
            }
            else
            {
                return $"Feeding Requirement: {FeedingRequirement} \nNest Environment: {NestEnvironment} \nPreferred Habitat: {PreferredHabitat} \nOptimum Land Speed: {OptimumLandSpeed} km/h";
            }
        }
    }

    public class Keeper
    {
        public Keeper(int keeperId, string forename, string surname, string address, string phoneNum, string position, bool availability, int maxNumOfCages)
        {
            KeeperId = keeperId;
            Forename = forename;
            Surname = surname;
            Address = address;
            PhoneNum = phoneNum;
            Position = position;
            MaxNumOfCages = maxNumOfCages;
            Availability = availability;
        }

        public int KeeperId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Position { get; set; }
        public bool Availability { get; set; }
        public int MaxNumOfCages { get; set; }
        public List<Unit> Units { get; set; } = new List<Unit>();

        public string unitsLeft()
        {
            return $"{MaxNumOfCages - Units.Count}";
        }

        public string DisplayKeeperDetails()
        {
            var unitsList = "Assigned to \n";

            foreach (Unit u in Units)
            {
                unitsList += $"{u.Cage.CageNumber} - {u.UnitId}\n";
            }
            return unitsList;
        }

        public void UpdateCageAllocation(int cageId)
        {
            // Implementation to update cage allocation
        }
    }

    public class Cage
    {
        public Cage(int cageNumber, string size, string location, string type, int maxNumOfKeepers, string suitability)
        {
            CageNumber = cageNumber;
            Size = size;
            Location = location;
            Type = type;
            MaxNumOfKeepers = maxNumOfKeepers;
            Suitability = suitability;
        }

        public int CageNumber { get; set; }
        public string Size { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public int MaxNumOfKeepers { get; set; }
        public string Suitability { get; set; }
        public List<Unit> Units { get; set; } = new List<Unit>();


        public void UpdateCageAnimals(int animalId)
        {
            // Implementation to update cage animals
        }

        public void UpdateCageKeepers(int keeperId)
        {
            // Implementation to update cage keepers
        }
    }

    public class Unit
    {
        public Unit(int unitId)
        {
            UnitId = unitId;
        }

        public int UnitId { get; set; }
        public List<Keeper> Keepers { get; set; } = new List<Keeper>();
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public int Capacity { get; set; }
        public string AnimalSize { get; set; }
        public char Group { get; set; }
        public List<string> SuitableAnimals { get; set; } = new List<string>();


        public Cage Cage { get; set; }

        public string DisplayUnitDetails()
        {
            var animalsList = "Animals\n";

            foreach (Animal a in Animals)
            {
                animalsList += $"{a.AnimalId} - {a.Name} - {a.Type}\n";

            }

            var keepersList = "\nKeeper(s): \n";

            foreach (Keeper k in Keepers)
            {
                keepersList += $"{k.KeeperId} - {k.Surname} - {k.Forename} - {k.Position}\n";
            }
            return animalsList + keepersList;
        }

        public bool CheckAnimalSuitability(Animal a)
        {

            if (Animals.Count == 0)
            {
                // Check the cage suitability string
                string[] suitabilityParts = Cage.Suitability.Split('/');

                char suitabilityType = suitabilityParts[0][0];

                for(int i = 1; i < suitabilityParts.Length; i++)
                {
                    AnimalSize = "";

                    if (suitabilityType == 'T')
                    {
                        string details = suitabilityParts[i];

                        // Group suitability
                        foreach (char d in details)
                        {
                            if (int.TryParse(d.ToString(), out int result))
                            {
                                Capacity = result;
                            }
                            else if (char.IsUpper(d))
                            {
                                AnimalSize += d;
                            }
                            else if (char.IsLower(d))
                            {
                                Group = d;
                            }
                        }

                        var placeholder = a.GetType().Name;

                        if (Capacity > Animals.Count && Group == a.GetType().Name.ToLower()[0] && (AnimalSize.Contains(a.Size) || AnimalSize == "A"))
                        {

                            return true;
                        }
                    }
                    else if (suitabilityType == 'A')
                    {
                        string details = suitabilityParts[i];
                        string suitableAnimal = "";

                        // Group suitability
                        foreach (char d in details)
                        {
                            if (int.TryParse(d.ToString(), out int result))
                            {
                                Capacity = result;
                            }
                            else if (char.IsUpper(d))
                            {
                                AnimalSize += d;
                            }
                            else if (char.IsLower(d))
                            {
                                suitableAnimal += d;
                            }
                        }

                        SuitableAnimals.Add(suitableAnimal);

                        if (Capacity > Animals.Count && SuitableAnimals.Contains(a.Type.ToLower()) && (AnimalSize.Contains(a.Size) || AnimalSize == "A"))
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                // If the unit is not empty
                if (Animals.Count < Capacity && SuitableAnimals.Contains(a.Type) && AnimalSize.Contains(a.Size))
                {
                    return true;
                }
            }

            return false;
        }



        public void UpdateCageAnimals(Animal animal)
        {
            // Check if the animal is already in another unit and remove it
            foreach (var cage in Program.Cages)
            {
                foreach (var unit in cage.Units)
                {
                    if (unit.Animals.Contains(animal))
                    {
                        unit.Animals.Remove(animal);
                        break;
                    }
                }
            }

            // If the unit is empty, adjust suitable animals based on AnimalSuitability.txt
            if (Animals.Count == 0)
            {
                // Assuming AnimalSuitability.txt is in the same directory and contains suitability information
                string[] lines = File.ReadAllLines(@"..\..\..\AnimalSuitability.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split("-");
                    if (parts[0] == animal.Type)
                    {
                        foreach (string part in parts)
                        {
                            SuitableAnimals.Add(part);
                        }
                        break;
                    }
                }

                if (SuitableAnimals.Count == 0)
                {
                    SuitableAnimals.Add(animal.Type);
                    AnimalSize += animal.Size;
                }
            }

            // Add the animal to the unit
            Animals.Add(animal);
            animal.UnitAllocation = this;

        }

        public void UpdateCageKeepers(int keeperId)
        {
            // Implementation to update cage keepers
        }
    }
}