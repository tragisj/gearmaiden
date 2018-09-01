using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GearMaiden.Models;

namespace GearMaiden.ViewModels
{
    public class GearItemViewModel
    {
        public List<GearItem> GearItems { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

    }
}
