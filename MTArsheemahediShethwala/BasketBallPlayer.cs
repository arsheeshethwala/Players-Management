using System;
using System.Collections.Generic;
using System.Text;

namespace MTArsheemahediShethwala
{
    public class BasketBallPlayer : Player
    {
        //declaring variables and getters and setters
        private int _fieldGoals;

        public int FieldGoals
        {
            get { return _fieldGoals; }
            set {
                if (_fieldGoals < 0)
                    throw new Exception("Invalid input! Field Goals cannot be negative");

                _fieldGoals = value; }
        }

        private int _threePointers;

        public int ThreePointers
        {
            get { return _threePointers; }
            set {
                if (_threePointers < 0)
                    throw new Exception("Invalid input! Three Pointers cannot be negative");

                _threePointers = value; }
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
            TotalPoints = (FieldGoals - ThreePointers) + (2 * ThreePointers);
            return TotalPoints;
        }

        public BasketBallPlayer() { }

        //Parameterized constructor for Basketball player class
        public BasketBallPlayer(PlayerType playerType, int playerId, string playerName, string teamName, int gamesPlayed, int fieldGoals, int threePointers)
            : base(playerType, playerId, playerName, teamName, gamesPlayed)
        {
            this.FieldGoals = fieldGoals;
            this.ThreePointers = threePointers;
            this.TotalPoints = (fieldGoals - threePointers) + (2 * threePointers);
        }

        public override string ToString()
        {
            return base.ToString()+$" {FieldGoals,5} {ThreePointers,5} {TotalPoints,5}";
        }

    }
}
