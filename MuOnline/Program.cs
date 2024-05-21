namespace MuOnline
{
    internal class Program
    {
        static void Main()
        {
            List<string> dungeonsRoom = Console.ReadLine().Split("|").ToList();
            int initialHealth = 100;
            int initialBitcoins = 0;
            for (int i = 0; i < dungeonsRoom.Count; i++)
            {
                string[] room = dungeonsRoom[i].Split(" ");
                switch (room[0])
                {
                    case "potion":
                        int healed = int.Parse(room[1]);
                        if (initialHealth + healed > 100)
                        {
                            healed = 100 - initialHealth;
                        }
                        initialHealth += healed;
                        Console.WriteLine($"You healed for {healed} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                        break;
                    case "chest":
                        initialBitcoins += int.Parse(room[1]);
                        Console.WriteLine($"You found {int.Parse(room[1])} bitcoins.");
                        break;
                    default:
                        initialHealth -= int.Parse(room[1]);
                        if (initialHealth > 0)
                        {
                            Console.WriteLine($"You slayed {room[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {room[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        break;
                }
            }
            if (initialHealth > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
