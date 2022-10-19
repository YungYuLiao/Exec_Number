using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//找出數值區間內的所有質數
			Console.Write("請輸入區間起始值: ");
			string start = Console.ReadLine();	
			Console.Write("請輸入區間結束值: ");
			string end = Console.ReadLine();
			//判斷是否為數值
			bool value1= int.TryParse(start, out int value_start);
			bool value2= int.TryParse(end, out int value_end);	

			//pre condition
			if (string.IsNullOrWhiteSpace(start) || string.IsNullOrWhiteSpace(end))
			{
				Console.WriteLine("您沒輸入完整區間");
				return ;
			}
			if(value_start < 0 || value_end < 0) 
			{
				Console.WriteLine("任一輸入值皆須為正整數");
				return ;
			}

			//區間內的數一一判斷是否為質數
			for (int i = value_start; i < value_end; i++)
			{
				bool isFind = false; //如果是質數就是false
				if (i==1)
				{
					continue; //1不是質數
				}
				for (int k = 2; k <= Math.Sqrt(i) ; k++)
				{
					if (i % k == 0) 
					{
						isFind = true; //碰到不是質數就回傳true
						break;
					} 
				}
				if (isFind == false) //是質數的就列出來
				{
					Console.WriteLine(i); 
				}
			}
			 

		}
	}
}
