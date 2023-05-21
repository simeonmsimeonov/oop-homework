using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    class Team
    {
        public Coach Coach { get; set; }
        public List<footballPlayer> FootballPlayers { get; set; }

        public Team()
        {
            FootballPlayers = new List<footballPlayer>();
        }

        public string GetAverageAge()
        {
            int ageSum = 0;
            foreach (var player in FootballPlayers)
            {
                ageSum += player.Age;
            }

            return $"The average age of the team is {((double)ageSum / FootballPlayers.Count).ToString("F0")}";
        }
    }


}
