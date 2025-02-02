Console.WriteLine("********** - Methods - **********");

//void Methods - complete a task without returning a value
void  PrintName ()
{
    //Method code
    Console.WriteLine("Esahu");
}

//value returning methods - returns a value after an operation

int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}

//methods with parameters

void PrintNameWithParams(string name)
{
    Console.WriteLine(name);
}

int GetYearDifferenceWithParams(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}

//methods with optional parameters - parameters as not required..also has a default value
int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

//methods with nullable parameters
void PrintNameNullableParam(string? name, int? count)
{
    //if (string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";
    //}

    // The null-coalescing assigment operator  ??= assings the value of its right-hand operand ot its left-hand operand if the
    //left-hand operand evaluates to null.
    https://learn.microsoft.com/en-us/dotnet/csharp/languange-reference/operators/null-coalesing-operator
    name ??= "Default name";

    //if (!count.HasValue)
    //{
    //    count = 1;
    //}
    count ??= 1;

    for(int i=0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}

/* Function Calls */
//PrintName();
//int fiveYearsAgo = GetFiveYearsAgo();
//Console.WriteLine("Five Years Ago was: " + fiveYearsAgo);

//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();
//PrintNameWithParams("your name is " + name);

//Console.WriteLine("Enter a year: ");
//int pastYear = Convert.ToInt32(Console.ReadLine());
//int yearsAgo = GetYearDifferenceWithParams(pastYear);
//Console.WriteLine("This was: " + yearsAgo);

//Console.WriteLine("Enter number of years in the future or past: ");
//int numberOfYears = Convert.ToInt32(Console.ReadLine());

//var pastYear1 = GetFutureOrPastYear();
//Console.WriteLine("The year is " + pastYear1);

//var pastYear2 = GetFutureOrPastYear(numberOfYears);
//Console.WriteLine("The year is " + pastYear2);

PrintNameNullableParam(null, null);
PrintNameNullableParam("chester", 5);