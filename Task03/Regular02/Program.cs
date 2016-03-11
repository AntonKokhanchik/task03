using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular02						//	программа будет искать в исходном тексте слово «металл» и его однокоренные слова, и выводить их на консоль.
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			Regex myReg = new Regex(@"[а-я-]*металл[а-я-]*", RegexOptions.IgnoreCase);
			//Console.WriteLine("Введите строку:");						//это тоже можно, но Ctrl+V в консоль не сделать, так что для проверки строка
			//input = Console.ReadLine();
			input = "металл, @металлический*, (металлы), \\неметаллы/, метачисло, как дела, сметана, талый лёд, методика, металл-оборотень, МеТАлл, НеМеТаЛЛ, МЕТАЛЛ, метАЛЛокоНструкция, {неметаллический}";

			foreach (Match reg in myReg.Matches(input))
				Console.WriteLine(reg.Value);

			Console.ReadLine();
		}
	}
}
