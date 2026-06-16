namespace OOP_Part1
{

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
