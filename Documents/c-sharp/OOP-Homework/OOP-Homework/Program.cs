using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I added test code where I instantiate the players, teams and game and display the result

            // Team 1
            Goalkeeper t1GK = new Goalkeeper("Goalkeeper", 1, 23, 1.88);
            Defender t1Defence = new Defender("Defender1", 2, 25, 1.99); 
            Defender t1Defence2 = new Defender("Defender2", 3, 43, 1.78); 
            Defender t1Defence3 = new Defender("Defender3", 4, 38, 1.78); 
            Midfield t1Mid1 = new Midfield("Midfield1", 5, 21, 1.78); 
            Midfield t1Mid2 = new Midfield("Midfield2", 6, 31, 1.78); 
            Midfield t1Mid3 = new Midfield("Midfield3", 7, 35, 1.78); 
            Striker t1Strike1 = new Striker("Striker1", 8, 45, 1.78); 
            Striker t1Strike2 = new Striker("Striker2", 9, 33, 1.78); 
            Striker t1Strike3 = new Striker("Striker3", 10, 32, 1.78); 
            Striker t1Strike4 = new Striker("Striker4", 11, 34, 1.78);
            Coach t1Coach = new Coach("Coach1", 43);

            Team team1 = new Team();
            team1.FootballPlayers.Add(t1GK); 
            team1.FootballPlayers.Add(t1Defence); 
            team1.FootballPlayers.Add(t1Defence2); 
            team1.FootballPlayers.Add(t1Defence3); 
            team1.FootballPlayers.Add(t1Mid1); 
            team1.FootballPlayers.Add(t1Mid2); 
            team1.FootballPlayers.Add(t1Mid3); 
            team1.FootballPlayers.Add(t1Strike1); 
            team1.FootballPlayers.Add(t1Strike2); 
            team1.FootballPlayers.Add(t1Strike3); 
            team1.FootballPlayers.Add(t1Strike4);
            team1.Coach = t1Coach;

            Console.WriteLine(team1.GetAverageAge());

            // Team 2
            Goalkeeper t2GK = new Goalkeeper("Goalkeeper", 1, 23, 1.88);
            Defender t2Defence = new Defender("Defender1", 2, 25, 1.99);
            Defender t2Defence2 = new Defender("Defender2", 3, 43, 1.78);
            Defender t2Defence3 = new Defender("Defender3", 4, 38, 1.78);
            Midfield t2Mid1 = new Midfield("Midfield1", 5, 21, 1.78);
            Midfield t2Mid2 = new Midfield("Midfield2", 6, 31, 1.78);
            Midfield t2Mid3 = new Midfield("Midfield3", 7, 35, 1.78);
            Striker t2Strike1 = new Striker("Striker1", 8, 45, 1.78);
            Striker t2Strike2 = new Striker("Striker2", 9, 33, 1.78);
            Striker t2Strike3 = new Striker("Striker3", 10, 32, 1.78);
            Striker t2Strike4 = new Striker("Striker4", 11, 34, 1.78);
            Coach t2Coach = new Coach("Coach1", 43);

            Team team2 = new Team();
            team2.FootballPlayers.Add(t2GK);
            team2.FootballPlayers.Add(t2Defence);
            team2.FootballPlayers.Add(t2Defence2);
            team2.FootballPlayers.Add(t2Defence3);
            team2.FootballPlayers.Add(t2Mid1);
            team2.FootballPlayers.Add(t2Mid2);
            team2.FootballPlayers.Add(t2Mid3);
            team2.FootballPlayers.Add(t2Strike1);
            team2.FootballPlayers.Add(t2Strike2);
            team2.FootballPlayers.Add(t2Strike3);
            team2.FootballPlayers.Add(t2Strike4);
            team2.Coach = t2Coach;

            Referee referee = new Referee("Referee", 38);
            AssistantReferee assistantReferee1 = new AssistantReferee("Ässistant Referee1", 28);
            AssistantReferee assistantReferee2  = new AssistantReferee("Ässistant Referee2", 30);


            Game game1 = new Game();
            game1.Team1 = team1;
            game1.Team2 = team2;
            game1.Referee = referee;
            game1.AssistantReferees.Add(assistantReferee1);
            game1.AssistantReferees.Add(assistantReferee2);

            Goal goal1 = new Goal(12.32, t1Strike1);
            Goal goal2 = new Goal(23.52, t2Strike1);
            Goal goal3 = new Goal(50.23, t1Strike3);

            game1.Goals.Add(goal1);
            game1.Goals.Add(goal2);
            game1.Goals.Add(goal3);

            game1.GameResult = "2:0";
            game1.Winner = "Team 1";

            Console.WriteLine($"The result is {game1.GameResult}\nThe Winner is {game1.Winner}");

        }
    }
}
