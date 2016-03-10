using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular01					//   Программа будет проверять корректность ввода логина. Корректным логином будет строка от 2-х до
									//   10-ти символов, содержащая только буквы и цифры, и при этом цифра не может быть первой
{
	class Program
	{
		static void Main(string[] args)
		{
			string str;
			Regex myReg = new Regex(@"^[a-z][a-z0-9]{1,9}$", RegexOptions.IgnoreCase);

			do
			{
				Console.Write("Логин: ");
				str = Console.ReadLine();

				if (myReg.IsMatch(str))
					Console.WriteLine("Логин корректный");
				else Console.WriteLine("Логин не является корректным");

				Console.ReadLine();
			}
			while (true);			//для удобной проверки
		}
	}
}
