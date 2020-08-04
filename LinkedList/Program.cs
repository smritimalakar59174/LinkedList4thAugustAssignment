using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
            Console.WriteLine("performing linkedlist methods");
            foreach (string str in lList)
            {
                Console.WriteLine(str);
            }
           lList.AddFirst("the");
            Console.WriteLine( " Add 'the' to beginning of the list:{0}",lList.Count);
            foreach (string the in lList)
            {
                Console.WriteLine(the);
            }
           
            LinkedListNode<string> current = lList.Find("fox");
            lList.AddBefore(current,"brown");
            Console.WriteLine("Add 'brown'  to the list:{0}", lList.Count);
            foreach (string brown in lList)
            {
                Console.WriteLine(brown);
            }
            LinkedListNode<string> current2 = lList.Find("fox");
            lList.AddAfter(current2, "jumps");
            Console.WriteLine("Add 'jumps' to  the list:{0}", lList.Count);
            foreach (string jump in lList)
            {
                Console.WriteLine(jump);
            }
            LinkedListNode<string> current3 = lList.FindLast("jumps");
            
            lList.AddAfter(current3, "over");
            Console.WriteLine("Add 'over' to  the list:{0}", lList.Count);
            foreach (string over in lList)
            {
                Console.WriteLine(over);
            }
            lList.AddLast("fox");
            Console.WriteLine(" Add 'fox' to ending of the list:{0}", lList.Count);
            foreach (string fox in lList)
            {
                Console.WriteLine(fox);
            }
        }
    }
}
