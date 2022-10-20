using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7計算兩數之和_並只呈現小數二位數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double[] number = { 6.2, 63.3 };
			double sum = number[0] + number[1];
			
			Console.WriteLine(sum.ToString("0.00"));
		}
	}
}
