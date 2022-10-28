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
            Console.WriteLine("Successfully added");
            if (nodes.Contains(30) == true)
            {
                Console.WriteLine("Element Found...!!");
            }
            else
            {
                Console.WriteLine("Element Not found...!!");
            }
            
            
        }
    }
}