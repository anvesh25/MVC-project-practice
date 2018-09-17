using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkApplication.Data.Interfaces;
using DrinkApplication.Data.Models;

namespace DrinkApplication.Data.Mock
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Alcoholic", Description = "All alcoholic drinks" },
                    new Category { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                };
            }
        }
    }
}
