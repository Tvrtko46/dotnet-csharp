// See https://aka.ms/new-console-template for more information

double mass = 80.0;
double height = 1.75;

Console.WriteLine("Hello, World!");

double Calculate_PI(double height, double mass)
{
    return mass / (height * height * height);
}

double pi = Calculate_PI(height, mass);

Console.WriteLine($"PI = {pi}");

// Tvrtko
// PI = 14,927113702623906


// https://www.health-calc.com/body-composition/ponderal-index/