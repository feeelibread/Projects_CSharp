using Delegates_1.Services;

double a = 10;
double b = 5;

double result = CalculationService.Max(a, b);
Console.WriteLine(result);

result = CalculationService.Sum(a, b);
Console.WriteLine(result);

CalculationService.Square(a);
Console.WriteLine(result);

