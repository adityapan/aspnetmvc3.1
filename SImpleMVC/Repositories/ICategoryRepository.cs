using System;
using System.Collections.Generic;
using SImpleMVC.Models;

namespace SImpleMVC.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
