using System.ComponentModel.DataAnnotations;

namespace GearMaiden.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set;  }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
