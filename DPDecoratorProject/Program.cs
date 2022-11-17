namespace DPDecoratorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new GavayPizza();
            Console.WriteLine($"{pizza1.Name} {pizza1.GetCost()}");

            pizza1 = new CheesePizza(pizza1);
            Console.WriteLine($"{pizza1.Name} {pizza1.GetCost()}");

            pizza1 = new BekonPizza(pizza1);
            Console.WriteLine($"{pizza1.Name} {pizza1.GetCost()}");
        }
    }
}