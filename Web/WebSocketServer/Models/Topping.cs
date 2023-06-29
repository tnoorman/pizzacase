using PizzaCase.Data;

namespace PizzaCase.Models;

public class Topping : Ingredient
{
    public Topping(ToppingNames name, int amount) : base(name.ToString(), amount) { }
}