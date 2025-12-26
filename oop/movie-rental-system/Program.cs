using System;
using System.Collections.Generic;

#region Users

class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public List<Purchase> Purchases { get; set; } = new();
    public List<MovieRequest> MovieRequests { get; set; } = new();
}

class Subscriber : User
{
    public int CreditBalance { get; set; }
    public List<Rental> Rentals { get; set; } = new();
    public List<CreditTransaction> CreditTransactions { get; set; } = new();
}

#endregion

#region Movies

class Movie
{
    public int MovieId { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int RentalCreditCost { get; set; }
    public bool IsAvailable { get; set; }
}

#endregion

#region Transactions

class Purchase
{
    public int PurchaseId { get; set; }
    public DateTime PurchaseDate { get; set; }
    public Movie Movie { get; set; }
}

class Rental
{
    public int RentalId { get; set; }
    public DateTime RentalDate { get; set; }
    public Movie Movie { get; set; }
}

class CreditTransaction
{
    public int TransactionId { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
}

#endregion

#region Requests

enum RequestStatus
{
    Pending,
    Approved,
    Rejected
}

class MovieRequest
{
    public int RequestId { get; set; }
    public DateTime RequestDate { get; set; }
    public RequestStatus Status { get; set; }
    public Movie Movie { get; set; }
}

#endregion

class Program
{
    static void Main()
    {
        // Demo objects (logic intentionally minimal)

        Movie movie = new Movie
        {
            MovieId = 1,
            Title = "Inception",
            Price = 50,
            RentalCreditCost = 10,
            IsAvailable = true
        };

        Subscriber subscriber = new Subscriber
        {
            UserId = 1,
            Name = "Umut",
            Email = "umut@example.com",
            CreditBalance = 20
        };

        Rental rental = new Rental
        {
            RentalId = 1,
            RentalDate = DateTime.Now,
            Movie = movie
        };

        subscriber.Rentals.Add(rental);
        subscriber.CreditBalance -= movie.RentalCreditCost;

        Console.WriteLine("Movie rented successfully.");
    }
}
