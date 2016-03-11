using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverload					//Создайте консольное приложение, в нем опишите структуру для представления точки в
//трехмерной системе координат. Предоставьте возможность сложения/вычитания координат двух точек.
{
	class Program
	{
		struct Point3d
		{
			public double x, y, z;

			Point3d(double x, double y, double z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}

			public override string ToString()
			{
				StringBuilder s = new StringBuilder();
				s.AppendFormat("({0}, {1}, {2}", this.x, this.y, this.z);
				return s.ToString();
			}

			public static Point3d operator +(Point3d a, Point3d b)
			{
				Point3d c = new Point3d(a.x + b.x, a.y + b.y, a.z + b.z);
				return c;
			}

			public static Point3d operator -(Point3d a, Point3d b)
			{
				Point3d c = new Point3d(a.x - b.x, a.y - b.y, a.z - b.z);
				return c;
			}


		}

		static void Main(string[] args)
		{
			Point3d point1, point2, point3;

			Console.WriteLine("Первая точка (A):");
			point1 = ReadPoint();

			Console.Write("Вторая точка (B):");
			point2 = ReadPoint();

			Console.WriteLine("A: {0}", point1);
			Console.WriteLine("B: {0}", point2);
			point3 = point1 + point2;
			Console.WriteLine("A+B: ({0}, {1}, {2})", point3.x, point3.y, point3.z);
			point3 = point1 - point2;
			Console.WriteLine("A-B: ({0}, {1}, {2})", point3.x, point3.y, point3.z);

			Console.ReadLine();
		}

		static Point3d ReadPoint()
		{
			Point3d point;
			Console.Write("x = ");
			point.x = Convert.ToDouble(Console.ReadLine());
			Console.Write("y = ");
			point.y = Convert.ToDouble(Console.ReadLine());
			Console.Write("z = ");
			point.z = Convert.ToDouble(Console.ReadLine());
			return point;
		}
	}

}
