using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Введите выражение для вычисления: ");
			string str = Console.ReadLine();

			int CountDigits = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if(char.IsDigit(str[i]))
				{
					CountDigits++;
				}
			}

			int[] DigitsArray = new int[CountDigits];

			int index = 0;
			for(int i = 0;i < str.Length;i++)
			{
				if (char.IsDigit(str[i]))
				{
					DigitsArray[index++] = str[i] - '0';
				}

			}

			Console.WriteLine("Цифры в массиве: ");
			foreach(int digit in DigitsArray)
			{
				Console.Write($"{digit}");
			}

			int CountOperators = 0;
			for (int i = 0; i < str.Length; ++i)
			{
				if (str[i] == '-' || str[i] =='+'|| str[i] =='*' || str[i] =='/')
				{
					CountOperators++;
				}
			}

			char[] OperatorsArray = new char[CountOperators];
			int index2 = 0;
			for (int i = 0; i < str.Length; ++i)
			{
				if (str[i] == '-' || str[i] == '+' || str[i] == '*' || str[i] == '/')
				{
					OperatorsArray[index2++] = str[i];
				}
			}

			Console.WriteLine("Символы в массиве: ");
			foreach (char operators in OperatorsArray)
			{
				Console.Write($"{operators}");
			}


		}
	}
}
