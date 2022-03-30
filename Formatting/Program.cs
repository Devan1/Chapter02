using static System.Console; // static method so you dont have to type Console.
int numberOfApples = 12;
decimal pricePerApple = .35M;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
WriteLine(formatted);

//WriteToFile(formatted); //write the string into a file

WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "{0,-10} {1,6:NO}",
    arg0: "Name",
    arg1: "Count");
WriteLine(
    format: "{0,-10:NO} {1,6:NO}",
    arg0: applesText,
    arg1: applesCount);
WriteLine(
    format: "{0,-10:NO} {1,6:NO}",
    arg0: bananasText,
    arg1: bananasCount);

Write("Type your first name and press ENTER: ");
string? firstname = ReadLine();
Write("Type your age ande press ENTER: ");
string? age = ReadLine();
WriteLine($"Hello {firstname}, you look great for being {age}");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);