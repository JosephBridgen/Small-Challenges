using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class SumTwoSmallestInts
	{
		public int sumTwoSmallestNumbers(int[] numbers)
		{
			var oderedArray = numbers.OrderBy(x => x).ToArray();

			int first = oderedArray.First();
			int second = oderedArray.ElementAtOrDefault(1);

			return first + second;
		}
	}
}
