using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace G_NET_42_OOP_1
{
    class PersonClass
    {
        public string Name;
    }
    struct PersonStruct
    {
        public string Name;
    }
    class Student
    {
        public string Name;      // Accessible everywhere
        private int Age;         // Only accessible inside this class

        public void SetAge(int age)
        {
            Age = age;
        }

        public int GetAge()
        {
            return Age;
        }
    }
    public enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }
    public struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
    public class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public Seat Seat { get; set; }

        private double Price;
        private double discountAmount;

        // Main constructor
        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
            discountAmount = 0;
        }

        
        public Ticket(string movieName)
            : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
        {
        }

       
        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }

        // Apply discount and consume it
        public void ApplyDiscount(double amount)
        {
            if (amount > 0 && amount <= Price)
            {
                discountAmount = amount;
                Price -= discountAmount; 
                discountAmount = 0;     
            }
        }

        // Print ticket info
        public void PrintTicket(double taxPercent)
        {
            Console.WriteLine("===== Ticket Info =====");
            Console.WriteLine($"Movie   : {MovieName}");
            Console.WriteLine($"Type    : {Type}");
            Console.WriteLine($"Seat    : {Seat}");
            Console.WriteLine($"Price   : {Price:0.00}");
            Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent):0.00}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // CLASS behavior
            PersonClass p1 = new PersonClass();
            p1.Name = "Fayrouz";

            PersonClass p2 = p1;  // Copies reference
            p2.Name = "Goumaa";

            Console.WriteLine(p1.Name); // Output: Goumaa


            // STRUCT behavior
            PersonStruct s1;
            s1.Name = "Fayrouz";

            PersonStruct s2 = s1; // Copies value
            s2.Name = "Goumaa";

            Console.WriteLine(s1.Name); // Output: Fayrouz
            #endregion
            #region Q2

            Student s = new Student();

            s.Name = "Fayrouz";   // Allowed
                                  // s.Age = 20;        // ERROR (private)

            s.SetAge(20);         // Correct way

            Console.WriteLine(s.Name);
            Console.WriteLine(s.GetAge());
            #endregion
            #region Q3
            //1-Create it
            //Write your classes
            //Build it
            //Add reference to another project
            //Use the classes normally
            #endregion
            #region Q4
            //A Class Library is a project that contains reusable classes and methods compiled into a.dll file that can be used by other projects.
            //Why We Use Class Libraries
            //    Code Reusability
            //    Separation of Concerns
            //    Maintainability
            #endregion
            #region
            Console.Write("Enter Movie Name: ");
            string movie = Console.ReadLine();

            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            TicketType type = (TicketType)int.Parse(Console.ReadLine());

            Console.Write("Enter Seat Row (A, B, C...): ");
            char row = char.Parse(Console.ReadLine());

            Console.Write("Enter Seat Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());

            Seat seat = new Seat(row, number);
            Ticket ticket = new Ticket(movie, type, seat, price);

            // Before discount
            ticket.PrintTicket(14);

            Console.WriteLine();
            Console.WriteLine("===== After Discount =====");
            Console.WriteLine($"Discount Before : {discount:0.00}");

            ticket.ApplyDiscount(discount);

            Console.WriteLine($"Discount After  : 0.00");

            ticket.PrintTicket(14);
            #endregion
        }
    }
}
