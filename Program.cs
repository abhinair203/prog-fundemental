using System;
using System.Collections.Generic;

namespace LibraryUsersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // a. Declare and initialize an instance of either Student or Standard
            Student student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                Phone = "555-1234",
                Email = "john.doe@example.com",
                GPA = 3.5
            };

            // c. Declare and initialize at least 2 instances of Resource
            Resource resource1 = new Resource
            {
                Title = "The Catcher in the Rye",
                Author = "J.D. Salinger"
            };

            Resource resource2 = new Resource
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee"
            };

            // e. Declare and initialize a List of Resources and add the resources created in 4.c
            List<Resource> resources = new List<Resource> { resource1, resource2 };

            // f. Declare and initialize an instance of Borrowing
            Borrowing borrowing = new Borrowing
            {
                Resources = resources
            };

            // i. Set Borrowing start date to today, and end date to today + 10 days
            borrowing.StartDate = DateTime.Today;
            borrowing.EndDate = DateTime.Today.AddDays(10);

            // i. Set Borrowing start date to today, and end date to today + 10 days
            // (Assuming you have StartDate and EndDate properties in the Borrowing class)
            borrowing.StartDate = DateTime.Today;
            borrowing.EndDate = DateTime.Today.AddDays(10);

            // Displaying some information
            student.DisplayInfo();
            Console.WriteLine($"Borrowing start date: {borrowing.StartDate}");
            Console.WriteLine($"Borrowing end date: {borrowing.EndDate}");
            Console.WriteLine($"Access link: {borrowing.GenerateAccessLink()}");
            
            // Testing the ReturnResources method
            DateTime returnDateOnTime = DateTime.Today.AddDays(9);
            DateTime returnDateLate = DateTime.Today.AddDays(12);

            borrowing.ReturnResources(returnDateOnTime); // Should print "Thank you for returning the resources on time."
            borrowing.ReturnResources(returnDateLate); // Should print "User must pay fine."

        }
    }
}
