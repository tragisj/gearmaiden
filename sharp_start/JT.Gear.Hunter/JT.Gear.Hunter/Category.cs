using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Cutter
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set;  }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
