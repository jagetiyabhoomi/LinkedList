﻿using System.Collections;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> nodes = new List<int>();
            nodes.Add(70);
            nodes.Add(56);
            nodes.Insert(1, 70);
            Console.WriteLine("Successfully added");
            
        }
    }
}