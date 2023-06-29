using PizzaCase.Models;

namespace PizzaCase.Data;

// visitor pattern
public static class IngredientLibrary
{
    public static List<Ingredient> GatherIngredients(PizzaName name)
    {
        List<Ingredient> ingredients = new List<Ingredient>();

        switch (name) {
            case PizzaName.Prosciutto:
                ingredients.Add(new Topping(ToppingNames.Ham, 1));
                break;
            case PizzaName.Salame:
                ingredients.Add(new Topping(ToppingNames.Salami, 1));
                break;
            case PizzaName.Hawaii:
                ingredients.Add(new Topping(ToppingNames.Ananas, 1));
                goto case PizzaName.Prosciutto;
            case PizzaName.Vulcano:
                ingredients.Add(new Topping(ToppingNames.Champignons, 1));
                goto case PizzaName.Prosciutto;
            case PizzaName.Tonno:
                ingredients.Add(new Topping(ToppingNames.Tonijn, 1));
                break;
        }

        return ingredients;
    }
}