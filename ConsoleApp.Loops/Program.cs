// See https://aka.ms/new-console-template for more information
//Simple for loop demo
//Print Hello, World 10 times
Console.WriteLine("Hello, World!");


//Ask user how many times  they wish to print hello world and print accordingly
//Console.WriteLine("How many times do you want to print the message?");
//int times = Convert.ToInt32(Console.ReadLine());

//for  (int i = 0; i < times; i++)
//{
//    Console.WriteLine($"Hello, World! - {i + 1} Times -");
//}
//Console.WriteLine("Loop completed!");


Console.WriteLine("********** Simple for loop **********");
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, world! - {i}");
}

Console.WriteLine("********** Simple for loop completed **********");


//While loop 

Console.WriteLine("********** Simple While loop **********");

int count = 0;

while(count < 10)
{
    Console.WriteLine($"Hello, world! - {count}");
    count++;
}


Console.WriteLine("Se sumaran los numeros que se ingresen y se imprimira el total. Para salir ingrese" +
    "numero negativo");
int numero = 0;
int suma = 0;
while(numero >= 0)
{
    Console.Write("Ingresa el numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    suma = suma + numero;
    Console.WriteLine($"La suma de los numeros es de :{suma}");
}

Console.WriteLine("********** Simple While loop Completed **********");

Console.WriteLine("********** Simple Do While loop **********");

int num = 0;
int sum = 0;
do
{
    Console.Write("Ingresa el numero: ");
    num = Convert.ToInt32(Console.ReadLine());
    sum = sum + num;
    Console.WriteLine($"La suma de los numeros es de :{sum}");
} while (num >= 0);

Console.WriteLine("********** Simple Do While loop Completed **********");

