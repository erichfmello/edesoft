namespace Edesoft.Business
{
    public class CalculatorBusiness
    {
        double factor = 0;

        public CalculatorBusiness(double value, out string message)
        {
            message = "";
            validateFactorialValue(value, out message);
        }

        public double Factorial(double value)
        {
            if (value == 1)
                return factor;

            factor = factor == 0 ? value * (value - 1) : factor * (value - 1);

            value--;
            Factorial(value);

            return factor;
        }

        #region PrivateMethods
        private void validateFactorialValue(double value, out string message)
        {
            message = "";

            if (value <= 0)
                Console.WriteLine("O número deve ser maior que zero!");

            int testValue = (int)value;
            if (testValue != value)
                Console.WriteLine("O número deve ser inteiro");
        }
        #endregion PrivateMethods
    }
}
