using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class NarcissisticOrArmstrongNumber
	{
		// Armstrong number (or Narcissistic number) is a positive number which is the sum of its own digits,
		// each raised to the power of the number of digits in a given base.
		// e.g. 153           1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153.
		//This method states whether the entered number is a narcissistic number.

		public bool Narcissistic(int value)
		{
			int numLength = value.ToString().Length;

			int[] intArray = Array.ConvertAll(value.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));

			int summed = 0;

			foreach (int i in intArray)
			{
				var powered = (int)Math.Pow(i, numLength);
				summed += powered;
			}
			return summed == value;
		}
	}
}
