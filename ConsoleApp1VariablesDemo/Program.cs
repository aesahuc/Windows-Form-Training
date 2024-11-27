// See https://aka.ms/new-console-template for more information


//Different data types

/*
    text - string
    integers - int
    decimals - double, float, decimal
    logical - bool
 */

string name = "Esahu Colorado";

Console.WriteLine(name);
Console.WriteLine($"I am " + name); //String concatenation
Console.WriteLine($"They call me {name}"); //String interpolation
Console.WriteLine("I was given the name of {0}", name); //Formated String

int age = 35;
int retirementYearsLeft = 30;
int retirementAge = age + retirementYearsLeft;
Console.WriteLine("Mi age is " + age);
Console.WriteLine("My retirement age is " + retirementAge);

bool isRetired = false;
Console.WriteLine("I am retired? " + isRetired);
