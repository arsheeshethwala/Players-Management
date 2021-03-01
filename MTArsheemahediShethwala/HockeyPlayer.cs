using System;
using System.Collections.Generic;
using System.Text;

namespace MTArsheemahediShethwala
{
    public class HockeyPlayer : Player
    {
        //declaring variables and getters and setters
        private int _assists;

        public int Assists
        {
            get { return _assists; }
            set
            {
                if (_assists < 0)
                    throw new Exception("Invalid input! Assists cant be negative");

                _assists = value;
            }
        }

        private int _goals;

        public int Goals
        {
            get { return _goals; }
            set
            {
                if (_goals < 0)
                    throw new Exception("Invalid input! Goals cannot be negative");
                _goals = value;
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
            TotalPoints = Assists + (2 * Goals);
            return TotalPoints;
        }

        public HockeyPlayer()
        {

        }

        //Parameterized constructor for hockey player class
        public HockeyPlayer(PlayerType playerType, int playerId, string playerName, string teamName, int gamesPlayed, int assists, int goals) 
            : base(playerType, playerId, playerName, teamName, gamesPlayed) 
        {
            this.Assists = assists;
            this.Goals = goals;
            this.TotalPoints = assists + (2*goals);
        }

        public override string ToString()
        {
            return base.ToString()+$" {Assists,5} {Goals,5} {TotalPoints,5}";
        }


    }
}