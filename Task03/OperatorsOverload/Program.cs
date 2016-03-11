using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverload
{
	/// <summary>
	/// Программа выполняет условия задания:
	/// "Создайте консольное приложение, в нем опишите структуру для представления точки в
	/// трехмерной системе координат. Предоставьте возможность сложения/вычитания координат двух точек."
	/// </summary>
	class Program
	{
		/// <summary>
		/// Представляет трёхмерную точку, координаты которой - числа с плавающей запятой
		/// </summary>
		struct Point3d
		{
			public double x, y, z;

			/// <summary>
			/// Инициализирует новый экземпляр структуры <see cref="Point3d"/> с заданными координатами
			/// </summary>
			Point3d(double x, double y, double z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}
			/// <summary>
			/// Преобразует экземпляр структуры <see cref="Point3D"/> в строковое значение
			/// </summary>
			public override string ToString()
			{
				return String.Format("({0}, {1}, {2})", this.x, this.y, this.z);
			}

			/// <summary>
			/// Покоординатно складывает две точки типа <see cref="Point3D"/>
			/// </summary>
			public static Point3d operator +(Point3d a, Point3d b)
			{
				Point3d c = new Point3d(a.x + b.x, a.y + b.y, a.z + b.z);
				return c;
			}

			/// <summary>
			/// Производит покоординатное вычитание точек <see cref="Point3D"/>
			/// </summary>
			public static Point3d operator -(Point3d a, Point3d b)
			{
				Point3d c = new Point3d(a.x - b.x, a.y - b.y, a.z - b.z);
				return c;
			}
		}

		static void Main(string[] args)
		{
			do
			{
				Point3d point1, point2, point3;

				Console.WriteLine("Первая точка (A):");
				point1 = ReadPoint();

				Console.WriteLine("Вторая точка (B):");
				point2 = ReadPoint();

				Console.WriteLine("A: {0}", point1);
				Console.WriteLine("B: {0}", point2);

				point3 = point1 + point2;
				Console.WriteLine("A+B: {0}", point3);

				point3 = point1 - point2;
				Console.WriteLine("A-B: {0}", point3);

				Console.WriteLine("Esc для выхода");
			}
			while (Console.ReadKey(true).Key != ConsoleKey.Escape);
		}

		/// <summary>
		/// Читает из консоли жкземпляр структуры <see cref="Point3d"/>
		/// </summary>
		/// <returns>Возвращает заполненный объект структуры <see cref="Point3d"/></returns>
		static Point3d ReadPoint()
		{
			Point3d point;

			point.x = ReadDouble("x = ");

			point.y = ReadDouble("y = ");

			point.z = ReadDouble("z = ");

			return point;
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
	}

}
