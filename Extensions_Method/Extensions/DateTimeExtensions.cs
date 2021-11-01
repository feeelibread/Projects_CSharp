using System.Globalization;

namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime date)
        {
            TimeSpan duration = DateTime.Now.Subtract(date);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }

        }
    }
}