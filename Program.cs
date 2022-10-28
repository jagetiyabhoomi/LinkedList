using System.Collections;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> nodes = new List<int>();
            nodes.Add(70);
            nodes.Add(30);
            nodes.Add(56);
            nodes.Remove(56);
            Console.WriteLine("Successfully added");
            
        }
    }
}