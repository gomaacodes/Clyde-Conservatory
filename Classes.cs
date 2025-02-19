using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clyde_Conservatory
{
    /// <summary>
    /// Abstract base class representing an animal in the conservatory.
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Initializes a new instance of the animal class.
        /// </summary>
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

        /// <summary>
        /// Displays unique attributes specific to the animal type.
        /// </summary>
        /// <returns>A string describing the unique attributes.</returns>
        public abstract string DisplayUniqueAttributes();
    }

    /// <summary>
    /// Represents a mammal in the conservatory.
    /// </summary>
    public class Mammal : Animal
    {
        /// <summary>
        /// Initializes a new instance of the mammal class.
        /// </summary>
        public Mammal(int animalId, string name, string type, DateTime birthDate, char sex, char acquisitionType, DateTime acquisitionDate, int dangerRating, char size, double insuranceValue)
            : base(animalId, name, type, birthDate, sex, acquisitionType, acquisitionDate, dangerRating, size, insuranceValue)
        {
        }

        public List<Mammal> MatedWith { get; set; } = new List<Mammal>();
        public List<DateTime> GaveBirthOn { get; set; } = new List<DateTime>();

        public override string DisplayUniqueAttributes()
        {
            var matedWithDetails = "";
            var dates = "";

            if (MatedWith.Count > 0)
            {
                matedWithDetails = "Mated With:\n";

                foreach (Animal a in MatedWith)
                {
                    matedWithDetails += $"{a.AnimalId} - {a.Name} - {a.Type}\n";
                }
            }

            if (GaveBirthOn.Count > 0)
            {
                dates = "\nGave birth on: \n";

                foreach (DateTime date in GaveBirthOn)
                {
                    dates += $"{date.ToShortDateString()}\n";
                }
            }
            return matedWithDetails + dates + $"\n{Records}";
        }

        /// <summary>
        /// Updates mating records for the mammal.
        /// </summary>
        /// <param name="mammal">The mammal this mammal mated with.</param>
        public void UpdateMatingRecords(Mammal mammal)
        {
            // Ensure both mammals are updated
            MatedWith.Add(mammal);
            mammal.MatedWith.Add(this);

            mammal.Records += $"{DateTime.Now.ToShortDateString()}: Mated with {this.Name}\n";
        }
    }

    /// <summary>
    /// Represents a reptile in the conservatory.
    /// </summary>
    public class Reptile : Animal
    {
        /// <summary>
        /// Initializes a new instance of the reptile class.
        /// </summary>
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
            return $"Environment: {Environment}\nHabitat Temperature: {HabitatTemperature} Celcius Degress" + $"\n\n{Records}";
        }
    }

    /// <summary>
    /// Represents a bird in the conservatory.
    /// </summary>
    public class Bird : Animal
    {
        /// <summary>
        /// Initializes a Bird class with flight properties.
        /// </summary>
        public Bird(int animalId, string name, string type, DateTime birthDate, char sex, char acquisitionType, DateTime acquisitionDate, int dangerRating, char size, double insuranceValue, string feedingRequirement, string nestEnvironment, double wingspan, double optimumFlightSpeed)
            : base(animalId, name, type, birthDate, sex, acquisitionType, acquisitionDate, dangerRating, size, insuranceValue)
        {

            FeedingRequirement = feedingRequirement;
            NestEnvironment = nestEnvironment;
            Wingspan = wingspan;
            OptimumFlightSpeed = optimumFlightSpeed;
        }

        /// <summary>
        /// Initializes a Bird class with land properties.
        /// </summary>
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
                return $"Feeding Requirement: {FeedingRequirement} \nNest Environment: {NestEnvironment} \nWingspan: {Wingspan} CM \nOptimum Flight Speed: {OptimumFlightSpeed} km/h" + $"\n\n{Records}";
            }
            else
            {
                return $"Feeding Requirement: {FeedingRequirement} \nNest Environment: {NestEnvironment} \nPreferred Habitat: {PreferredHabitat} \nOptimum Land Speed: {OptimumLandSpeed} km/h" + $"\n\n{Records}";
            }
        }
    }

    public class Keeper
    {
        /// <summary>
        /// Initializes a new instance of the keeper class.
        /// </summary>
        public Keeper(int keeperId, string forename, string surname, string address, string phoneNum, string position, int maxNumOfCages)
        {
            KeeperId = keeperId;
            Forename = forename;
            Surname = surname;
            Address = address;
            PhoneNum = phoneNum;
            Position = position;
            MaxNumOfCages = maxNumOfCages;
        }

        public int KeeperId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Position { get; set; }
        public int MaxNumOfCages { get; set; }
        public List<Unit> Units { get; set; } = new List<Unit>();

        /// <summary>
        /// Returns the number of cages the keeper can be assigned to.
        /// </summary>
        /// <returns>Number of cages left</returns>
        public string unitsLeft()
        {
            return $"{MaxNumOfCages - Units.Count}";
        }

        /// <summary>
        /// Displays the details of the keeper.
        /// </summary>
        /// <returns>String containing the units the keeper is assigned to</returns>
        public string DisplayKeeperDetails()
        {
            var unitsList = "Assigned to \n";

            foreach (Unit u in Units)
            {
                unitsList += $"{u.Cage.CageNumber} - {u.UnitId}\n";
            }
            return unitsList;
        }
    }

    /// <summary>
    /// Represents a cage in the conservatory.
    /// </summary>
    public class Cage
    {
        public Cage(int cageNumber, string size, string location, string type, int maxNumOfKeepers, string suitability)
        {
            CageNumber = cageNumber;
            Size = size;
            Location = location;
            Type = type;
            Suitability = suitability;
            Keepers = new Keeper[maxNumOfKeepers];
        }

        public int CageNumber { get; set; }
        public string Size { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Suitability { get; set; }
        public Keeper[] Keepers { get; set; }
        public List<Unit> Units { get; set; } = new List<Unit>();
    }

    /// <summary>
    /// Represents a unit in the conservatory.
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// Initializes a new instance of the unit class.
        /// </summary>
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

        /// <summary>
        /// Displays the details of the unit.
        /// </summary>
        /// <returns>String containing unit's animals and keepers</returns>
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

        /// <summary>
        /// Checks if an animal is suitable for the unit.
        /// </summary>
        /// <returns>True if the animal is suitable, false otherwise</returns>
        public bool CheckAnimalSuitability(Animal a)
        {
            // If the unit is empty
            if (Animals.Count == 0)
            {
                // Check the cage suitability group string
                string[] suitabilityParts = Cage.Suitability.Split('/');
                char suitabilityType = suitabilityParts[0][0];

                // Decode the suitability string
                foreach (string details in suitabilityParts.Skip(1))
                {
                    int capacity = 0;
                    string animalSize = "";
                    string groupOrType = "";

                    // Parse the details
                    foreach (char d in details)
                    {
                        if (int.TryParse(d.ToString(), out int result))
                        {
                            capacity = result; // Capacity of the unit
                        }
                        else if (char.IsUpper(d))
                        {
                            animalSize += d; // Size(s) of the animal
                        }
                        else if (char.IsLower(d))
                        {
                            groupOrType += d; // Group or type of the animal
                        }
                    }

                    // Check suitability based on the type
                    if (suitabilityType == 'T')
                    {
                        // Check if the animal is suitable for the unit based on group
                        if (capacity > Animals.Count && groupOrType[0] == a.GetType().Name.ToLower()[0] && (animalSize.Contains(a.Size) || animalSize == "A"))
                        {
                            return true;
                        }
                    }
                    else if (suitabilityType == 'A')
                    {
                        // Add the suitable animal to the list of suitable animals
                        SuitableAnimals.Add(groupOrType);

                        // Check if the animal is suitable for the unit based on type
                        if (capacity > Animals.Count && SuitableAnimals.Contains(a.Type.ToLower()) && (animalSize.Contains(a.Size) || animalSize == "A"))
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                // If the unit is not empty, check compatibility with the first animal
                if (Animals.Count < Capacity && SuitableAnimals.Contains(a.Type) && Animals.First().DangerRating == a.DangerRating && AnimalSize.Contains(a.Size))
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Updates the animals in the unit.
        /// </summary>
        /// <param name="animal">The animal to be added to the unit</param>
        public void UpdateCageAnimals(Animal animal)
        {
            // Check if the animal is already in another unit. If it is, remove it
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

                // if the unit doesn't have the set of suitable animals defined, add the animal to the set
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

        /// <summary>
        /// Checks if a keeper is suitable for the unit.
        /// </summary>
        /// <returns>True if the keeper is suitable, false otherwise</returns>
        public bool CheckKeeperSuitability(Keeper keeper)
        {
            // if the unit does not have any keepers or the number of keepers is less than the maximum number of keepers

            if (Keepers.Count == 0 || Cage.Units.Count < Cage.Keepers.Count())
            {
                // if the cage keepers array is not full
                if (Cage.Keepers.Count(k => k != null) < Cage.Keepers.Length)
                {
                    return true;
                }
                // if the keepers array for the unit cage is full but the keeper is already in the cage keepers array
                else if (Cage.Keepers.Count(k => k != null) == Cage.Keepers.Length && Cage.Keepers.Contains(keeper))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Adds a keeper to the unit.
        /// </summary>
        public void AddCageKeeper(Keeper keeper)
        {
            //  if keeper is not in unit.cage.keepers, add it
            //  Add keeper to unit.Keepers

            if (!Cage.Keepers.Contains(keeper))
            {
                for (int i = 0; i < Cage.Keepers.Length; i++)
                {
                    if (Cage.Keepers[i] == null)
                    {
                        Cage.Keepers[i] = keeper;
                        break;
                    }
                }
            }

            Keepers.Add(keeper);
            keeper.Units.Add(this);
        }

        /// <summary>
        /// Removes a keeper from the unit.
        /// </summary>
        public void RemoveCageKeeper(Keeper keeper)
        {
            Keepers.Remove(keeper);

            // Remove unit from keeper.Units
            keeper.Units.Remove(this);

            // If keeper does not have any units of the same cage, remove keeper from cage.Keepers
            if (!keeper.Units.Any(u => u.Cage == this.Cage))
            {
                for (int i = 0; i < Cage.Keepers.Length; i++)
                {
                    if (Cage.Keepers[i] == keeper)
                    {
                        Cage.Keepers[i] = null;
                        break;
                    }
                }
            }
        }
    }
}