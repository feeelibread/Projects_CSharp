using Delegates_1.Services;

double a = 10;
double b = 5;

BinaryNumericOperator op = CalculationService.ShowMax;
op += CalculationService.ShowSum;
op.Invoke(a, b);

delegate void BinaryNumericOperator(double n1, double n2);

