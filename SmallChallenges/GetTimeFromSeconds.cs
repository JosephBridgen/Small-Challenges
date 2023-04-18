using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class GetTimeFromSeconds
	{
		public string GetReadableTime(int seconds)
		{
			int iSecs = seconds % 60;
			int iMins = (seconds % 3600) / 60;
			int iHours = seconds / 3600;

			if (iHours > 0)
			{
				return $"{String.Format("{0:00}", iHours)}:{String.Format("{0:00}", iMins)}:{String.Format("{0:00}", iSecs)}";
			}
			else
			{
				iMins = seconds / 60;
				return $"00:{String.Format("{0:00}", iMins)}:{String.Format("{0:00}", iSecs)}";
			}

		}
	}
}
