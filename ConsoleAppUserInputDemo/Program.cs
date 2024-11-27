// Declare variables
string? firstName = string.Empty;
string? lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;

//Promt the user for input
Console.Write("Ingresa tu nombre, por favor: ");
firstName = Console.ReadLine();

Console.Write("Ingresa tu apellido, por favor: ");
lastName = Console.ReadLine();

Console.Write("Ingresa tu edad, por favor: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa tu salario, por favor: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Ingresa tu genero, por favor.(M o F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Trabajando? (True o False): ");
working = Convert.ToBoolean(Console.ReadLine());


//Process the data
int workingAgesRemaining = retirementAge - age;

//Output the results to the users
Console.WriteLine($"Nombre: {firstName}{lastName}");
Console.WriteLine($"Edad: {age}");
Console.WriteLine($"Tu salario es: {salary}");
Console.WriteLine($"Tu genero es: {gender}");
Console.WriteLine($"Estas empleado: {working}");
Console.WriteLine($"Los anos que falta para retirarse son {workingAgesRemaining}");