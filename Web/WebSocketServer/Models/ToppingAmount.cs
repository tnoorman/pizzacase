using PizzaCase.Data;

namespace PizzaCase.Models;

public class ToppingAmount
{
    public int Amount { get; set; }
    public int ToppingName { get; set; }
    public bool Add { get; set; }

    public void AddTopping()
    {
        Amount++;
    }

    public void RemoveTopping()
    {
        Amount--;
    }

    public ToppingNames GetToppingName()
    {
        return (ToppingNames)ToppingName;
    }
}