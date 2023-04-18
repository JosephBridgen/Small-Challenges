using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class LongestCountOfRepeating1s
	{
		public int LongestNumberOfRepeating(string sequence)
		{
			int currentCount = 0;
			int maxCount = 0;
			List<int> numbs = new List<int>();


			for (int i = 0; i < sequence.Length; i++)
			{
				numbs.Add(int.Parse(sequence[i].ToString()));
			}

			foreach (int i in numbs)
			{
				if (i != 1)
				{
					currentCount = 0;
				}
				else
				{
					currentCount++;
				}

				if (currentCount > maxCount)
				{
					maxCount = currentCount;
				}
			}
			return maxCount;
		}
	}
}
