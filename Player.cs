using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneIndividual
{
    class Player
    {
        private string strName;
        private int intWins;
        private int intLosses;
        private int intDraws;
        private int intFastest;

        public string Name
        {
            get
            {
                return strName;
            }
            set
            {
                strName = value;
            }
        }

        public int Wins
        {
            get
            {
                return intWins;
            }
            set
            {
                intWins = Wins;
            }
        }

        public int Losses
        {
            get
            {
                return intLosses;
            }
            set
            {
                intLosses = Losses;
            }
        }

        public int Draws
        {
            get
            {
                return intDraws;
            }
            set
            {
                intDraws = Draws;
            }
        }

        public int Fastest
        {
            get
            {
                return intFastest;
            }
            set
            {
                intFastest = Fastest;
            }
        }

        public Player()
        {
            strName = "Not Given";
            intWins = 0;
            intLosses = 0;
            intDraws = 0;
            intFastest = 10000;

        }

        public Player(string n)
        {
            strName = n;
            intWins = 0;
            intLosses = 0;
            intDraws = 0;
            intFastest = 10000;
        }

        public void UpdateWins()
        {
            intWins++;
        }

        public void UpdateLosses()
        {
            intLosses++;
        }

        public void UpdateDraws()
        {
            intDraws++;
        }

        public void UpdateTime(int time)
        {
            if (time < intFastest)
                intFastest = time;
        }
    }
}
