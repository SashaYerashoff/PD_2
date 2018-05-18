using System;
namespace PD_2
{
    public class Trissturis
    {
		private double AB, BC, CD;

		public void SetAB(double a)
		{
			AB = a;
		}
		public void SetBC(double a)
        {
            BC = a;
        }

		public void SetCD(double a)
        {
            CD = a;
        }

		public double GetAB()
		{
			return AB;
		}

		public double GetBC()
        {
            return BC;
        }
        
		public double GetCD()
        {
            return CD;
        }

		public double Perimetrs()
		{         
			return AB + BC + CD;
		}
    }
}
