namespace SportsOrderApp.Core
{
    public static class HelperMethods
    {
        public static string CalculateDobAge(DateTime dob)
        {
            DateTime dateTimeToday = DateTime.UtcNow;
            TimeSpan difference = dateTimeToday.Subtract(dob);
            var firstDay = new DateTime(1, 1, 1);

            int totalYears = (firstDay + difference).Year - 1;

            int totalMonths = (totalYears * 12) + (firstDay + difference).Month - 1;

            int runningMonths = totalMonths - (totalYears * 12);

            int runningDays = (dateTimeToday - dob.AddMonths((totalYears * 12) + runningMonths)).Days;
            if (totalYears != 0)
            {
                return totalYears + " years ";
            }
            else if (totalYears == 0 && runningMonths != 0)
            {
                return runningMonths + " months ";
            }
            else
            {
                return runningDays + " days";
            }


        }
        public static DateTime JoinDateAndTimeString(string dateString, string timeString)
        {
            var index = dateString.IndexOf("T");
            if (index != -1) dateString = dateString.Remove(index);
            DateTime date = DateTime.Parse(dateString).Date;
            var time = DateTime.Parse(timeString).TimeOfDay;
            return date.Add(time);
        }

        public static int CalculateAge(DateTime dob)
        {
            DateTime dateTimeToday = DateTime.UtcNow;
            TimeSpan difference = dateTimeToday.Subtract(dob);
            var firstDay = new DateTime(1, 1, 1);

            int totalYears = (firstDay + difference).Year - 1;

            int totalMonths = (totalYears * 12) + (firstDay + difference).Month - 1;

            int runningMonths = totalMonths - (totalYears * 12);

            int runningDays = (dateTimeToday - dob.AddMonths((totalYears * 12) + runningMonths)).Days;
            return totalYears;

        }
    }
}
