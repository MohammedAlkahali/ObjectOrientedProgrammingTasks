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

    class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;
        public double pricePerNight;


        public Guest(string id, string name, string checkIn, int nights)
        {
            guestId = id;
            guestName = name;
            checkInDate = checkIn;
            totalNights = nights;
            roomNumber = "Not Assigned";
            pricePerNight = 0;
        }

        public double calculateTotalCost()
        {
            return pricePerNight * totalNights;
        }

        public void displayGuest ()
        {
            Console.WriteLine($"{guestId} | {guestName} | Room: {roomNumber} | CheckIn Date: {checkInDate} | Nights: {totalNights}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the lists for the Room and Guest
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            // Pre-load rooms with at least 6 rooms.
            rooms.Add(new Room (100, "Single" ,20));
            rooms.Add(new Room (101, "Single" ,20));
            rooms.Add(new Room (102, "Double" ,45));
            rooms.Add(new Room (103, "Suite"  ,80));
            rooms.Add(new Room (104, "Double" ,75));
            rooms.Add(new Room (105, "Suite"  ,95));


            bool exit = true;
            while (exit)
            {   // The main menu of the system
                Console.WriteLine("================================================");
                Console.WriteLine("   GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine("           1. Add New Room");
                Console.WriteLine("           2. Register New Guest");
                Console.WriteLine("           3. Book a Room for a Guest");
                Console.WriteLine("           4. Search & Filter Rooms");
                Console.WriteLine("           5. Guest & Booking Statistics");
                Console.WriteLine("           6. Check Out a Guest");
                Console.WriteLine("           7. Remove Unavailable Rooms");
                Console.WriteLine("           0. Exit");
                Console.WriteLine("================================================");
                Console.Write("             Enter your choice: ");
                int choice = int.Parse (Console.ReadLine());

                // Start the switch cases
                switch (choice)
                {

                    case 1:
                   

                    case 0: 
                        exit = false; 
                        break;

                    default: // If he enter numbers not included in the main menu it print this message.
                        Console.WriteLine("-> Invalid choice."); 
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
