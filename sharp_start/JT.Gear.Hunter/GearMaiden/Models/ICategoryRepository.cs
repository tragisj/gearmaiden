using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearMaiden.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);

    }
}
