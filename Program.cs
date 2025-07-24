namespace SmartCarRentalsSystemPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create sample vehicles

            List<Vehicle> fleet = new List<Vehicle> 
            {
                new Car("Toyota", "Camry", 2022, "ABC123", false),
                new Car("BMW", "7 Series", 2020, "BMW700", true),
                new Truck("Volvo", "FH16", 2018, "TRK890", 15000),
                new Motorbike("Yamaha", "MT-07", 2021, "BIKE07", true)
            };

            bool running = true;

            while (running)
            {
                //Step 2: Show menu
                Console.WriteLine("\n==== SmartCar Rental System ====");
                Console.WriteLine("1. View All Vehicles");
                Console.WriteLine("2. Rent a Vehicle");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Show vehicle list
                        Console.WriteLine("\n--- Vehicle Fleet ---");
                        for (int i = 0; i < fleet.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {fleet[i]}");
                        }
                        break;

                }
            }
}
