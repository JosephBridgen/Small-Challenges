using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class PersistenceNumber
	{
		// Function that takes in a positive parameter num and returns its multiplicative persistence,
		// which is the number of times you must multiply the digits in num until you reach a single digit.
		//39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
		public int Persistence(long n)
		{
			if (n < 10 || n < 0)
			{
				return 0;
			}
			int collector = 1;

			int[] intArray = Array.ConvertAll(n.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));

			foreach (int i in intArray)
			{
				collector = collector * i;
			}

			if (collector < 10)
			{
				return 1;
			}

			else
			{
				int[] ints = Array.ConvertAll(collector.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));
				int counter = 1;
				do
				{
					collector = 1;
					foreach (int i in ints)
					{
						collector = collector * i;
					}
					counter++;
					ints = Array.ConvertAll(collector.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));
				}
				while (collector > 10);
				return counter;
			}



		}
	}
}
