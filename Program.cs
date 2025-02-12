namespace Clyde_Conservatory
{
    internal static class Program
    {
        public static List<Cage> Cages = new List<Cage>();
        public static List<Unit> Units = new List<Unit>();
        public static List<Animal> Animals = new List<Animal>();
        public static List<Keeper> Keepers = new List<Keeper>();
        public static List<string> Records = new List<string>();



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoadCages(ref Cages);
            LoadUnits(ref Cages, ref Units);
            LoadAnimals(ref Cages, ref Animals);
            LoadKeepers(ref Cages, ref Keepers);
            LoadRecords(ref Animals, ref Records);
            Application.Run(new Form1());
        }

        public static void LoadCages(ref List<Cage> cages)
        {
            StreamReader streamReader = new StreamReader(@"..\..\..\Cages.txt");
            while (!streamReader.EndOfStream)//Keep on reading data until end of file is reached
            {
                string line = streamReader.ReadLine();
                string[] cage = line.Split("-");

                cages.Add(new Cage(Convert.ToInt32(cage[0]), cage[1], cage[2], cage[3], Convert.ToInt32(cage[4]), cage[5]));
            }
            streamReader.Close();
        }

        public static void LoadUnits(ref List<Cage> cages, ref List<Unit> units)
        {
            StreamReader streamReader = new StreamReader(@"..\..\..\Units.txt");
            while (!streamReader.EndOfStream)//Keep on reading data until end of file is reached
            {
                string line = streamReader.ReadLine();
                string[] cageUnits = line.Split("-");

                Cage cage = cages.FirstOrDefault(c => c.CageNumber == Convert.ToInt32(cageUnits[0]));
                cage.Units = new List<Unit>();

                for (int i = 1; i < cageUnits.Length; i++)
                {
                    Unit unit = new Unit(Convert.ToInt32(cageUnits[i]));
                    unit.Cage = cage;
                    cage.Units.Add(unit);
                }
            }
            streamReader.Close();
        }


        public static void LoadAnimals(ref List<Cage> cages, ref List<Animal> animals)
        {
            StreamReader streamReader = new StreamReader(@"..\..\..\Animals.txt");
            while (!streamReader.EndOfStream)//Keep on reading data until end of file is reached

            {
                string line = streamReader.ReadLine();
                string[] animal = line.Split("-");

                int cageNum = Convert.ToInt32(animal[animal.Length - 2]) / 10;

                Cage cage = cages.FirstOrDefault(c => c.CageNumber == cageNum);


                Unit unit = cage.Units.Find(u => u.UnitId == Convert.ToInt32(animal[animal.Length - 2]));
                Animal a = null;

                if (animal[0] == "M")
                {
                    a = new Mammal(Convert.ToInt32(animal[1]), animal[2], animal[3], Convert.ToDateTime(animal[4]),  Convert.ToChar(animal[5]),
                                    Convert.ToChar(animal[6]), Convert.ToDateTime(animal[7]), Convert.ToInt32(animal[8]), Convert.ToChar(animal[9]),
                                    Convert.ToDouble(animal[10]));
                }
                else if (animal[0] == "R")
                {
                    a = new Reptile(Convert.ToInt32(animal[1]), animal[2], animal[3], Convert.ToDateTime(animal[4]),  Convert.ToChar(animal[5]),
                                    Convert.ToChar(animal[6]), Convert.ToDateTime(animal[7]), Convert.ToInt32(animal[8]), Convert.ToChar(animal[9]),
                                    Convert.ToDouble(animal[10]), animal[11], Convert.ToDouble(animal[12]));
                }
                else if (animal[0] == "F")
                {
                    a = new Bird(Convert.ToInt32(animal[1]), animal[2], animal[3], Convert.ToDateTime(animal[4]),  Convert.ToChar(animal[5]),
                                    Convert.ToChar(animal[6]), Convert.ToDateTime(animal[7]), Convert.ToInt32(animal[8]), Convert.ToChar(animal[9]),
                                    Convert.ToDouble(animal[10]), animal[11], animal[12], Convert.ToDouble(animal[13]), Convert.ToDouble(animal[14]));
                }
                else if (animal[0] == "N")
                {
                    a = new Bird(Convert.ToInt32(animal[1]), animal[2], animal[3], Convert.ToDateTime(animal[4]),  Convert.ToChar(animal[5]),
                                    Convert.ToChar(animal[6]), Convert.ToDateTime(animal[7]), Convert.ToInt32(animal[8]), Convert.ToChar(animal[9]),
                                    Convert.ToDouble(animal[10]), animal[11], animal[12], animal[13], Convert.ToDouble(animal[14]));
                }

                a.EmergencyShare = Convert.ToBoolean(animal[animal.Length - 1]);
                a.UnitAllocation = unit;

                if (unit.SuitableAnimals.Count == 0)
                {
                    unit.CheckAnimalSuitability(a);
                }

                animals.Add(a);
                unit.UpdateCageAnimals(a);

            }

            streamReader.Close();
        }

        public static void LoadKeepers(ref List<Cage> cages, ref List<Keeper> keepers)
        {
            StreamReader streamReader = new StreamReader(@"..\..\..\Keepers.txt");
            while (!streamReader.EndOfStream)//Keep on reading data until end of file is reached
            {
                string line = streamReader.ReadLine();
                string[] keeper = line.Split("-");

                Keeper k = new Keeper(Convert.ToInt32(keeper[0]), keeper[1], keeper[2], keeper[3], keeper[4], keeper[5],
                                       Convert.ToBoolean(keeper[6]), Convert.ToInt32(keeper[7]));
                
                for (int i = 8; i < keeper.Length; i++)
                {
                    Cage cage = cages.FirstOrDefault(c => c.CageNumber == Convert.ToInt32(keeper[i])/10);
                    Unit unit = cage.Units.FirstOrDefault(u => u.UnitId == Convert.ToInt32(keeper[i]));

                   

                    unit.Keepers.Add(k);
                    k.Units.Add(unit);
                }

                keepers.Add(k);
            }
            streamReader.Close();
        }

        public static void LoadRecords(ref List<Animal> animals, ref List<string> records)
        {
            StreamReader streamReader = new StreamReader(@"..\..\..\Records.txt");
            while (!streamReader.EndOfStream)//Keep on reading data until end of file is reached
            {
                string line = streamReader.ReadLine();
                string[] record = line.Split("-");

                var animal = animals.FirstOrDefault(a => a.AnimalId == Convert.ToInt32(record[0]));
                if (animal != null)
                {
                    animal.Records += line.Substring(4);
                }

                records.Add(line);
            }

            streamReader.Close();
        }

        
    }
}