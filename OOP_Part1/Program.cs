namespace OOP_Part1
{


    class Room
    {
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(int number, string type, double price)
        {
            roomNumber = number;
            roomType = type;
            pricePerNight = price;
            isAvailable = true;   
        }

        public void displayRoom()
        {
            string status = isAvailable ? "Available" : "Booked";
            Console.WriteLine($"Room {roomNumber} | {roomType} | OMR {pricePerNight:F2} /night | {status}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            bool exit = true;
            while (exit)
            {   // The main menu of the system
                Console.WriteLine("================================================");
                Console.WriteLine("   GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. Search & Filter Rooms");
                Console.WriteLine("5. Guest & Booking Statistics");
                Console.WriteLine("6. Check Out a Guest");
                Console.WriteLine("7. Remove Unavailable Rooms");
                Console.WriteLine("0. Exit");
                Console.WriteLine("================================================");
                Console.Write("Enter your choice: ");
                int choice = int.Parse (Console.ReadLine());

                switch (choice)
                {
                    case 0: 
                        exit = false; 
                        break;

                    default: 
                        Console.WriteLine("Invalid choice."); 
                        break;
                } // Switch

                Console.WriteLine();

                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            } // While
        } // Main
    } // Class program
} // Name space
