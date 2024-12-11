// See https://aka.ms/new-console-template for more information
//Welcome Message
Console.WriteLine("********** - Welcome to the sample calculator app - **********");

int resp = 0;
decimal num1 = 0;
decimal num2 = 0;

//Show calculator options
do
{
    try
    {
        Console.WriteLine("Please, select the number of the operation you want to execute.");
        Console.WriteLine("Para salir del programa, ingrese -1");
        Console.WriteLine("1.- Adition");
        Console.WriteLine("2.- Substraction");
        Console.WriteLine("3.- Multiply");
        Console.WriteLine("4.- Division");
        Console.WriteLine("5.- Modulus");
        Console.WriteLine("6.- Fibonacci sequence");
        resp = Convert.ToInt32(Console.ReadLine());
        if (resp >= 0)
        {
           
         //Prompt for user input
         Console.WriteLine("Please, enter the first number");
         num1 = Convert.ToDecimal(Console.ReadLine());

         Console.WriteLine("Please, enter the second number");
         num2 = Convert.ToDecimal(Console.ReadLine());
         


         decimal resultado = 0;

         //Decide which operation is needed based on selected option

            switch (resp)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                case 5:
                    resultado = num1 % num2;
                    break;
                case 6:
                    if (num2 <= num1)
                    {
                        Console.WriteLine("El numero 2 debe de ser mayor al numero 1");
                    }
                    else
                    {
                        for (decimal i = num1; i <= num2; i++)
                        {
                            resultado = resultado + i;
                        }
                    }
                    break;
                default:
                    throw new Exception("Se selecciono una opcion del menu invalida.");
            }

            Console.WriteLine($"El resultado de la operacion seleccionada es: {resultado}");
        }
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("No es posible dividir entre Cero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Presiona cualquier teclapara continuar.");
        Console.ReadLine();
        Console.Clear();
    }
   
} while (resp >= 0);

Console.WriteLine("********** - Thank you for using the sample calculator app - **********");