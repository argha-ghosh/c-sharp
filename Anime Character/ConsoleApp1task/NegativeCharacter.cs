using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1task
{
    internal class NegativeCharacter : AnimeCharacter
    {
        private int evilScore;
        private bool finalbattleOutcome;

        public int EvilScore
        {
            get { return evilScore; }
            set { evilScore = value; }
        }
        public bool FinalbattleOutcome
        {
            get { return finalbattleOutcome; }
            set { finalbattleOutcome = value; }
        }
        public NegativeCharacter(int id, string characterName, string animeName, int noofEpisods, int evilScore, bool finalbattleOutcome)
            : base(id, characterName, animeName, noofEpisods)
        {
            EvilScore = evilScore;
            FinalbattleOutcome = finalbattleOutcome;
        }
        public override bool CheckPopularity()
        {
            if (EvilScore > 80 && FinalbattleOutcome == true)
            {
                return true;
            }
            return false;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(" Detals About Negative Charactor =>");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {CharacterName}");
            Console.WriteLine($"Anime: {AnimeName}");
            Console.WriteLine($"Episodes: {NoofEpisods}");
            Console.WriteLine($"Evil Score: {EvilScore}");
            Console.WriteLine($"Final Battle Outcome: {FinalbattleOutcome}");
            Console.WriteLine($"Popularity: {(CheckPopularity() ? "Popular" : "Not Popular")}");
            Console.WriteLine();
        }
    }
     Console.WriteLine("Hello World");
}




