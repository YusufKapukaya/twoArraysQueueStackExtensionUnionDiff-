using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class CreateQueueArr
    {
        private int[] ints = new int[2];

        private void elementsArr()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("How many elements do you need at " + (1 + i) + ".Array");
                try
                {
                    ints[i] = int.Parse(Console.ReadLine());
                }
                catch (FormatException exp)
                {
                    Console.WriteLine("Please give only a Number. Your Error Type is " + exp);
                }
            }
        }

        private void fillQueue(int t, Queue<int> queueTemp)
        {
            for (int i = 0; i < ints[t]; i++)
            {
                Console.WriteLine("Give the " + (t + 1) + ". Array " + (i + 1) + ". elements");

                try
                {
                    queueTemp.Enqueue(int.Parse(Console.ReadLine()));
                }
                catch (FormatException exp)
                {
                    Console.WriteLine("Please give only a Number. Your Error Type is " + exp);
                }
            }
        }
        public void crtQueue(Queue<int> queueOne, Queue<int> queueTwo)
        {
            Console.WriteLine("You have just choosed create two Arrays with Queue method");
            elementsArr();
            fillQueue(0, queueOne);
            fillQueue(1, queueTwo);
        }
    }
}
