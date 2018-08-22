using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace File.Cutter
{
    public class GearItem
    {   
        [Key]
        public int GearItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
        public virtual Category Category { get; set; }
    }
}
