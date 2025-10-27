using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Point A; //ссылка на объект
			Point A = new Point();
			//A.SetX(2);
			//A.SetY(3);
			A.X = 2;
			A.Y = 3;
			Console.WriteLine($"X={A.X},Y={A.Y}");
			A.Info();

			//Point B = A;
			//B.Info();
			//B.X *= 10;
			//A.Info();

			Point B = new Point (A);
			
			B.X *= 10;
			B.Info();
			A.Info();

			Point C = A + B;
			C.Info();
		}
	}
}
