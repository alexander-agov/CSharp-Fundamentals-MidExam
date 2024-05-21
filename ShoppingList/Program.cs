namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("!").ToList();
            string input;
            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split();
                string tokens = command[0];
                string item = command[1];
                switch (tokens)
                {
                    case "Urgent":
                        if (list.Contains(item))
                        {
                            continue;
                        }
                        list.Insert(0, item);
                        break;
                    case "Unnecessary":
                        if (list.Contains(item))
                        {
                            list.Remove(item);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Correct":
                        string newItem = command[2];
                        if (list.Contains(item))
                        {
                            int index = list.IndexOf(item);
                            list.RemoveAt(list.IndexOf(item));
                            list.Insert(index, newItem);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Rearrange":
                        if (list.Contains(item))
                        {
                            list.Remove(item);
                            list.Add(item);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
