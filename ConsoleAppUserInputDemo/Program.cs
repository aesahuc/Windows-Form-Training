// Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

//Promt the user for input
Console.WriteLine("Ingresa tu nombre por favor");
name = Console.ReadLine();
Console.WriteLine("Ingresa tu edad");
age = Convert.ToInt32(Console.ReadLine());

//Process the data
int workingAgesRemaining = retirementAge - age;

//Output the results to the users
Console.WriteLine($"Nombre: {name}");
Console.WriteLine($"Edad: {age}");
Console.WriteLine($"Los años que falta para retirarse son {workingAgesRemaining}");

Console.WriteLine($"Los años que falta para retirarse son {workingAgesRemaining}");