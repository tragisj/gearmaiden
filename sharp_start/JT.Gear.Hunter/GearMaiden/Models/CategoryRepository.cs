using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GearMaiden.Models
{
    public class CategoryRepository : ICategoryRepository
    {

        private List<Category> _categories;
        private readonly GearContext _context;

        public CategoryRepository(GearContext appGearContext)
        {
            _context = appGearContext;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories; 
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }
    }
}
