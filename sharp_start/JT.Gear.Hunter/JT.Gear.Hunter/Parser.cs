using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace  File.Cutter
{
    public class Parser
    {


        public Dictionary<string,string> ParserClassificationsList(string legend)
        {
            Dictionary<string, string> legendD = new Dictionary<string,string>();
            StreamReader sr = new StreamReader(legend);

            string line;

            while ((line = sr.ReadLine()) != null)
            {

                string[] gp = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                 legendD.Add(gp[0],gp[1]);
               
            }

            return legendD;
        }






        public List<string> ParserClassifiedGearList(string gearlist, string kt, bool kr)
        {
            List<string> gear = new List<string>();
            StreamReader sr = new StreamReader(gearlist);

            string line;

            while ((line = sr.ReadLine()) != null)
            {

                string[] gp = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);

                var ktype = gp[1];
                var kreq = gp[2];

                bool.TryParse(kreq, out var ritem);

                if (ktype == kt && ritem == kr)
                {
                    gear.Add(gp[0]);
                }
            }

            return gear;
        }
    }
}
