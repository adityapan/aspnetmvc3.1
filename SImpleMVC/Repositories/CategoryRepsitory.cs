using System;
using System.Collections.Generic;
using SImpleMVC.Models;

namespace SImpleMVC.Repositories
{
    public class MockedCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            return new List<Category> {
                new Category { Id=1, Name="Horror", Description="Don't Read at Night"},
                new Category { Id=2, Name="Romance", Description="Understanding Beauty of Life"},
            };
        }
    }
}
