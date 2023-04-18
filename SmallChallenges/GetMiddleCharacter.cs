using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class GetMiddleCharacter
	{
		public string GetMiddleChar(string s)
		{
			return s.Length % 2 == 0 ? s.Substring((s.Length / 2) - 1, 2) : s.Substring((s.Length / 2), 1);
		}
	}
}
