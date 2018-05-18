using System;

namespace PD_2
{
    class Program
    {
        static void Main(string[] args)
        {
			int selector;

			do
			{
				Console.WriteLine("izvēlne: 1 - saskaitīt, 2 - atņemt, 3 - reizināt, 4 - dalīt, 5 - kāpināt, 6 - Trīssturis, 7 - masīvs, 0 - iziet");
				selector = Convert.ToInt16(Console.ReadLine());
				MathClass DoMath = new MathClass();

				switch (selector)
				{
					case 1:
						Console.WriteLine(Saskaiti(2, 4.4));
						break;

					case 2:
						Console.WriteLine(Atnem(-2, -10));
						break;

					case 3:
						double output = DoMath.Reizini(3, 4);
						Console.WriteLine("DoMath reizināšana: {0}", output);
						break;

					case 4:
						output = DoMath.Sadali(3, 4);
						Console.WriteLine("DoMath dalīšana: {0}", output);
						break;

					case 5:
						double a;
						int b;
						Console.Write("Ievadi kāpināmo: ");
						a = Convert.ToDouble(Console.ReadLine());

						Console.Write("Ievadi kāpinātāju: ");
						b = Convert.ToInt32(Console.ReadLine());

						output = DoMath.Kapini(a, b);
						Console.WriteLine("DoMath kāpināšana: {0}", output);
						break;

					case 6:
						Trissturis Trissturis1 = new Trissturis();
						double starprez;

						Console.Write("Ievadi AB trisstura malu: ");
						starprez = Convert.ToDouble(Console.ReadLine());

						while (starprez < 0)
						{
							Console.Write("Kļūda! Ievadi lūdzu pozitīvo skaitli: ");
							starprez = Convert.ToDouble(Console.ReadLine());
						}

						Trissturis1.SetAB(starprez);

						Console.Write("Ievadi BC trisstura malu: ");
						starprez = Convert.ToDouble(Console.ReadLine());

						while (starprez < 0)
						{
							Console.Write("Kļūda! Ievadi lūdzu pozitīvo skaitli: ");
							starprez = Convert.ToDouble(Console.ReadLine());
						}

						Trissturis1.SetBC(starprez);

						Console.Write("Ievadi CD trisstura malu: ");
						starprez = Convert.ToDouble(Console.ReadLine());

						while (starprez < 0)
						{
							Console.Write("Kļūda! Ievadi lūdzu pozitīvo skaitli: ");
							starprez = Convert.ToDouble(Console.ReadLine());
						}

						Trissturis1.SetCD(starprez);

						Console.WriteLine("Trīsstura perimetrs ir: {0}", Trissturis1.Perimetrs());

						break;

					case 7:
						string[] masivs = new string[3];

						Console.Write("Ievadi a: ");
						masivs[0] = Console.ReadLine();

						Console.Write("Ievadi b: ");
						masivs[1] = Console.ReadLine();

						Console.Write("Ievadi + vai - : ");
						masivs[2] = Console.ReadLine();

						Console.WriteLine("Rezultāts ir: {0}", SaskaitiMasivu(masivs[0], masivs[1], masivs[2]));
						break;
                        
					case 0:
						break;
				}


			}
			while (selector != 0);
        }

		static double Saskaiti(double a, double b)
		{
			double c;
			c = a + b;
			return c;
		}

		static double Atnem(double a, double b)
		{
			double c;
			c = a - b;
			return c;
		}

		static double SaskaitiMasivu(string a, string b, string mathsimbol)
		{
			double rez =0;
			switch(mathsimbol)
			{
				case "+":
					rez = Convert.ToDouble(a) + Convert.ToDouble(b);
					break;
				case "-":
                    rez = Convert.ToDouble(a) - Convert.ToDouble(b);
                    break;
			}

            
			return rez;
		}
    }
}
