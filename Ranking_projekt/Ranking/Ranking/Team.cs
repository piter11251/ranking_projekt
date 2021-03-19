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
                    Console.Write("Wpisz ilosc punktow: ");
                    teamPoints = int.Parse(Console.ReadLine());
                    File.AppendAllText("TeamsUEFA.txt", teamName + " ");
                    File.AppendAllText("TeamsUEFA.txt", teamPoints.ToString());
                }
        }

       /* void WritingActualMatchesToUefaRanking() //Przyszla funkcja do wpisywania aktualnych spotkań zespołów 
        {

        }*/
    }
}
