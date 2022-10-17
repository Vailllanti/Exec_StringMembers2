using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2將字串_Allen_Kuo_轉成大寫_ALLEN_KUO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var name = "Allen Kuo";
			var upperName = name.ToUpper();

			Console.WriteLine(upperName);
		}
	}
}
