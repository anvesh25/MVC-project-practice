using System.Collections;
using System.Collections.Generic;
using DrinkApplication.Data.Models;

namespace DrinkApplication.Data.Interfaces
{
    public interface IDrinkRepository
    {
       IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> PreferrencesDrinks { get; set; }
        Drink GetDrinkById(int drinkId);

    }
}