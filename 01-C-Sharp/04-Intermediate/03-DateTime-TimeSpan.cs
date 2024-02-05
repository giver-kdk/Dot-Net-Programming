using System;

namespace DateTimeProgram
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// NOTE: 'DateTime' is a struct(not class) used to represent a single point of time
			// Default date is: 1/1/0001 12:00:00 AM
			DateTime myDate = new DateTime();
			Console.WriteLine("Default Date: {0}", myDate);
			Console.WriteLine("Default Date ToString: {0}", myDate.ToString());

			// Speacifying custom date in Year/Month/Day format
			// 'var' automatically sets 'DateTime' struct type 
			var date = new DateTime(2023, 12, 24);
			Console.WriteLine("Custom Date: {0}", date);
			// Speacifying custom date in Year/Month/Day/Hr/Min/Sec format
			var detailDate = new DateTime(2023, 12, 24, 03, 15, 36);
			Console.WriteLine("Detail Date: {0}", detailDate);

			// String to DateTime conversion
			var parsedDate = DateTime.Parse("2022/06/25");
			Console.WriteLine("Parsed Date: {0}", parsedDate);

			// If not sure about string to be parsed. Then, use 'TryParse'
			bool isParsed = DateTime.TryParse("2020/08/15", out DateTime parsedOutDate);
			Console.WriteLine("Date Parsable: {0}", isParsed);
			// If parsable, then parsed date stored in 'parsedOutData'
			Console.WriteLine("Date Parsed: {0}", parsedOutDate);


			// DateTime methods
			Console.WriteLine("Normal Date: {0}", detailDate);
			// 'AddSeconds()' doesn't modify the original DateTime 
			detailDate = detailDate.AddSeconds(6);
			// Negative argument subtracts the DateTime
			detailDate = detailDate.AddSeconds(-2);
			Console.WriteLine("Added Second: {0}", detailDate);
			detailDate = detailDate.AddMinutes(5);
			Console.WriteLine("Added Minutes: {0}", detailDate);
			detailDate = detailDate.AddHours(5);
			Console.WriteLine("Added Hours: {0}", detailDate);
			detailDate = detailDate.AddDays(5);
			Console.WriteLine("Added Days: {0}", detailDate);
			detailDate = detailDate.AddMonths(5);
			Console.WriteLine("Added Months: {0}", detailDate);
			detailDate = detailDate.AddYears(5);
			Console.WriteLine("Added Years: {0}", detailDate);

			// DateTime methods for output format
			Console.WriteLine("Long Date Format: {0}", detailDate.ToLongDateString());
			Console.WriteLine("Long Time Format: {0}", detailDate.ToLongTimeString());
			Console.WriteLine("Short Date Format: {0}", detailDate.ToShortDateString());
			Console.WriteLine("Short Time Format: {0}", detailDate.ToShortTimeString());

			// DateTime instance Fields
			Console.WriteLine("Day of Week: {0}", detailDate.DayOfWeek);
			Console.WriteLine("Day of Year: {0}", detailDate.DayOfYear);
			Console.WriteLine("Full Date: {0}", detailDate.Date);
			Console.WriteLine("Day of Year: {0}", detailDate.DayOfYear);
			Console.WriteLine("Millisecond Value: {0}", detailDate.Millisecond);
			Console.WriteLine("Second Value: {0}", detailDate.Second);
			Console.WriteLine("Minute Value: {0}", detailDate.Minute);
			Console.WriteLine("Hour Value: {0}", detailDate.Hour);
			Console.WriteLine("Day Value: {0}", detailDate.Day);
			Console.WriteLine("Month Value: {0}", detailDate.Month);
			Console.WriteLine("Year Value: {0}", detailDate.Year);

			// DateTime Fields
			Console.WriteLine("Current Date: {0}", DateTime.Now);
			Console.WriteLine("Current Day with Time reset: {0}", DateTime.Today);


			// 'TimeSpan' is used to represent time duration
			// Default TimeSpan is 00:00:00
			TimeSpan defaultTime = new TimeSpan();
			Console.WriteLine("Default Timespan: {0}", defaultTime);

			// Time period in 'Hr/Min/Sec/Millisec' Format
			var shortSpan = new TimeSpan(03, 25, 45);
			Console.WriteLine("Custom Short Timespan: {0}", shortSpan);

			// Time period in 'Days/Hr/Min/Sec' Format
			var longSpan = new TimeSpan(03, 05, 45, 56);
			Console.WriteLine("Custom Long Timespan: {0}", longSpan);

			// Time period in 'Days/Hr/Min/Sec/Millisec' Format
			var detailSpan = new TimeSpan(04, 03, 05, 45, 800);
			Console.WriteLine("Custom Detail Timespan: {0}", detailSpan);

			// String to TimeSpan conversion same as for DateTime
			Console.WriteLine("Parsed Timespan: {0}", TimeSpan.Parse("03:25:45"));
			Console.WriteLine("Timespan Parsable: {0}", TimeSpan.TryParse("03:25:45", out TimeSpan parsedTimeSpan));
			Console.WriteLine("Timespan Parsed: {0}", parsedTimeSpan);

			// TimeSpan Methods
			var mySpan = new TimeSpan(2, 0, 0);
			// 'Add()' doesn't modify original TimeSpan
			Console.WriteLine("Normal TimeSpan: {0}", defaultTime);
			defaultTime = defaultTime.Add(mySpan);
			Console.WriteLine("Added TimeSpan: {0}", defaultTime);
			// Creating TimeSpan during argument passing
			defaultTime = defaultTime.Subtract(new TimeSpan(01, 0, 0));
			Console.WriteLine("Subtracted TimeSpan: {0}", defaultTime);

			// Subtracting DateTime gives TimeSpan
			DateTime start = new DateTime(2020, 02, 18);
			DateTime end = new DateTime(2020, 02, 25);
			TimeSpan period = end - start;
			Console.WriteLine("DateTime Difference: {0}", period);
			// Comparing the DateTime instances
			Console.WriteLine("Start End Equal: {0}", start == end);
			Console.WriteLine("Start Greater: {0}", start >= end);
			Console.WriteLine("Start Smaller: {0}", start <= end);

			// Instead of Adding Hrs, Mins, Sec individually.
			// TimeSpan can also be added in DateTime. 'Add()' doesn't modify original
			end = end.Add(period);          // Here, 'end' is DateTime
			Console.WriteLine("Added TimeSpan: {0}", end);
			end = end.Subtract(period);     // Here, 'period' is TimeSpan
			Console.WriteLine("Subtracted TimeSpan: {0}", end);

			// TimeSpan fields
			Console.WriteLine("Timespan millisecond: {0}", period.Microseconds);
			Console.WriteLine("Timespan second: {0}", period.Seconds);
			Console.WriteLine("Timespan minute: {0}", period.Minutes);
			Console.WriteLine("Timespan hour: {0}", period.Hours);
			Console.WriteLine("Timespan day: {0}", period.Days);
		}
	}
}