using Delegates_1.Services;

double a = 10;
double b = 5;

BinaryNumericOperator op = CalculationService.Sum;

double result = op(a, b);
Console.WriteLine(result);

delegate double BinaryNumericOperator(double n1, double n2);

