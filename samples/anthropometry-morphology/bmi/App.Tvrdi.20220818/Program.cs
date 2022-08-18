// See https://aka.ms/new-console-template for more information

double mass = 80.0;
double height = 1.75;

Console.WriteLine("Hello, World!");

double Calculate_BMI(double height, double mass)
{
    return mass / (height * height);
}

double bmi = Calculate_BMI(height, mass);

Console.WriteLine($"BMI = {bmi}");

// Tvrtko
// BMI = 26,122448979591837






