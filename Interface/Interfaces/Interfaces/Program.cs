using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Enter car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm)");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm)");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
}
