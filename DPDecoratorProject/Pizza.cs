using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPDecoratorProject
{
    abstract internal class Pizza
    {
        public Pizza(string name)
        {
            Name = name;
        }

        public string Name { set; get; }
        public abstract decimal GetCost();
    }

    internal class GavayPizza : Pizza
    {
        public GavayPizza() : base("Гавайская пицца") { }
        public override decimal GetCost()
        {
            return 560.00m;
        }
    }

    internal class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца") { }
        public override decimal GetCost()
        {
            return 520.00m;
        }
    }

    abstract internal class IPizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public IPizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }

    internal class BekonPizza : IPizzaDecorator
    {
        public BekonPizza(Pizza pizza) : base(pizza.Name + " с беконом", pizza)
        {
        }

        public override decimal GetCost()
        {
            return pizza.GetCost() + 30.0m;
        }
    }

    internal class CheesePizza : IPizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + " с сыром", pizza)
        {
        }

        public override decimal GetCost()
        {
            return pizza.GetCost() + 20.0m;
        }
    }
}
