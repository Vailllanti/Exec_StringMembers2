using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1將abc左右的空白刪除
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var raw = "   abc   ";
			var afterTrim = raw.Trim();

			Console.WriteLine(afterTrim);
		}
	}
}
