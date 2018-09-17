using System.Collections;
using System.Collections.Generic;
using DrinkApplication.Data.Models;

namespace DrinkApplication.Data.Interfaces
{
    public interface IDrinkRepository
    {
       IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferrencesDrinks { get; }
        Drink GetDrinkById(int drinkId);

    }
}