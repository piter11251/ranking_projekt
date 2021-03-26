using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ranking
{
    public class DisplayScore
    {
        public void Display()
        {
            List<Score> listOfTeams = new List<Score>();
            var lines = File.ReadAllLines("TeamsUEFA.txt");
            foreach(var line in lines)
            {
                Score score = new Score();
                decimal value = 0;
                string[] fields = line.Split(' ');
                string points = fields[fields.Length - 1]; // last value is points

                if(decimal.TryParse(points, out value))
                {
                    score.Points = value;
                }
                score.Team = line.Substring(0, line.Length - points.Length);
                listOfTeams.Add(score);
            }
            Console.WriteLine("{0,-20} {1,5}\n", "Teams", "Points");
            foreach (Score sth in listOfTeams.OrderByDescending(x => x.Points))
            {
                Console.WriteLine("{0,-20} {1,5:N1}", sth.Team, sth.Points);
            }
        }
    }
}
