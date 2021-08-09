using System;

namespace Interface_1.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finished { get; set; }
        public Vehicle Vechicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finished, Vehicle vechicle)
        {
            Start = start;
            Finished = finished;
            Vechicle = vechicle;
        }
    }
}
