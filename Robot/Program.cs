namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("Introduceti cutie: ");
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                int box = int.Parse(input);
                if (stack.Count == 0)
                    stack.Push(box);
                else
                {
                    if (!stack.Contains(box))
                    {
                        if (box < stack.Peek())
                            stack.Push(box);
                        else
                        {
                            while (stack.Count > 0 && stack.Peek() <= box)
                                stack.Pop();
                            stack.Push(box);
                        }
                    }
                    Console.WriteLine("Introduceti cutie: ");
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine("Stiva contine: {0} cutii", stack.Count);
            Console.WriteLine("Elementele stivei sunt:");
            foreach (int elem in stack)
            {
                Console.WriteLine(elem);
            }
        }
    }
}