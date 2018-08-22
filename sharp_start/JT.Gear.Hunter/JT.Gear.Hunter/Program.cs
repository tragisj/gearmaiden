using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using File.Cutter;

namespace File.Cutter
{
    public class Program
    {
        static void Main(string[] args)
        {

            var gd = new Dictionary<string, List<string>>();
            var parse = new Parser();
            var lg = parse.ParserClassificationsList(FileData.Default.Legend);

            foreach (var gt in lg)
            {
                var list = parse.ParserClassifiedGearList(FileData.Default.Gear, gt.Key, true);
                gd.Add(gt.Value, list);
            }

            //Accessing items in dictionary:
            //var kvp = dic.Single(s => s.Key == "id");
            //string item = kvp.Value;

            //or simple:
            //var a = dic["id"];

            var op = gd["personal"].ToList();

            using (var db = new GearContext())
            {
               var gc = new Category();
                gc.Name = "Personal";
                gc.Description =
                    "personal items - EDC pocket knives, bags, tags, license, keys, flashlights, etc. ";
              
                db.Categories.Add(gc);
                var result = db.SaveChanges();

                var ci = db.Categories.First(c => c.Name == "Personal");

                foreach (var i in op)
                {
                    var gi = new GearItem
                    {
                        Name = i,
                        Category = ci
                    };
                    db.GearItems.Add(gi);
                }

                result = db.SaveChanges();
            }

        }
    }
}
