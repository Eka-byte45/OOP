using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите числитель первой дроби: ");
				int num1 = Convert.ToInt32(Console.ReadLine());

				Console.Write("Введите знаменатель первой дроби: ");
				int denom1 = Convert.ToInt32(Console.ReadLine());

				Fraction fraction1 = new Fraction(num1, denom1);
				fraction1.Print();

				Console.Write("Введите числитель второй дроби: ");
				int num2 = Convert.ToInt32(Console.ReadLine());

				Console.Write("Введите знаменатель второй дроби: ");
				int denom2 = Convert.ToInt32(Console.ReadLine());

				Fraction fraction2 = new Fraction(num2, denom2);
				fraction2.Print();

				Fraction resultAddition = fraction1 + fraction2;
				Console.Write($"Сложение дробей {num1}/{denom1} + {num2}/{denom2} = ");
				resultAddition.Print();

				Fraction resultSubstraction = fraction1 - fraction2;
				Console.Write($"Вычитание дробей {num1}/{denom1} - {num2}/{denom2} = ");
				resultSubstraction.Print();

				Fraction resultMultiplication = fraction1 * fraction2;
				Console.Write($"Умножение дробей {num1}/{denom1} * {num2}/{denom2} = ");
				resultMultiplication.Print();

				Fraction resultDivision = fraction1 / fraction2;
				Console.Write($"Деление дробей ({num1}/{denom1}) / ({num2}/{denom2}) = ");
				resultDivision.Print();

				Console.WriteLine($"Первая дробь больше второй:{fraction1 > fraction2}");
				Console.WriteLine($"Первая дробь меньше второй: {fraction1 < fraction2}");
				Console.WriteLine($"Первая дробь больше или равна второй:{fraction1 >= fraction2}");
				Console.WriteLine($"Первая дробь меньше или равна второй: {fraction1 <= fraction2}");
				Console.WriteLine($"Первая дробь равна второй:{fraction1 == fraction2}");
				Console.WriteLine($"Первая дробь не равна второй:{fraction1!=fraction2}");
			}
			catch(ArgumentException ex)
			{
				Console.WriteLine(ex.Message);

			}


		}
	}
}
