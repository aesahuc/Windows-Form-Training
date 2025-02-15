Console.WriteLine("********** - Arrays - **********");

//Tell me how many students and grades are to be entered
Console.WriteLine("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

//Declare a Fixed size array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];
// 5 space addresses/indexes - 0, 1, 2, 3, 4
// If n is the size of the array, then your array addresses between 0 to n-1

//Add values to a fixed size array
//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 28;
//grades[3] = 45 ;
//grades[4] = 54;

for(int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine("Enter a student name: ");
    students[i] = Console.ReadLine();

    Console.WriteLine("Enter a grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

////Print values in a fixed size array
//for (int i = 0; i < grades.Length; i++)
//{
//    Console.WriteLine($"The grade in the position {i + 1} is {grades[i]}");
//}

Console.WriteLine("The grades you have entered are: ");
for (int i = 0; i <numberOfGrades; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

//Declare a variable sized array

//string[] studentNames = { "Newton", "Joshua", "etc..." };

////Add values to a variable sized array
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine("Enter a student name: ");
//    studentNames[i] = Console.ReadLine();
//}
////Print values in a variable sized array
//Console.WriteLine("The student names you have entered are: ");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}