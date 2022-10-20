using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Q3將字串_aLLeN_kUO_轉換成_Allen_Kuo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string name = "aLLeN kUO";
			//string toLowerName = name.ToLower();
			//string firstNameUpper = toLowerName.Replace("a","A");
			//string lastNameUpper = firstNameUpper.Replace("k","K");

			//Console.WriteLine(lastNameUpper);
			
			//公式化寫法
			Console.Write("請輸入英文全名: ");
			string input = Console.ReadLine();
			string[] words = input.ToLower().Split(' ');

			for (int i = 0; i < words.Length; i++)
			{
				//          取第一個字母轉成大寫                   剩下的字母
				words[i] = words[i].Substring(0,1).ToUpper() + words[i].Substring(1);
			}
			//執行完迴圈 Array變成 "Allen" "Kuo"

			string result = string.Join(" ", words);// 將Array合併為一個字串，並以空白隔開
			Console.WriteLine(result);
		}
	}
}
