using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Fraction
	{
		int numerator;
		int denominator;

		public int Numerator
		{
			get
			{
				return numerator;

			}
			set
			{
				numerator = value;
			}
		}

		public int Denominator
		{
			get
			{
				return denominator;
			}
			set
			{
				denominator = value;
			}
		}

		public int wholePart
		{
			get
			{
				return numerator/denominator;
			}
		}
		public Fraction remainingFraction
		{
			get
			{
				int remainingNumerator = numerator%denominator;
				return new Fraction(remainingNumerator, denominator);
			}
		}
		public Fraction(int numerator, int denominator)
		{
			if(denominator ==0)
			{
				throw new ArgumentException("Знаменатель не должен быть равен нулю.");
			}
			this.numerator = numerator;
			this.denominator = denominator;
			Reduce();
		}

		public void Print ()
		{
			if (numerator == 0)
			{
				Console.WriteLine("0");
			}
			else if (wholePart != 0 && remainingFraction.Numerator == 0)
			{
				Console.WriteLine($"{wholePart}"); // Если целая часть есть и дробная часть равна нулю, выводим только целую часть
			}
			else if(wholePart!=0)
			{
                Console.WriteLine($"{wholePart} {remainingFraction.Numerator}/{remainingFraction.Denominator}");
			}
			else
			{
				Console.WriteLine($" {numerator}/{denominator}");
			}
			
		}

		public static int GreatestCommonDivisor(int a, int b)
		{
			while(b!=0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a >= 0 ? a : -a;
		}
		private void Reduce()
		{
			int gcd = GreatestCommonDivisor(this.numerator,this.denominator);
			this.numerator/=gcd;
			this.denominator/=gcd;
		}
		public static Fraction operator+ (Fraction f1, Fraction f2)
		{
			int commonDenominator = f1.Denominator*f2.Denominator;
			int newNominator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;

			return new Fraction(newNominator,commonDenominator); 
		}

		public static Fraction operator- (Fraction f1, Fraction f2)
		{
			int commonDenominator = f1.Denominator*f2.Denominator;
			int newNominator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;

			return new Fraction(newNominator,commonDenominator);
		}

		public static Fraction operator *(Fraction f1, Fraction f2)
		{
			int newDenominator = f1.Denominator * f2.Denominator;
			int newNominator = f1.Numerator*f2.Numerator;

			return new Fraction(newNominator, newDenominator);
		}

		public static Fraction operator /(Fraction f1, Fraction f2)
		{
			int newNominator = f1.Numerator * f2.Denominator;
			int newDenominator = f1.Denominator * f2.Numerator;

			return new Fraction(newNominator, newDenominator);
		}

		public static bool operator> (Fraction f1, Fraction f2)
		{
			return (f1.Numerator*f2.Denominator) > (f2.Numerator*f1.Denominator);
		}

		public static bool operator<(Fraction f1, Fraction f2)
		{
			return (f1.Numerator * f2.Denominator) < (f2.Numerator * f1.Denominator);
		}

		public static bool operator >=(Fraction f1, Fraction f2)
		{
			return (f1.Numerator * f2.Denominator) >= (f2.Numerator * f1.Denominator);
		}

		public static bool operator <=(Fraction f1, Fraction f2)
		{
			return (f1.Numerator * f2.Denominator) <= (f2.Numerator * f1.Denominator);
		}
		public static bool operator== (Fraction f1, Fraction f2)
		{
			return (f1.Numerator * f2.Denominator) == (f2.Numerator * f1.Denominator);
		}

		public static bool operator!= (Fraction f1, Fraction f2)
		{
			return !(f1 == f2);
		}
	}
}
