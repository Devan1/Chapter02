using static System.Console;
object height = 6.44; //storing a double in an object
object name = "Devan"; //storing a string in an object
Console.WriteLine($"{name} is {height} feet tall");

//int length1 = name.Length; // gives compile error
int length2 = ((string)name).Length; // tell the compiler it is a string, cast object name to string
Console.WriteLine($"{name} has {length2} characters");

//storing a string in a dynamic object
//string has a length property
dynamic something = "Devan";
WriteLine($"dynamic something lenght is {something.Length}");
//int does not have a length property
something = 12;

//an array of any type has a length property
something = new[] { 3, 4, 5 };

//this compiles but would throw an exception at runtime
//if you later store a data type that does not have a property named length
Console.WriteLine($"Lenght is {something.Length}");

//int population = 66_000_000;//66 million in the uk
//double weight = 1.88;//in kiograms
//decimal price = 4.99M; //in pounds sterling
//string fruit = "apples"; //strings use double quotes
//char letter = 'Z'; //chars use single quotes
//bool happy = true; //booleans have value of true or false

var population = 66_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "apples";
var letter = 'z';
var happy = true;

//good use of var because it avoids the repeated type
//as shown in the more verbose second statement
var xml1 = new XmlDocument(); //inferred typing
XmlDocument xml2 = new XmlDocument(); //

//bad use of var because we cannot tell the type, so we
//should use a specific type declaration as shown in 
//the second statement
var file1 = File.CreateText("something1.txt");//inferred typing
StreamWriter file2 = File.CreateText("something2.txt");

Console.WriteLine($"Default type of a string is '{default(string)}'");
Console.WriteLine($"Default type of a double is '{default(double)}'");
Console.WriteLine($"Default type of a int is '{default(int)}'");
Console.WriteLine($"Default type of a char is '{default(char)}'");
Console.WriteLine($"Default type of a decimal is '{default(decimal)}'");
Console.WriteLine($"Default type of a bool is '{default(bool)}'");
Console.WriteLine($"Default type of DateTime is '{default(DateTime)}'");


int number = 13;
Console.WriteLine($"Int number = '{number}'");
number = default;
Console.WriteLine($"Int number changed to default = '{number}'");

string[] names;

//allocating memory for four strings in an array
names = new string[4];
names[0] = "Devan";
names[1] = "Sam";
names[2] = "Emi";
names[3] = "Presley";


//looping through names
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine("--------------------");

string[] names2 = new[] { "Devan", "Sam", "Emi", "Presley" };
for (int i = 0; i < names2.Length; i++)
{
    Console.WriteLine(names2[i]);
}