using System;
namespace PD_2
{
    public class MathClass
    {
		public double Reizini(double a, double b)
        {
            double c;
            c = a * b;
            return c;
        }

		public double Sadali(double a, double b)
        {
            double c;
            c = a / b;
            return c;
        }

		public double Kapini(double a, int b)
		{
			double c = a;

			for (int i = 1; i < b; i++)
			{
				c = c * a;
			}
            
			return c;
		}
    }
}
