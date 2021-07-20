using System;
using Try_Catch_2.Entities.Exceptions;
namespace Try_Catch_2.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("The check-out date must be after than the check-in date!");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates!");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("The check-out date must be after than the check-in date!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
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
