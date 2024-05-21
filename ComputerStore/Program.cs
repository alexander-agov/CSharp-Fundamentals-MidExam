using System.Diagnostics;

namespace ComputerStore
{
    internal class Program
    {
        static void Main()
        {
            string price;
            double totalPrice = 0;
            while ((price = Console.ReadLine()) != "special" && price != "regular")
            {
                if (double.TryParse(price, out double result))
                {
                    if (result < 0)
                    {
                        Console.WriteLine("Invalid price!");
                        continue;
                    }
                    totalPrice += double.Parse(price);
                    if (totalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                }
            }
            if (price == "regular")
            {
                if (totalPrice == 0)
                {
                    Console.WriteLine("Invalid order!");
                    return;
                }
                else
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                    Console.WriteLine($"Taxes: {(totalPrice * 20 / 100):f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {(totalPrice + (totalPrice * 20 / 100)):f2}$");
                    return;
                }
            }
            if (price == "special")
            {
                if (totalPrice == 0)
                {
                    Console.WriteLine("Invalid order!");
                    return;
                }
                else
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                    Console.WriteLine($"Taxes: {(totalPrice * 20 / 100):f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {((totalPrice + (totalPrice * 20 / 100)) * 90 / 100):f2}$");
                    return;
                }
            }
        }
    }
}

