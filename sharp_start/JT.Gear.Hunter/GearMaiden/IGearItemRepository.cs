using System.Collections;
using System.Collections.Generic;
using GearMaiden.Models;

namespace GearMaiden
{
    public interface IGearItemRepository
    {
        IEnumerable<GearItem> GetAllGearItems();
        IEnumerable<GearItem> GearItemsByCategoryId(int id);
    }
}