// See https://aka.ms/new-console-template for more information
//Prompt for imput
Console.WriteLine("Por favor, ingrese la calificación del estudiante: ");

//Global variable / Global scope
int grade = Convert.ToInt32(Console.ReadLine());

//Decidir si se imprime si pasa o reprueba basado en el input

Console.WriteLine("*********Simple IF results**********");
if (grade > 15){
    Console.WriteLine("El alumno ha pasado");
}
else{
    Console.WriteLine("El aluno no ha pasado");
}
Console.WriteLine("**********Simple IF results end");

//Complex IF... ELSE IF... statements - Decide ti print a letter based on a grade value
Console.WriteLine("*********Complex IF...ELSE IF results");

/*
 * A: 86 - 100 
 * B: 75 - 84
 * C: 65 - 74
 * C-: 51 - 64
 * F: less than 50 X
 */
if (grade < 0 || grade > 100)
{
    Console.WriteLine("El valor de la calificación es incorrecto.");
}
else if(grade < 50)
{
    Console.WriteLine("El estudiante ha fallado - F");
}else if(grade >= 50 && grade <= 64)
{
    Console.WriteLine("C-");
}
else if(grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <=84)
{
    Console.WriteLine("B");
}
else if(grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good job");
}
else
{
    Console.WriteLine("El valor de la calificación es incorrecto.");
}

Console.WriteLine("*********Complex IF...ELSE IF results end");

//Ternary operator - Used to assign a value to a variable based on a condition.
Console.WriteLine("********** Ternary Operators Result **********");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"The student status is {passStatus}");

Console.WriteLine("********** Ternary Operators Result End **********");

//Switch Statements - used to evaluate a value and take an action
Console.WriteLine("********** Switch Statements Result **********");
/*
 *Write a program to accept an integer as a day of the week and print the appropiate
  message as outlined below.
1 - Sunday
2 - Monday
3 - Tuesday
4 - Wednesday (Hump Day!)
5 - Thursday
6 - Friday (TGIF!!!)
7 - Saturday (Beach Day!!!)
 */

Console.Write("Introduce el numero del día: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

switch (DayOfWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday (Hump Day!)");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday (TGIF!!!)");
        break;
    case 7:
        Console.WriteLine("Saturday (Beach Day!!!)");
        break;
    default:
        Console.WriteLine("El valor que introdujo es incorrecto");
        break;
}

Console.WriteLine("********** Switch Statements Result End **********");

//Resto del programa
Console.WriteLine("Gracias por usar este programa");