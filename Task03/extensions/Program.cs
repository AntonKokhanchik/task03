using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensions
{
	
	/// <summary>
	/// реализует интерфейс IList, который позволяет получить перечисление
	/// элементов списка через запятую в виде строки.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrI = { 1, 2, 3, 1, 4, 5, 6, 8, 7, 97, 1, 1, -4, 5, -2 };
			List<int> lstI = new List<int>(arrI);

			string [] arrS = { "hi", "привет", "321134", "2+2=4 - верно", "это текстовые строки" };
			List<string> lstS = new List<string>(arrS);

			Console.WriteLine(lstI.GetString());
			Console.WriteLine(lstS.GetString());

			Console.ReadLine();
		}
	}
}
