using System;
using System.ComponentModel.DataAnnotations;

namespace FNSB.File.Viewer.Models
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
