using CandyShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace CandyShop.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }

    }
}
