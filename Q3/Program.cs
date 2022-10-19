using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*有一個數值,是四位數
			左邊二位的數字相同
			右邊二位的數字相同
            這個四位數值, 剛好也是某整數的平方
            請問這個四位數值是什麼?*/

			for (int i = 32; i <= 99 ; i++) //32*32=1024 99*99=9801 (四位數字)
			{
				double value = Math.Pow(i, 2); //平方
				string  number = value.ToString(); //轉字串

				//字串截取前兩個數和兩個數
				if (number.Substring(0,1)==number.Substring(1,1) && number.Substring(2,1)==number.Substring(3)) 
				{
					Console.WriteLine(number);
				}

			}

		}
	}
}
