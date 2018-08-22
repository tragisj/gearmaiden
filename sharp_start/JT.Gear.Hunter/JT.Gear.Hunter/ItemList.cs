using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace File.Cutter
{
    public class ItemList
    {
        [Key]
        public int ItemListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Classification { get; set; }
        public DateTime Created { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
