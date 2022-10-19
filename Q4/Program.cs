using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//百元買百雞
			//想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
			//字彙表:公雞(Cock), 母雞(Hen), 小雞(Chicken)
			/* 5x+3y+z = 100 ; x+y+3z = 100 ====> y = 25 - 7x /4 ; xyz都要是正整數  
			  故設 公雞 = 4k, 母雞 = 25 - 7k, 小雞 = 75 + 3k*/

			Console.WriteLine("共有4種解法: ");
			for (int k = 0; k < 4 ; k++) //因y=25-7k y要是正整數故k不能大於4
			{
				string cock = Convert.ToString(4 * k);
				string hen = Convert.ToString(25 - 7 * k);
				string chicken = Convert.ToString(75 + 3 * k);
				Console.WriteLine($"共有公雞{cock}隻，母雞{hen}隻，小雞{chicken}隻");
			}

			



		}
	}
}
