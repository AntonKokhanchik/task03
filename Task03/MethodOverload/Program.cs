using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
	class Program				//Создайте консольное приложение для вывода абсолютного значения вводимого с клавиатуры
								//числа. Реализуйте несколько версий функции получения абсолютного значения для разных типов: int, double, long.
	{
		static void Main(string[] args)
		{
			int i;
			long l;
			double d;

			do
			{
				Console.Write("Введите число типа int: ");
				i = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Его абсолютное значение: {0}", MyAbs(i));

				Console.Write("Введите число типа double: ");
				d = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Его абсолютное значение: {0}", MyAbs(d));

				Console.Write("Введите число типа long: ");
				l = Convert.ToInt64(Console.ReadLine());
				Console.WriteLine("Его абсолютное значение: {0}", MyAbs(l));

				Console.ReadLine();
			}
			while (true);

		}

		static int MyAbs(int a)
		{
			if (a < 0)
				return -a;
			else return a;
		}

		static long MyAbs(long a)
		{
			if (a < 0)
				return -a;
			else return a;
		}

		static double MyAbs(double a)
		{
			if (a < 0)
				return -a;
			else return a;
		}
	}
}
