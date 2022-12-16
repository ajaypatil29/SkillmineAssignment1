using System;
using System.Collections;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class StackDemo
    {
        static void Main(string []args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.Pop();
            Console.WriteLine("top element of stack="+stack.Peek());
            foreach (var item in stack )
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();
            Console.WriteLine("First element in queue="+queue.Peek ());
            foreach (var   item in queue )
            {
                Console.WriteLine(item );
            }
            Console.WriteLine("-----------------------");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "A");
            hashtable.Add(2, "B");
            hashtable.Add(3, "C");

            hashtable.Remove("C");
            foreach (DictionaryEntry  item in hashtable )
            {
                Console.WriteLine(item.Key +"  "+item.Value );
            }
            Console.WriteLine("-----------------------");

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "A");
            sortedList.Add(2, "B");
            sortedList.Add(3, "C");

           
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

        }
    }
}
