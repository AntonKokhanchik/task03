using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
	/// <summary>
	/// Программа выполняет условия задания:
	/// Создайте консольное приложение для вывода абсолютного значения вводимого с клавиатуры числа. 
	/// Реализуйте несколько версий функции получения абсолютного значения для разных типов: int, double, long.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int i;
			long l;
			double d;

			do
			{
				i = ReadInt("Введите число типа int: ");
				Console.WriteLine("Его абсолютное значение: {0}", MyAbs(i));

				d = ReadDouble("Введите число типа double: ");
				Console.WriteLine("Его абсолютное значение: {0}", MyAbs(d));

				l = ReadLong("Введите число типа long: ");
				Console.WriteLine("Его абсолютное значение: {0}", MyAbs(l));

				Console.WriteLine("Esc для выхода");
			}
			while (Console.ReadKey(true).Key != ConsoleKey.Escape);

		}

		/// <summary>
		/// Безопасно читает из консоли число типа <see cref="int"/>
		/// </summary>
		/// <param name="text">Текст запроса на ввод для вывода на консоль</param>
		/// <returns>Возвращает число типа <see cref="int"/></returns>
		static int ReadInt(string text)
		{
			int tmp;
			do
			{
				Console.Write(text);
				if (int.TryParse(Console.ReadLine(), out tmp))
				{
					return tmp;
				}
				else
					Console.WriteLine("Ошибка ввода");
			}
			while (true);
		}

		/// <summary>
		/// Безопасно читает из консоли число типа <see cref="long"/>
		/// </summary>
		/// <param name="text">Текст запроса на ввод для вывода на консоль</param>
		/// <returns>Возвращает число типа <see cref="long"/></returns>
		static long ReadLong(string text)
		{
			long tmp;
			do
			{
				Console.Write(text);
				if (long.TryParse(Console.ReadLine(), out tmp))
				{
					return tmp;
				}
				else
					Console.WriteLine("Ошибка ввода");
			}
			while (true);
		}

		/// <summary>
		/// Безопасно читает из консоли число типа <see cref="double"/>
		/// </summary>
		/// <param name="text">Текст запроса на ввод для вывода на консоль</param>
		/// <returns>Возвращает число типа <see cref="double"/></returns>
		static double ReadDouble(string text)
		{
			double tmp;
			do
			{
				Console.Write(text);
				if (double.TryParse(Console.ReadLine(), out tmp))
				{
					return tmp;
				}
				else
					Console.WriteLine("Ошибка ввода");
			}
			while (true);
		}

		/// <summary>
		/// Находит модуль числа типа <see cref="int"/></returns>
		/// </summary>
		static int MyAbs(int a)
		{
			if (a < 0)
				return -a;
			else
				return a;
		}

		/// <summary>
		/// Находит модуль числа типа <see cref="long"/></returns>
		/// </summary>
		static long MyAbs(long a)
		{
			if (a < 0)
				return -a;
			else
				return a;
		}

		/// <summary>
		/// Находит модуль числа типа <see cref="double"/></returns>
		/// </summary>
		static double MyAbs(double a)
		{
			if (a < 0)
				return -a;
			else
				return a;
		}
	}
}
