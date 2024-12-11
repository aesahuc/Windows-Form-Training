// See https://aka.ms/new-console-template for more information

//Write a program that take a user's age as input and prints it to the screen.
//Display an error message if an invalid input is received.



try
{
    Console.Write("Ingresa tu edad: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Tu tienes {age} años.");
}
catch
{
    Console.WriteLine("El valor en la edad es incorrecto, por favor, intenta de nuevo.");
}
finally
{
    Console.WriteLine("********** Gracias por usar este programa **********");
}