using System;
using Try_Catch_2.Entities;
using Try_Catch_2.Entities.Exceptions;

namespace Try_Catch_2

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-In date (DD/MM/YYYY): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (DD/MM/YYYY): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("\nReservation: " + reservation);

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-In date (DD/MM/YYYY): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (DD/MM/YYYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("\nUpdated date: " + reservation);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
