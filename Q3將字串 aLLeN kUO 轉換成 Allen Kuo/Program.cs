using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3將字串_aLLeN_kUO_轉換成_Allen_Kuo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "aLLeN kUO";
			string toLowerName = name.ToLower();
			string firstNameUpper = toLowerName.Replace("a","A");
			string lastNameUpper = firstNameUpper.Replace("k","K");

			Console.WriteLine(lastNameUpper);
		}
	}
}
