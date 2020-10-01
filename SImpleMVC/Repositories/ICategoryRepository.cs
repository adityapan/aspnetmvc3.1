using System;
using System.Collections.Generic;
using SimpleMVC.Models;

namespace SimpleMVC.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
