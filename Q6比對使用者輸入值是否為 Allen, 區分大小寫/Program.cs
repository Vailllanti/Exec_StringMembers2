using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6比對使用者輸入值是否為_Allen__區分大小寫
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入正確名稱: ");
			string input = Console.ReadLine();
			string answer = "Allen";

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您未輸入");
				return;
			}

			if (input != answer)
			{
				Console.WriteLine("輸入錯誤");
			}
			else
			{
				Console.WriteLine("輸入正確");
			}
		}
	}
}
