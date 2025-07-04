using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1task
{
    internal class PositiveCharacter : AnimeCharacter
    {
        private int powerLevel;
        private bool isMainCharacter;
        public int PowerLevel
        {
            get { return powerLevel; }
            set { powerLevel = value; }
        }
        public bool IsMainCharacter
        {
            get { return isMainCharacter; }
            set { isMainCharacter = value; }
        }

        public PositiveCharacter(int id, string characterName, string animeName, int noofEpisods, int powerlevel, bool ismainCharacter)
            : base (id, characterName, animeName, noofEpisods) 
        {
            PowerLevel = powerlevel;
            IsMainCharacter = ismainCharacter; 
        }
        public override bool CheckPopularity()
        {
            return IsMainCharacter == true && PowerLevel > 9000;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("------------ Positive Character ----------");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {CharacterName}");
            Console.WriteLine($"Anime: {AnimeName}");
            Console.WriteLine($"Episodes: {NoofEpisods}");
            Console.WriteLine($"Evil Score: {powerLevel}");
            Console.WriteLine($"Final Battle Outcome: {isMainCharacter}");
            Console.WriteLine($"Popularity: {(CheckPopularity() ? "Popular" : "Not Popular")}");
            Console.WriteLine();
        }
    }
}
