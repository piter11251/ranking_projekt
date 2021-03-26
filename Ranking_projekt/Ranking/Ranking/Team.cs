using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ranking
{
    public class Team
    {
        public string teamName;
        public int teamPoints;
        List<string> listOfTeams = new List<string>();

        public void RewritingFromOfficialUefaRankingToOurRanking() //Tymczasowa funkcja do przepisania rankingu UEFA
        {
            while (true)
            {
               Console.WriteLine("Wcisnij dowolny przycisk aby kontynuowac, jesli chcesz zakonczyc wcisnij ESC ...");
               ConsoleKeyInfo key = Console.ReadKey();
               if (key.Key == ConsoleKey.Escape)
                   break;
               Console.Clear();
               Console.Write("Wpisz nazwe teamu: ");
               teamName = Console.ReadLine();
                if (!CheckUniquenessTeams(teamName))
                {
                    Console.Write("Wpisz ilosc punktow: ");
                    teamPoints = int.Parse(Console.ReadLine());
                    AddTeamToList();
                }
                else
                {
                    Console.WriteLine("Taki team juz istnieje, proszę podać inną nazwę");
                    Console.ReadKey();
                    Console.Clear();
                }
             }
        }
        public void AddTeamToList()
        {
            File.AppendAllText("TeamsUEFA.txt", teamName + " ");
            File.AppendAllText("TeamsUEFA.txt", teamPoints.ToString() + Environment.NewLine);
        }
        public bool CheckUniquenessTeams(string teamFromConsole)
        {
           // List<string> checkTeams = new List<string>();
            var lines = File.ReadAllLines("TeamsUEFA.txt");
            foreach (var line in lines)
            {
                string[] fields = line.Split(' ');
                string points = fields[fields.Length - 1];
                string checkTeams = line.Substring(0, line.Length - points.Length);
                listOfTeams.Add(checkTeams);
            }
            for(var i=0;i<listOfTeams.Count-1;i++)
            {
                if (listOfTeams[i] == teamFromConsole)
                    return false;
            }
            return true;
        }
       /* void WritingActualMatchesToUefaRanking() //Przyszla funkcja do wpisywania aktualnych spotkań zespołów 
        {

        }*/
    }
}
