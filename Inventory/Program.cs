namespace Inventory
{
    internal class Program
    {
        static void Main()
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();
            string input;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] tokens = input.Split(" - ");
                switch (tokens[0])
                {
                    case "Collect":
                        if (journal.Contains(tokens[1]))
                        {
                            continue;
                        }
                        else
                        {
                            journal.Add(tokens[1]);
                        }
                        break;
                    case "Drop":
                        if (journal.Contains(tokens[1]))
                        {
                            journal.Remove(tokens[1]);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Combine Items":
                        string[] strings = tokens[1].Split(":");
                        if (journal.Contains(strings[0]))
                        {
                            int index = journal.FindIndex(x => x == strings[0]);
                            journal.Insert(index+1, strings[1]);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Renew":
                        if (journal.Contains(tokens[1]))
                        {
                            journal.Remove(tokens[1]);
                            journal.Add(tokens[1]);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
