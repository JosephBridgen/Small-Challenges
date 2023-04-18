using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class StringReverser
	{
		public string ReverseWords(string str)
		{
			var wordCollection = str.Split(' ');
			string returner = string.Empty;
			string final = string.Empty;
			foreach (var word in wordCollection)
			{
				foreach (char c in word)
				{
					returner = c + returner;
				}
				final += returner + " ";
				returner = string.Empty;
			}
			return final.Trim();
		}
	}
}
