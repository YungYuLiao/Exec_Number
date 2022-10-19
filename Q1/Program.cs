using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//判斷某數值是不是質數
			Console.Write("請輸入一數值: ");
			string input = Console.ReadLine();
			bool isInt = int.TryParse(input, out int value);

			//pre condition
			if (string.IsNullOrWhiteSpace(input))  //輸入空白或沒輸入
			{
				Console.WriteLine("您沒有輸入");
				return;
			}
			if (value == 1)
			{
				Console.WriteLine($"{value}不是質數");
				return;
			}
			if (value < 1) //輸入值不是正整數
			{
				Console.WriteLine("輸入值須為正整數");
				return;
			}
			//平方根為可整除的最大公因數，小於等於開根號的範圍若找到可以整除的數，則不是質數
			for (int i = 2 ; i <= Math.Sqrt(value) ; i++)
			{
				if (value % i == 0) 
				{
					Console.WriteLine($"{value}不是質數");
					return ;
				}
			}
			Console.WriteLine($"{value}是質數");
		}
	}
}
