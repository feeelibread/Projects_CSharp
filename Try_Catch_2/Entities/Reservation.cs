using System;
using System.Collections.Generic;
using System.Text;

namespace Try_Catch_2.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates!";
            }
            if (checkOut <= checkIn)
            {
                return "The check-out date must be after than the check-in date!";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToShortDateString()}, check-out: {CheckOut.ToShortDateString()}, {Duration()} nights";
        }

    }
}
