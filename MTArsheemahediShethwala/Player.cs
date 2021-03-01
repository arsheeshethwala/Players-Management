using System;
using System.Collections.Generic;
using System.Text;

namespace MTArsheemahediShethwala
{
    public enum PlayerType { HockeyPlayer, BasketBallPlayer, BaseballPlayer };
    public abstract class Player
    {
        //declaring variables and getter and setters
        private PlayerType playerType;

        public PlayerType PlayerType
        {
            get { return playerType; }
            set { playerType = value; }
        }

        private int _playerId = 7;

        public int PlayerId
        {
            get { return _playerId; }
            set {
                if (_playerId < 0)
                    throw new Exception("Player ID can't be negative");
                _playerId = value; 
            }
        }

        private string _playerName;

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        private string _teamName;

        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value; }
        }

        private int _gamesPlayed;

        public int GamesPlayed
        {
            get { return _gamesPlayed; }
            set {
                if (_gamesPlayed < 0)
                    throw new Exception("Invalid input! Games Played cannot be negative");

                _gamesPlayed = value; }
        }

        //Method to calculate points
        public abstract int Points();
        
        //Non Parameterized constructor
        public Player() { }

        //Parameterized constructor
        public Player(PlayerType playerType, int playerId, string playerName, string teamName, int gamesPlayed) 
        {
            this.PlayerType = playerType;
            this.PlayerId = playerId;
            this.PlayerName = playerName;
            this.TeamName = teamName;
            this.GamesPlayed = gamesPlayed;

        }

        public int generateID()
        {
            return _playerId++; 
        }

        public override string ToString()
        {
            return $"{PlayerType, 5}{PlayerId , 15} {PlayerName , -15}{TeamName, 10}{GamesPlayed,10}";
            return "";
        }
    }
}
