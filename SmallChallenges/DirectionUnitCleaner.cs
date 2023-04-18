using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class DirectionUnitCleaner
	{
		public string[] directionCleaner(string[] arr)
		{
			bool determiner;

			string[] starter = arr;

			string[] Input = arr;

			do
			{
				starter = Input;

				for (int i = 0; i < Input.Length; i++)
				{
					if (i + 1 == Input.Length)
					{
						return Input;
					}

					if (Input[i].ToLower() == "north" && Input[i + 1].ToLower() == "south")
					{
						Array.Clear(Input, i, 2);
						Input = Input.Where(c => c != null).ToArray();
						i = -1;
					}
					else if (Input[i].ToLower() == "south" && Input[i + 1].ToLower() == "north")
					{
						Array.Clear(Input, i, 2);
						Input = Input.Where(c => c != null).ToArray();
						i = -1;
					}
					else if (Input[i].ToLower() == "east" && Input[i + 1].ToLower() == "west")
					{
						Array.Clear(Input, i, 2);
						Input = Input.Where(c => c != null).ToArray();
						i = -1;
					}
					else if (Input[i].ToLower() == "west" && Input[i + 1].ToLower() == "east")
					{
						Array.Clear(Input, i, 2);
						Input = Input.Where(c => c != null).ToArray();
						i = -1;
					}
				}
				determiner = Input == starter;
			}
			while (determiner == false);

			return Input;
		}
	}
}
