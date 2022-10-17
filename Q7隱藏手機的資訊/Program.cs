using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7隱藏手機的資訊
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string phoneNumber = "0935123446";
			
			string encryptedPhoneNumber = phoneNumber.Substring(0,4) + new string('*',4) + phoneNumber.Substring(8,2);

			Console.WriteLine(encryptedPhoneNumber);
		}
	}
}
