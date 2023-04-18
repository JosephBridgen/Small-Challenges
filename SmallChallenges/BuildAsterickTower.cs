using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallChallenges
{
	public class BuildAsterickTower
	{
		public string[] TowerBuilder(int nFloors)
		{
			List<string> levels = new List<string>();

			int asterickCounter = 1;
			int spaceCounterOneSide = nFloors - 1;

			for (int i = 0; i < nFloors; i++)
			{
				string ast = new string('*', asterickCounter);
				string space = new string(' ', spaceCounterOneSide);

				string level = string.Concat(space, ast, space);

				levels.Add(level);

				asterickCounter += 2;
				spaceCounterOneSide -= 1;
			}
			return levels.ToArray();
		}
	}
}
