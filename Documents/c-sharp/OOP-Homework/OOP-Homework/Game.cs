using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    class Game
    {
        public Game() {
            AssistantReferees = new List<AssistantReferee>();
            Goals = new List<Goal>();
        }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<AssistantReferee> AssistantReferees { get; set; }
        
        public List<Goal> Goals { get; set; }
        public string GameResult { get; set; }
        public string Winner { get; set; }
    }
}
