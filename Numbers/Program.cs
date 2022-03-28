//unsigned interget means positive whole number or 0
uint naturalNumber = 23;

//integer means negative or positive whole number or 0
int integerNumber = -23;

//float means single precision floating point
//F suffix makes it a float literal
float realNumber = 2.3F;

//doulb emeans double precision floating point
double anotherRealNumber = 2.3;

decimal decimalNumber = 12.75M;

//three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

//check the three varialbe have the same value
//both should output true;
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

Console.WriteLine($"int {nameof(integerNumber)} is {sizeof(int)} bytes and can store numbers in the range of {int.MinValue} and {int.MaxValue}");
Console.WriteLine($"uint {nameof(naturalNumber)} is {sizeof(uint)} bytes and can store numbers in the range of {uint.MinValue} and {uint.MaxValue}");
Console.WriteLine($"float {nameof(realNumber)} is {sizeof(int)} bytes and can store numbers in the range of {float.MinValue} and {float.MaxValue}");
Console.WriteLine($"double {nameof(anotherRealNumber)} is {sizeof(double)} bytes and can store numbers in the range of {double.MinValue} and {double.MaxValue}");
Console.WriteLine($"decimal {nameof(decimalNumber)} is {sizeof(decimal)} bytes and can store numbers in the range of {decimal.MinValue} and {decimal.MaxValue}");

//the doulbe type is not guaranteed to be accurate because some numbers like 0.1 literally
//cannt be represented as floating point values.
//As a rule of thumb you should only use doulbe when accuracy, especially when comparing
//the equality of two numbers, is not important. An example of this may be when you're measuring
//a persons height and you will only compare values using greater than or less the, 
// but never equals. 
Console.WriteLine("Using Doubles");
double a = 0.1;
double b = 0.2;
if( a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does not equal {0.3}");
}

Console.WriteLine("Using Decimal");

decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3}");
}
else
{
    Console.WriteLine($"{c} + {d} does not equal {0.3}");
}
