using Edesoft.Business;

double value;
double factor;

Console.Write("Digite um valor para calcular seu fatorial: ");
value = double.Parse(Console.ReadLine().Replace(",", "."));

CalculatorBusiness calculator = new CalculatorBusiness(value, out string message);

if (message is not null && message != "")
{
    Console.WriteLine(message);
    return;
}

factor = calculator.Factorial((int)value);
Console.WriteLine(factor);