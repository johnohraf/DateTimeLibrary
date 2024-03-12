namespace Genba_DateTimeLibrary
{
    public class DateTimeLibrary
    {
        public static TimeSpan GetDateDifference(DateTime date1, DateTime date2)
        {
            return date2 - date1;
        }

        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public static string GetTimeOfDay(DateTime time)
        {
            if (time.Hour < 12)
                return "Morning";
            else if (time.Hour < 18)
                return "Afternoon";
            else
                return "Evening";
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}