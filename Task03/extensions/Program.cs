using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensions
{
	static class MyExtensions
	{
		public static string GetString(this List<int> list)						
		{
			StringBuilder result = new StringBuilder();
			foreach (int elem in list)
				result = result.AppendFormat("{0}, ", elem);
			return result.ToString();
		}
	}

	class Program					//	реализует интерфейс IList, который позволяет получить перечисление
									//	элементов списка через запятую в виде строки.
									//	не доделано
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 1, 4, 5, 6, 8, 7, 97, 1, 1, -4, 5, -2 };
			List<int> lst = new List<int>(arr);
			string s = lst.GetString();

			Console.WriteLine(s);

			Console.ReadLine();
		}
	}
}
