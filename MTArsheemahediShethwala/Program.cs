using System;
using System.Collections.Generic;
using System.Linq;
/*
 This is the main method of the application which has all the implementation
 */
namespace MTArsheemahediShethwala
{
    public class Program
    {
        //Declaring the list of the player type
        public static List<Player> lstPlayers = new List<Player>();
        public static void Start()//Main(string[] args)
        {
            //Creating the new objects of the players and populating it with predefined data

            lstPlayers.Add(new HockeyPlayer(PlayerType.HockeyPlayer, 1, "Mitchell Marner", "Maple Leafs", 9, 5, 8));
            lstPlayers.Add(new HockeyPlayer(PlayerType.HockeyPlayer, 2, "MS Dhoni", "CSK", 10, 5, 8));
            lstPlayers.Add(new HockeyPlayer(PlayerType.HockeyPlayer, 3, "Sachin", "Mumbai", 15, 4, 10));
            lstPlayers.Add(new HockeyPlayer(PlayerType.HockeyPlayer, 4, "Rohit Sharma", "Mumbai", 10, 15, 18));
            lstPlayers.Add(new HockeyPlayer(PlayerType.HockeyPlayer, 5, "C Pujara", "CSK", 9, 5, 9));
            lstPlayers.Add(new BasketBallPlayer(PlayerType.BasketBallPlayer, 1, "Kyle Lowry", "Raptors", 5, 18, 4));
            lstPlayers.Add(new BasketBallPlayer(PlayerType.BasketBallPlayer, 2, "Andrew Symonds", "CSK", 5, 18, 4));
            lstPlayers.Add(new BasketBallPlayer(PlayerType.BasketBallPlayer, 3, "Chris Morris", "Mumbai", 5, 18, 4));
            lstPlayers.Add(new BasketBallPlayer(PlayerType.BasketBallPlayer, 4, "Virat Kohli", "Mumbai", 5, 18, 4));
            lstPlayers.Add(new BasketBallPlayer(PlayerType.BasketBallPlayer, 5, "Ben Stokes", "Heat", 8, 16, 2));
            lstPlayers.Add(new BaseballPlayer(PlayerType.BaseballPlayer, 1, "Joe Root", "Blue Jays", 9, 4, 1));
            lstPlayers.Add(new BaseballPlayer(PlayerType.BaseballPlayer, 2, "Moeen Ali", "Blue Jays", 9, 4, 1));
            lstPlayers.Add(new BaseballPlayer(PlayerType.BaseballPlayer, 3, "G Gambhir", "Blue Jays", 9, 4, 1));
            lstPlayers.Add(new BaseballPlayer(PlayerType.BaseballPlayer, 4, "Andre Russell", "Blue Jays", 9, 4, 1));
            lstPlayers.Add(new BaseballPlayer(PlayerType.BaseballPlayer, 5, "Chris Gayle", "Yankees", 16, 7, 4));

        } // End of the main method
    } // end of the class
}// End of the program