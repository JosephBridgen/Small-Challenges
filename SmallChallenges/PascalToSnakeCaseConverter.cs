using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class PascalToSnakeCaseConverter
	{
		// Function that takes a PascalCase string and returns the string in snake_case notation. Lowercase characters can be numbers.
		// If the method gets a number as input, it should return a string.
		public string ToUnderscore(int str)
		{
			return str.ToString();
		}

		public string ToUnderscore(string str)
		{
			var chars = str.ToCharArray();

			chars[0] = char.ToLower(chars[0]);

			List<string> result = new List<string>();

			foreach (char c in chars)
			{
				if (c.ToString() == c.ToString().ToUpper() && Char.IsLetter(c))
				{
					result.Add($"_{c.ToString().ToLower()}");
				}
				else
				{
					result.Add(c.ToString());
				}
			}
			return String.Join("", result);
		}
	}
}
