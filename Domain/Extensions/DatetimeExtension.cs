using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.Domain.Extensions
{
    public static class DatetimeExtension
    {
        public static DateTime IuguDateToDateTime(this string date)
        {
            var formatDate = date.Split('/');
            return new DateTime(int.Parse(formatDate[0]), int.Parse(formatDate[1]), int.Parse(formatDate[2]));
        }
        public static DateTime FirstDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime LastDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1, 23, 59, 59).AddMonths(1).AddDays(-1);
        }

        public static DateTime ToLastMoment(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        }

        public static DateTime ToFirstMoment(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
        }
        public static bool IsBetween(this DateTime date, DateTime begin, DateTime end)
        {
            return date >= begin && date <= end.ToLastMoment();
        }
    }
}
