using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class FirstNonRepeatingLetter
	{
		public string FirstNonRepeating(string s)
		{
			var charArray = s.ToCharArray();
			var testCharArray = s.ToLower().ToCharArray();
			for (int i = 0; i < charArray.Length; i++)
			{
				var count = testCharArray.Count(c => c == testCharArray[i]);
				if (count == 1)
				{
					return charArray[i].ToString();
				}
			}
			return "";
		}
	}
}
