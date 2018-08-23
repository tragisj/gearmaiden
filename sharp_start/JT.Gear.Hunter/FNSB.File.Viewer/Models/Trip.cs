using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FNSB.File.Viewer.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TripDate { get; set; }
        public virtual List<ItemList> Lists { get; set; }

    }
}
