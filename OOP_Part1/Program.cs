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
        // Case 01 Add New Room
        static void AddNewRoom(List<Room> rooms)
        {
            // clerk to enter room number
            Console.Write("Enter the room number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Error: The room number must be above 0.");
                return;
            }

            // Duplicate check with LINQ — is there ANY room with this number already exist
            bool exists = rooms.Any(r => r.roomNumber == number);
            if (exists)
            {
                Console.WriteLine("A room with that number already exists.");
                return;
            }

            // For the room type
            Console.Write("Enter room type (Single / Double / Suite): ");
            string type = Console.ReadLine();

            // For the price per night
            Console.Write("Enter price per night: ");
            double price = double.Parse(Console.ReadLine());

            if (price <= 0)
            {
                Console.WriteLine("The price must be positive");
            }

            Room newRoom = new Room(number, type, price);
            rooms.Add(newRoom);

            Console.WriteLine("Room added successfully!");
            newRoom.displayRoom();
            Console.WriteLine($"Total rooms now: {rooms.Count}");
        }




        // Case 02 Register New Guest
        static void RegisterNewGuest(List<Guest> guests)
        {
            // To enter the name of the guest
            Console.WriteLine();
            Console.Write("Enter your name: ");
            
            string guestName = Console.ReadLine();

            // // Validate that the name is not empty 
            if (string.IsNullOrWhiteSpace(guestName))
            {
                Console.WriteLine();
                Console.WriteLine("The name can't be empty, please write a name");
                Console.WriteLine();
                return;
            }

            // To enter the check in date
            Console.WriteLine();
            Console.Write("Enter the check in date: ");
            
            string checkInDate = Console.ReadLine();

            // Number of night staying
            Console.WriteLine();
            Console.Write("Enter the number of night staying: ");
            int numberOfNight = int.Parse(Console.ReadLine());

            if (numberOfNight <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("The number must be above 0");
                Console.WriteLine();
                return;
            }

            // Auto-generate the guest ID
            int nextNumber = guests.Count + 1;
            string guestId = "G" + nextNumber.ToString("D3");

            //  Create a new Guest object
            Guest newGuest = new Guest(guestId, guestName, checkInDate, numberOfNight);
            guests.Add(newGuest);

            //  Display a confirmation
            Console.WriteLine();
            Console.WriteLine($"The guest added successfully!");
            Console.WriteLine();
            newGuest.displayGuest();
        }




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


            bool running = true;
            while (running)
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

                // Start the switch cases
                switch (choice)
                {

                    case 1:
                        AddNewRoom(rooms);  // Call the function that we did to add new room.
                        break;


                    case 2:
                        RegisterNewGuest(guests); // Call the function that we did to add new guest.
                        break;


                    case 0:
                        running = false; 
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
