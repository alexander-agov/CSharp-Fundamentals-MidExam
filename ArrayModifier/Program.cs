namespace ArrayModifier
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "swap":
                        int removed2 = list[int.Parse(command[2])];
                        int removed1 = list[int.Parse(command[1])];
                        list.RemoveAt(int.Parse(command[2]));
                        list.Insert(int.Parse(command[2]), removed1);
                        list.RemoveAt(int.Parse(command[1]));
                        list.Insert(int.Parse(command[1]), removed2);
                        break;
                    case "multiply":
                        int taked1 = list[int.Parse(command[1])];
                        int product = taked1 * list[int.Parse(command[2])];
                        list.RemoveAt(int.Parse(command[1]));
                        list.Insert((int.Parse(command[1])), product);
                        break;
                    case "decrease":
                        for (int i = 0; i < list.Count; i++)
                        {
                            list[i] -= 1;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
