using System;
using System.Collections.Generic;

public abstract class User
{
    private DateTime _birthDate;
    private string _creditCardNumber;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
    }
}

public class Student : User
{
    public double GPA { get; set; }
}

public class Standard : User, IBillable
{
    public bool ProcessPayment()
    {
        return true; // Mock result
    }
}

public class Resource
{
    public string Title { get; set; }
    public string Author { get; set; }
}

public class Borrowing : IDownloadable
{
    public List<Resource> Resources { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool PickedUp { get; private set; }

    public string GenerateAccessLink()
    {
        return "https://mock-access-link.com"; // Mock access link
    }

    public void ReturnResources(DateTime returnDate)
    {
        if (returnDate > EndDate)
        {
            Console.WriteLine("User must pay fine.");
        }
        else
        {
            Console.WriteLine("Thank you for returning the resources on time.");
        }

        PickedUp = true;
    }
}


public interface IDownloadable
{
    string GenerateAccessLink();
}

public interface IBillable
{
    bool ProcessPayment();
}
