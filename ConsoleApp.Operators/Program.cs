// See https://aka.ms/new-console-template for more information
Console.Write("Por favor, ingrese el primer numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.Write("Por favor, ingrese el segundo numero: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/*
    Math Operations and Operators 
 */

//Add numbers
int sum = num1 + num2;

//Multiply
int product = num1 * num2;

//Division
int quotient = num1 / num2;

//Subtraction
int difference = num1 - num2;

//Modulus
int mod = num1 % num2;

Console.WriteLine("**********Math Results**********");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Multiply: {product}");
Console.WriteLine($"Division: {quotient}");
Console.WriteLine($"Subtraction: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("**********End Math Results**********");
/*
    Logic Operations and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine("**********Logic Results**********");
Console.WriteLine($"Is greater than: {isGreaterThan}");
Console.WriteLine($"Is less than: {isLessThan}");
Console.WriteLine($"Is equal to: {isEqualTo}");
Console.WriteLine($"Is greater than or equal to: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is less than or equal to: {isLessThanOrEqualTo}");
Console.WriteLine($"Is not equal to: {isNotEqualTo}");
Console.WriteLine("**********End Logic Results**********");

/*
    Assigment Operators 
 */
//int randomValue = 5;
//int increaseRandomValue = num1;
//num1 = num1 + 5;
Console.WriteLine("**********Assigment Results**********");
num1 += 5;
Console.WriteLine($"Num1 value + 5: {num1}");
num1 -= 3;
Console.WriteLine($"Num1 value - 3: {num1}");
num1 /= 2;
Console.WriteLine($"Num1 value / 2: {num1}");
num1 %= 2;
Console.WriteLine($"Num1 value % 2: {num1}");
num1 *= 10;
Console.WriteLine($"Num1 value * 10: {num1}");
Console.WriteLine("**********End Assigments Results**********");

