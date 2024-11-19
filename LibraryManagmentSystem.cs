using System;

namespace LibraryManagementSystem
{
    // Base Class
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display information about the person
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Destructor
        ~Person()
        {
            Console.WriteLine("Person object is destroyed.");
        }
    }

    // Interface to enforce library rules
    public interface ILibraryRules
    {
        void FollowRules();
    }

    // Derived Class: Librarian
    public class Librarian : Person, ILibraryRules
    {
        public string EmployeeID { get; set; }

        // Constructor
        public Librarian(string name, int age, string employeeID) : base(name, age)
        {
            EmployeeID = employeeID;
        }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee ID: {EmployeeID}");
        }

        // Implement FollowRules method
        public void FollowRules()
        {
            Console.WriteLine("Librarian must ensure all library rules are followed.");
        }

        // Destructor
        ~Librarian()
        {
            Console.WriteLine("Librarian object is destroyed.");
        }
    }

    // Derived Class: Member
    public class Member : Person, ILibraryRules
    {
        public string MembershipID { get; set; }

        // Constructor
        public Member(string name, int age, string membershipID) : base(name, age)
        {
            MembershipID = membershipID;
        }

        // Method to borrow books
        public void BorrowBook()
        {
            Console.WriteLine($"{Name} has borrowed a book.");
        }

        // Implement FollowRules method
        public void FollowRules()
        {
            Console.WriteLine("Member must follow the library rules.");
        }

        // Destructor
        ~Member()
        {
            Console.WriteLine("Member object is destroyed.");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create Librarian object
            Librarian librarian = new Librarian("Alice", 30, "LIB123");
            librarian.DisplayInfo();
            librarian.FollowRules();

            // Create Member object
            Member member = new Member("Bob", 25, "MEM456");
            member.DisplayInfo();
            member.BorrowBook();
            member.FollowRules();

            // Objects will be destroyed at the end of Main
        }
    }
}
