// Run with "dotnet run"

WorkWithIntegers();

// Basic demonstration of math in C#
void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}");
    Console.WriteLine($"a + b = {c}");

    // subtraction
    c = a - b;
    Console.WriteLine($"a - b = {c}");

    // multiplication
    c = a * b;
    Console.WriteLine($"a * b = {c}");

    // division
    c = a / b;
    Console.WriteLine($"a / b = {c}");
}