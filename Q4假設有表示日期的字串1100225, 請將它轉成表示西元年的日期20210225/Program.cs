using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4假設有表示日期的字串1100225__請將它轉成表示西元年的日期20210225
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string rocEra = "1100225";
			string years = rocEra.Substring(0, 3);
			string months = rocEra.Substring(3, 2);
			string days = rocEra.Substring(5, 2);
			
			int rocYearsNumber = Convert.ToInt32(years);
			const int yearsDifference = 1911;
			int adYearsNumber = rocYearsNumber + yearsDifference;
			
			string adDate = ($"{adYearsNumber}/{months}/{days}");

			Console.WriteLine(adDate);

		}
	}
}
