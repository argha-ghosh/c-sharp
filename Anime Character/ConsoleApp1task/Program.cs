using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1task
{
    internal class Program
    {
        static void Main()
        {
            AnimeCharacter[] characters = new AnimeCharacter[5];

            characters[0] = new PositiveCharacter(001, "Tom", "Tom & Jerry", 01, 50, true);
            characters[1] = new NegativeCharacter(002, "Black Tom", "Tom & Jerry", 02, 100, true);
            characters[2] = new NegativeCharacter(003, "Blue Tom", "Tom & Jerry", 03, 200, true);
            characters[3] = new NegativeCharacter(004, "Yellow Lion", "Tom & Jerry", 04, 500, true);
            characters[4] = new PositiveCharacter(005, "Jerry", "Tom & Jerry", 05, 10, true);

            foreach (AnimeCharacter character in characters)
            {
                character.ShowInfo();
                character.CheckPopularity();

            }
        }
    }
}
 

