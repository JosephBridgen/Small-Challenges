using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class OutlierInIntArray
	{
		public int Find(int[] integers)
		{
			List<int> evenList = new List<int>();
			List<int> oddList = new List<int>();

			foreach (int i in integers)
			{
				if (i % 2 == 0)
				{
					evenList.Add(i);
				}
				else
				{
					oddList.Add(i);
				}
			}

			if (evenList.Count > oddList.Count)
			{
				return oddList.FirstOrDefault();
			}
			else
			{
				return evenList.FirstOrDefault();
			}
		}

	}
}
