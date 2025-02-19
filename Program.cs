using Clyde_Conservatory;

namespace Clyde_Conservatory
{
    internal static class Program
    {
        public static List<Cage> Cages = new List<Cage>();
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
            
            // Load all Files
            Cages = FileManager.LoadCages(@"..\..\..\Cages.txt");
            FileManager.LoadUnits(@"..\..\..\Units.txt", Cages);

            Animals = FileManager.LoadAnimals(@"..\..\..\Animals.txt", Cages);
            FileManager.LoadMates(@"..\..\..\Mammals-M.txt", Animals);
            FileManager.LoadBirthDates(@"..\..\..\Mammals-G.txt", Animals);
            FileManager.LoadAnimalRecords(@"..\..\..\A-Records.txt", Animals, Records);

            Keepers = FileManager.LoadKeepers(@"..\..\..\Keepers.txt", Cages);
            FileManager.LoadKeeperRecords(@"..\..\..\K-Records.txt", Records);

            Application.Run(new Form1());
        }
    }
}