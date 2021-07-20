using System;
using Try_Catch_2.Entities;

namespace Try_Catch_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (DD/MM/YYYY): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (DD/MM/YYYY): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error! The check-out date must be after than the check-in date!");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("\nReservation: " + reservation);

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-In date (DD/MM/YYYY): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (DD/MM/YYYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates!");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error! The check-out date must be after than the check-in date!");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("\nUpdated date: " + reservation);
                }

            }

        }
    }
}
