using System.ComponentModel.Design;

namespace MovingTarget
{
    internal class Program
    {
        static void Main()
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                int index = int.Parse(tokens[1]);
                int otherThing = int.Parse(tokens[2]);
                switch (command)
                {
                    case "Shoot":
                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= otherThing;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, otherThing);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        if (targets.Count < otherThing * 2 + 1 || (index - otherThing) < 0)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }
                        else
                        {
                            targets.RemoveRange(index - otherThing, otherThing * 2 + 1);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join("|", targets));
            return;
        }
    }
}
