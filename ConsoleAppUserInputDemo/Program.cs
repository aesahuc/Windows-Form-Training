// Declare variables
using System.Globalization;

const int retirementAge = 65;
string? firstName = string.Empty;
string? lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary;
char gender = char.MinValue;
bool working = true;

//Promt the user for input
Console.Write("Ingresa tu nombre, por favor: ");
firstName = Console.ReadLine();

Console.Write("Ingresa tu apellido, por favor: ");
lastName = Console.ReadLine();

Console.Write("Ingresa tu fecha de nacimiento (dd/mm/yyyy), por favor: ");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year;

Console.Write("Ingresa tu salario, por favor: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Ingresa tu genero, por favor.(M o F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Trabajando? (True o False): ");
working = Convert.ToBoolean(Console.ReadLine());


//Process the data
int workingYearsRemaining = retirementAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

//Output the results to the users
Console.WriteLine($"Nombre: {firstName}{lastName}");
Console.WriteLine($"Edad: {age}");
Console.WriteLine($"Tu salario es: {salary.ToString("C")}");
Console.WriteLine($"Tu genero es: {gender}");
Console.WriteLine($"Estas empleado: {working}");
Console.WriteLine($"Los anos que falta para retirarse son {workingYearsRemaining}");
Console.WriteLine($"Año de retiro estimado {estimatedRetirementDate.Year    }");