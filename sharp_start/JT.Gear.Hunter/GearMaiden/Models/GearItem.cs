using System.ComponentModel.DataAnnotations;

namespace GearMaiden.Models
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
