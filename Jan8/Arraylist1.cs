using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan8
{
    internal class Arraylist1
    {
        ArrayList al = new ArrayList();

        public void AddElementsToArrayList()
        {
            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
        }

        public void DisplayArrayList()
        {
            Console.WriteLine($"Capacity: {al.Capacity}");
            Console.WriteLine($"Count: {al.Count}");

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
