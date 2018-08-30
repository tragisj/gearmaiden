using System;
using System.ComponentModel.DataAnnotations;

namespace GearMaiden.Models
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
