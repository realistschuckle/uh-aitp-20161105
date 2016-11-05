using System;

public class Pizza
{
    public Pizza(string size, string crust)
    {
        this.toppingCount = 0;
        this.size = size;
        this.crust = crust;

        if (this.size == "large")
        {
            this.cost = 12.48m;
        }
        if (this.crust == "new york")
        {
            this.cost += 2.5m;
        }
    }

    public void AddTopping(string toppingName)
    {
        if (this.toppingCount < 3)
        {
            Console.WriteLine("Adding a dollar with " + this.toppingCount + " toppings.");
            this.cost += 1;
        }
        else
        {
            Console.WriteLine("Adding a quarter with " + this.toppingCount + " toppings.");
            this.cost += 0.25m;
        }
        this.toppingCount += 1;
    }

    public decimal Cost
    {
        get { return this.cost; }
    }

    public void Bake(DateTime whenItsDone)
    {

    }

    private decimal cost;

    private string size;

    private int toppingCount;

    private string[] toppings;

    public string crust;
}