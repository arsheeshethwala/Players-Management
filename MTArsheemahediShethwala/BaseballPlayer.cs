using System;
using System.Collections.Generic;
using System.Text;

namespace MTArsheemahediShethwala
{
    public class BaseballPlayer : Player
    {
        //declaring variables and getters and setters
        private int _runs;

        public int Runs
        {
            get { return _runs; }
            set
            {
                if (_runs < 0)
                    throw new Exception("Invalid input! Runs cannot be negative");

                _runs = value;
            }
        }

        private int _homeRuns;

        public int HomeRuns
        {
            get { return _homeRuns; }
            set
            {
                if (_homeRuns < 0)
                    throw new Exception("Invalid input! Home Runs cannot be negative");

                _homeRuns = value;
            }
        }

        private int _totalPoints;
        public int TotalPoints
        {
            get { return _totalPoints; }
            set { _totalPoints = value; }
        }


        //calculation points method which overridden from player class
        public override int Points()
        {
            int TotalPoints = (Runs - HomeRuns) + (2 * HomeRuns);
            return TotalPoints;
        }

        //Non Parameterized Constructor
        public BaseballPlayer() { }

        //Parameterized constructor for Basketball player class
        public BaseballPlayer(PlayerType playerType, int playerId, string playerName, string teamName, int gamesPlayed, int runs, int homeRuns)
            : base(playerType, playerId, playerName, teamName, gamesPlayed)
        {
            this.Runs = runs;
            this.HomeRuns = homeRuns;
            this.TotalPoints = (runs - homeRuns) + (2 * homeRuns);
        }

        public override string ToString()
        {
            return base.ToString()+$" {Runs,5} {HomeRuns,5} {TotalPoints,5}";
        }
    }
}
