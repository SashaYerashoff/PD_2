using System;

namespace PD_2
{
    class Program
    {
        static void Main()
        {
			int selector;

			do
			{
				double aInput, bInput;
                
				Console.WriteLine("1: a+b, 2: a-b, 3: a*b, 4: a/b, 5: a^b, 6: triangle, 7: a+-b array, 0: exit");
				Console.WriteLine("---------------------------------------------------------------------------");
				       
				selector = Convert.ToInt16(Console.ReadLine());
				MathClass DoMath = new MathClass();
                
                switch (selector)
				{
					case 1:        
						Console.Write("Ievadi a: ");
                        aInput = Parbaude.Readouble();

                        Console.Write("Ievadi b: ");
                        bInput = Parbaude.Readouble();
						Console.WriteLine(Saskaiti(aInput, bInput));
						break;
                        
					case 2:
						Console.Write("Ievadi a: ");
                        aInput = Parbaude.Readouble();

                        Console.Write("Ievadi b: ");
                        bInput = Parbaude.Readouble();
						Console.WriteLine(Atnem(aInput, bInput));
						break;

					case 3:
						Console.Write("Ievadi a: ");
                        aInput = Parbaude.Readouble();

                        Console.Write("Ievadi b: ");
                        bInput = Parbaude.Readouble();
						double output = DoMath.Reizini(aInput, bInput);
						Console.WriteLine("DoMath reizināšana: {0}", output);
						break;

					case 4:
						Console.Write("Ievadi a: ");
                        aInput = Parbaude.Readouble();

                        Console.Write("Ievadi b: ");
                        bInput = Parbaude.Readouble();

						output = DoMath.Sadali(aInput, bInput);
						Console.WriteLine("DoMath dalīšana: {0}", output);
						break;

					case 5:
						
						Console.Write("Ievadi kāpināmo: ");
						aInput = Parbaude.Readouble();

						Console.Write("Ievadi kāpinātāju: ");
						int pakape = Parbaude.Readint();

						output = DoMath.Kapini(aInput, pakape);
						Console.WriteLine("DoMath kāpināšana: {0}", output);
						break;

					case 6:
						Trissturis Trissturis1 = new Trissturis();
						double starprez;

						Console.Write("Ievadi AB trisstura malu: ");
						starprez = Parbaude.Readouble();

						while (starprez < 0)
						{
							Console.Write("Kļūda! Ievadi lūdzu pozitīvo skaitli: ");
							starprez = Parbaude.Readouble();
						}

						Trissturis1.SetAB(starprez);

						Console.Write("Ievadi BC trisstura malu: ");
						starprez = Parbaude.Readouble();

						while (starprez < 0)
						{
							Console.Write("Kļūda! Ievadi lūdzu pozitīvo skaitli: ");
							starprez = Parbaude.Readouble();
						}

						Trissturis1.SetBC(starprez);

						Console.Write("Ievadi CD trisstura malu: ");
						starprez = Parbaude.Readouble();;

						while (starprez < 0)
						{
							Console.Write("Kļūda! Ievadi lūdzu pozitīvo skaitli: ");
							starprez = Parbaude.Readouble();
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
