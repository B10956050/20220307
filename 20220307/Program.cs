using System;

namespace _20220307
{
    class Program
{
    static void Main(string[] args)
    {
        double meal_cost = 100;

        int tip_percent = 15;

        int tax_percent = 8;

        double money;

        money = meal_cost + tip_percent + tax_percent;

        Console.WriteLine(money);
    }
}
}
