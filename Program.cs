namespace _3UmlHomwork;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Testing Person class:");
            Person person1 = new Person("John", 30, 1234567890, "john@example.com", "123 Street");
            Person person2 = new Person("Jane", 25, 9876543210, "jane@example.com", "456 Avenue");
            
            Console.WriteLine($"People Count: {Person.PeopleCount}");
            person1.PrintInfo();
            person2.PrintInfo();
            
            person1.Delete();
            Console.WriteLine($"People Count after deleting person1: {Person.PeopleCount}");
            Console.WriteLine();

            // Test House class
            Console.WriteLine("Testing House class:");
            House house1 = new House(1, "789 Boulevard", 250000, false);
            House house2 = new House(2, "1010 Lane", 300000, true);
            
            house1.PrintInfo();
            house2.PrintInfo();
            
            house1.Sell();
            Console.WriteLine("After selling house1:");
            house1.PrintInfo();
            Console.WriteLine();

            // Test Computer class
            Console.WriteLine("Testing Computer class:");
            Computer computer1 = new Computer("Laptop", "Dell", 1200, 512, 15.6f, "Available");
            Computer computer2 = new Computer("Desktop", "HP", 800, 1024, 27.0f, "Available");
            
            computer1.PrintInfo();
            computer2.PrintInfo();
            
            computer1.Sell();
            Console.WriteLine("After selling computer1:");
            computer1.PrintInfo();
    }

     public class Person
    {

        private string name;
        private byte age;
        private long phoneNumber; 
        private string emailAddress;
        private string address;


        public static int PeopleCount { get; private set; }


        public Person(string name, byte age, long phoneNumber, string emailAddress, string address)
        {
            this.name = name;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.address = address;
            PeopleCount++;
        }


        public string GetInfo()
        {
            return $"Name: {name}, Age: {age}, Phone: {phoneNumber}, Email: {emailAddress}, Address: {address}";
        }


        public void PrintInfo()
        {
            Console.WriteLine(GetInfo());
        }


        public void Delete()
        {
            if (PeopleCount > 0)
            {
                PeopleCount--; 
            }
        }
    }
    
        public class House
    {
        // Private fields
        private long id;
        private string address;
        private int price;
        private bool sold;


        public House(long id, string address, int price, bool sold)
        {
            this.id = id;
            this.address = address;
            this.price = price;
            this.sold = sold;
        }

    
        public string GetInfo()
        {
            return $"ID: {id}, Address: {address}, Price: {price}, Sold: {sold}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(GetInfo());
        }
        public void Sell()
        {
            sold = true; 
        }
    }

        public class Computer
    {
        // Private fields
        private string type;
        private string brand;
        private int price;
        private int storage;
        private float size;
        private string status;

        // Constructor
        public Computer(string type, string brand, int price, int storage, float size, string status)
        {
            this.type = type;
            this.brand = brand;
            this.price = price;
            this.storage = storage;
            this.size = size;
            this.status = status;
        }

        // Method to get information about the computer
        public string GetInfo()
        {
            return $"Type: {type}, Brand: {brand}, Price: {price}, Storage: {storage}GB, Size: {size}\" inches, Status: {status}";
        }

        // Method to print information about the computer
        public void PrintInfo()
        {
            Console.WriteLine(GetInfo());
        }

        // Method to mark the computer as sold
        public void Sell()
        {
            status = "Sold";
        }
    }
}
