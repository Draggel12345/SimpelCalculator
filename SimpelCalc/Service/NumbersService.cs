
using SimpelCalc.Data;


namespace SimpelCalc.Service
{
    class NumbersService : INumbers
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            if(a != 0 && b != 0)
            {
                return a / b;
            }
            return 0;
        }

        public double Multi(double a, double b)
        {
            return a * b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }
    }
}
