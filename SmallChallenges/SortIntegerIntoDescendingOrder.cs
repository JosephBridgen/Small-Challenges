using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class SortIntegerIntoDescendingOrder
	{
		public int DescendingOrder(int num)
		{
			if (num <= 0)
				return 0;

			var charArray = num.ToString().ToCharArray();

			int[] intArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));

			Array.Sort(intArray);
			Array.Reverse(intArray);

			string convString = String.Empty;

			for (int i = 0; i < intArray.Length; i++)
			{
				string individualString = Convert.ToString(intArray[i]);

				convString += individualString;
			}

			return int.Parse(convString);
		}

	}
}
