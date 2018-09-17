using System.Collections;
using System.Collections.Generic;
using DrinkApplication.Data.Models;

namespace DrinkApplication.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; set; }
    }
}