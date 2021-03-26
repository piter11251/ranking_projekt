using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ranking
{
    public class Score
    {
        public string Team { get; set; }
        public decimal Points { get; set; }
        public override string ToString()
        {
            return Team + Points;
        }
    }
}
