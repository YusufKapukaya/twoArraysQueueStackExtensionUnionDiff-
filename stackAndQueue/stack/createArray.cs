using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class createArray
    {
        public void crtArray(Stack<int> stackOne, Stack<int> stackTwo)
        {
            Console.WriteLine("You have just choosed create two Arrays with Queue method");
            int[] t = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("How many elements do you want " + (i + 1) + ". array");
                int v = int.Parse(Console.ReadLine());
                //int v = Convert.ToInt32(Console.ReadLine());
                t[i] = v;
            }

            for (int k = 0; k < t[0]; k++)
            {
                Console.WriteLine("1. Array " + (k + 1) + ". element");
                int element = int.Parse(Console.ReadLine()); ;
                stackOne.Push(element);
            }
            for (int k = 0; k < t[1]; k++)
            {
                Console.WriteLine("2. Array " + (k + 1) + ". element");
                int element = int.Parse(Console.ReadLine()); ;
                stackTwo.Push(element);
            }

            /*for (int l = 0; l < t[0]; l++)
            {
                Console.WriteLine(l + ". Element " + stackOne.Peek());
                stackOne.Pop();
            }*/

        }
    }
}
