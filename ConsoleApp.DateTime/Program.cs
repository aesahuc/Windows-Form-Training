using System.Globalization;
using System.Linq.Expressions;

Console.WriteLine("********** - DateTime manipulation - **********");


//Empty DateTime object
DateTime date = new DateTime();

//Create a DateTime from date and time
var dateOfBirth = new DateTime(1980, 12, 25);
Console.WriteLine($"My DOB is: {dateOfBirth}");

var exactDateAndTimeOfBirth = new DateTime(1980, 12, 25,14,45,25, DateTimeKind.Local);
Console.WriteLine($"My DOB is: {exactDateAndTimeOfBirth}");

Console.WriteLine($"Day of week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of day: {exactDateAndTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {exactDateAndTimeOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");



//Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"The time now is: {now}");

/*
//Create a DateTime from a String
Console.WriteLine("What is your DOB (MM/dd/yyyy): ");
string dob = Console.ReadLine();

var userDob = DateTime.Parse(dob);

Console.WriteLine($"Day of week: {userDob.DayOfWeek}");
Console.WriteLine($"Day of year: {userDob.DayOfYear}");
Console.WriteLine($"Time of day: {userDob.TimeOfDay}");
Console.WriteLine($"Tick: {userDob.Ticks}");
Console.WriteLine($"Kind: {userDob.Kind}");

//Change format DateTime
Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("MMM, dd-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("dd-MMM-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("dddd-MMMM-yyyy")}");

//Add aditional time
Console.WriteLine($"One hour from now is: " + now.AddHours(1));
Console.WriteLine($"One day from now is: " + now.AddDays(1));
Console.WriteLine($"One day ago from now is: " + now.AddDays(-1));
*/
/*
//Ticks from DateTime

Console.WriteLine("********** - DateTime Offset manipulation - **********");
//UTC - Coordinated Universal Time
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now date time: {now}");
Console.WriteLine($"UTC Now date time: {utcNow}");

//DateTimeOffSet and Time Zone Info
var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"User Time Zone: {tz}");

var dto = new DateTimeOffset(now, tz);
Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
Console.WriteLine($"Action was completed in India at: {indiaDateTime}");  
*/

Console.WriteLine("********** - Date Only and Time Only manipulation - **********");
//DateOnly
var dateOnly = new DateOnly(1980, 12, 25);
var nextDay = dateOnly.AddDays(1);
var previousDay = dateOnly.AddDays(-1);
var decadeLater = dateOnly.AddYears(10);
var previousMonth = dateOnly.AddMonths(-1);

Console.WriteLine($"The Date: {dateOnly}");
Console.WriteLine($"The next day: {nextDay}");
Console.WriteLine($"The previous day: {previousDay}");
Console.WriteLine($"The decade later: {decadeLater}");
Console.WriteLine($"The last Month: {previousMonth}");

var dateOnlyFromDateTimeNow = DateOnly.FromDateTime(now);
Console.WriteLine($"The Date only from Datetime: {dateOnlyFromDateTimeNow}");
/*
Console.WriteLine("What is your DOB (dd MMM yyyy):");
string dobDateOnly = Console.ReadLine();

var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"The date only: {theDateOnly}");
*/

//TimeOnly
var timeNow = TimeOnly.FromDateTime(now);
Console.WriteLine($"It is now {timeNow}");
Console.WriteLine($"It is now {timeNow:hh:mm tt}");

//Date Comparisons
var date1 = new DateTime(1985, 11, 23);
var date2 = new DateTime(1965, 1, 20);

Console.WriteLine($"Is '{nameof(date1)}' equal? {date1 == date2}");
Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
Console.WriteLine($"Is {date2} after? {date1 > date2}");
Console.WriteLine($"Is {date1} before? {date1 < date2}");

