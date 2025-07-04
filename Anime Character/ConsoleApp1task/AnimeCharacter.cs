using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1task
{
    abstract class AnimeCharacter
    {
        private int id;
        private string characterName;
        private string animeName;
        private int noofEpisods;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

        public string AnimeName
        {
            get { return animeName; }
            set { animeName = value; }
        }
        public int NoofEpisods
        {
            get { return noofEpisods; }
            set { noofEpisods = value; }
        }
        public AnimeCharacter(int id, string characterName, string animeName, int noofEpisods)
        {
            Id = id;
            CharacterName = characterName;
            AnimeName = animeName;
            NoofEpisods = noofEpisods;
        }

        public abstract void ShowInfo();
        public abstract bool CheckPopularity();


    }
}

