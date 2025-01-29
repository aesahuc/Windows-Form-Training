// See https://aka.ms/new-console-template for more information
Console.WriteLine("********** - String Manipulation - **********");

// Initialize with a regular string literal.
string s1 = "This is a literal string";
Console.WriteLine(s1);
String  s2 = "This is a literal string";
Console.WriteLine(s2);

// Declare without initializing. (possible null exception).
//string s3;
//Console.WriteLine(s3);

// Initialize to null. (possible null exception).
string? s4 = null;
Console.WriteLine(s4);
// Initialize as an empty string.
string s5 = string.Empty; //""
Console.WriteLine(s5);
string s6 = " ";
Console.WriteLine(s6);

// Escape sequences and characters
//She said, "I have yout phone"
string sentence = "She said, \"I have your phone\" \r\n This is the next line";
Console.WriteLine(sentence);
// Verbatim string literal.
string oldPath = "C:\\program files\\programfolder\\";
Console.WriteLine(oldPath);
string newPath = @"C:\program files\programfolder\";
Console.WriteLine(newPath);

// Use const string to prevent modification of a string
const string path = "C:\\program files\\programfolder\\";
Console.WriteLine(path);
//path = "New value"; Illegal operation against a constant

// Raw string literals
string rawLiteral = """ \ñasjdñlk '" This is a literal string """;
Console.WriteLine(rawLiteral);
string rawLiteral1 = """
    \ñasjdñlk '" This is a literal string
    Thi is the next line and another one
    "C:\program files\programfolder\"
    """;
Console.WriteLine(rawLiteral1);

// Review concatenation and interpolation 
s1 = s1 + s2;
Console.WriteLine(s1);
s1 += s2;
Console.WriteLine(s1);
string newString = $"{s1}{s2} Some random litteral text";
Console.WriteLine(newString);
string newString1 = s1 + $"{s1}{s2} Some random litteral text";
Console.WriteLine(newString1);
string newString2 = string.Format("Literal string {0} {1}", s1,s2);
Console.WriteLine(newString2);
/* String manipulation methods and properties. Some times is just assesment*/

// Null or empty checks
//Find the lenght of a string

Console.WriteLine($"{nameof(s1)} has a lenght of {s1.Length}");
Console.WriteLine($"{nameof(s4)} has a lenght of {s6.Length}");
/*Console.WriteLine($"{nameof(s1)} has a lenght of {s4.Length}"); Will cause a Null exception*/

//if(string.IsNullOrEmpty(s4) == false)
if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s1)} has a lenght of {s4.Length}");
}

if (string.IsNullOrEmpty(s5) == false) 
{
    Console.WriteLine($"{nameof(s1)} has a lenght of {s5.Length}");
}

// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)} : {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)} : {subString}");

//splitting strings
var splitStrings = s2.Split(' ');
for(int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine(splitStrings[i]);
}

//Replace
string replacement1 = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replacement1)}:{replacement1}");
string replacement2 = s1.Replace("string", "Chicken");
Console.WriteLine($"{nameof(replacement2)}:{replacement2}");

//Convert to string
string salary = 48333648.526.ToString();
int value = 44456952;
string strValue = value.ToString();
bool choosen = true;

choosen.ToString();

//Changing Formatting
Console.WriteLine($"{nameof(salary)}:{salary:C}");
Console.WriteLine(nameof(salary) + ": " +   value.ToString("C"));