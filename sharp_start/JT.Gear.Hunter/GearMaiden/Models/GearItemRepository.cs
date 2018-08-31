using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearMaiden.Models
{
    public class GearItemRepository : IGearItemRepository
    {

        private List<GearItem> _gear;
        private readonly GearContext _gearContext;

        public GearItemRepository(GearContext appGearContext)
        {
            _gearContext = appGearContext;
        }

        public IEnumerable<GearItem> GetAllGearItems()
        {
            return _gearContext.GearItems;
        }

        public IEnumerable<GearItem> GearItemsByCategoryId(int id)
        {
            return _gearContext.GearItems.Where(c => c.Category.CategoryId == id);
        }
    }
}
