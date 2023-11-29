using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{

    internal class Program
    {
        static void Main(string[] args)
        {
            compareMashin();
        }

        static void compareMashin()
        {
            int choose;
            Console.WriteLine("If you want to creat a Stack Array then press 1 or for Queue Array press 2");
            choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                while (true)
                {
                    Stack<int> stackOne = new Stack<int>();
                    Stack<int> stackTwo = new Stack<int>();
                    Console.WriteLine("Do you want to create new arrays? If so Press 1, If you break the Programm press 2");
                    int t = int.Parse(Console.ReadLine());

                    if (t == 1)
                    {
                        createArray crt = new createArray();
                        crt.crtArray(stackOne, stackTwo);

                        Compare cpr = new Compare(stackOne, stackTwo);

                        while (true)
                        {
                            Console.WriteLine("What do you want to do with two Arrays?  For Intersection press 1 or Union press 2 or Differant press 3 for break press 4 ");
                            int v = int.Parse(Console.ReadLine());
                            Stack<int> temp = new Stack<int>();
                            Console.WriteLine("----------------------------------------------------");

                            if (v == 1)
                            {
                                temp = cpr.Intersection();
                            }
                            else if (v == 2)
                            {
                                temp = cpr.Union();
                            }
                            else if (v == 3)
                            {
                                Console.WriteLine("Do you want the difference First Array from Second Array then write true or vice versa and write false ");
                                bool sort = bool.Parse(Console.ReadLine());
                                temp = cpr.Diffe(sort);
                            }
                            else if (v == 4)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Unassigned Number");
                            }
                            while (temp.Count > 0)
                            {
                                Console.WriteLine(temp.Pop());
                            }
                        }

                    }
                    else if (t == 2)
                    {
                        break;
                    }

                }
            }
            else if (choose == 2)
            {
                int areaChoose = 0;
                while (true)
                {
                    CreateQueueArr crtQueArr = new CreateQueueArr();
                    Queue<int> queOne = new Queue<int>();
                    Queue<int> queTwo = new Queue<int>();
                    crtQueArr.crtQueue(queOne, queTwo);
                    CompareQueue cmpQueArr = new CompareQueue(queOne, queTwo);

                    while (areaChoose != 4)
                    {
                        Console.WriteLine("What do you want to do with the Arrays? " +
                                                "for Intersection press One or for Union press Two or for differant press Three. If you want to creat the new arrays or end of Program press four");
                        areaChoose = int.Parse(Console.ReadLine());
                        if (areaChoose == 1)
                        {
                            cmpQueArr.Intersection();
                        }
                        else if (areaChoose == 2)
                        {
                            cmpQueArr.UnionQueue();
                        }
                        else if (areaChoose == 3)
                        {
                            Console.WriteLine("Do you want to different first Array from second Array if so write true if not write false");
                            bool diffChoose = bool.Parse(Console.ReadLine());
                            cmpQueArr.Diff(diffChoose);
                        }
                        else if (areaChoose != 4)
                        {
                            Console.WriteLine("Your Choose was undeclieared try again");
                        }

                    }
                    Console.WriteLine("Do you want to finish the Programm? If so press five for a new press six");
                    areaChoose = int.Parse(Console.ReadLine());
                    if (areaChoose == 5)
                    {
                        Console.WriteLine("The End");
                        break;
                    }
                    Console.WriteLine("The new Arrays must be declaraid!");
                }

            }

            Console.ReadLine();
        }

    }
}
