using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Compare
    {
        private Stack<int> s1;
        private Stack<int> s2;
        public Compare(Stack<int> s1, Stack<int> s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }
        public Stack<int> Diffe(bool a)
        {
            Stack<int> diff = new Stack<int>();
            Stack<int> tempS1;
            Stack<int> tempS2;
            Stack<int> tempS3 = new Stack<int>();
            Stack<int> tempS4 = new Stack<int>();
            int k;
            int t;

            if (a)
            {
                tempS1 = s1;
                tempS2 = s2;
            }
            else
            {
                tempS1 = s2;
                tempS2 = s1;
            }
            while (tempS1.Count > 0)
            {
                bool flag = true;
                t = tempS1.Pop();
                tempS3.Push(t);
                while (tempS2.Count > 0)
                {
                    k = tempS2.Pop();
                    tempS4.Push(k);
                    if (t == k)
                    {
                        flag = false;
                        break;
                    }
                }
                while (tempS4.Count > 0)
                {
                    tempS2.Push(tempS4.Pop());
                }
                if (flag)
                {
                    diff.Push(t);
                }
            }
            while (tempS3.Count > 0)
            {
                tempS1.Push(tempS3.Pop());
            }

            return diff;

        }

        public Stack<int> Intersection()
        {
            Stack<int> intersection = new Stack<int>();
            Stack<int> tempS1 = new Stack<int>();
            Stack<int> tempS2 = new Stack<int>();

            while (s1.Count > 0)
            {
                bool flag = false;
                int top1 = s1.Peek();
                tempS1.Push(top1);
                s1.Pop();
                while (s2.Count > 0)
                {
                    int top2 = s2.Peek();
                    tempS2.Push(top2);
                    s2.Pop();
                    if (top1 == top2)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag)
                {
                    intersection.Push(top1);
                }
                while (tempS2.Count > 0)
                {
                    s2.Push(tempS2.Pop());
                };

            }
            while (tempS1.Count > 0)
            {
                s1.Push(tempS1.Pop());
            }
            return intersection;
        }

        public Stack<int> Union()
        {
            Stack<int> Union = new Stack<int>();
            Stack<int> tempS1 = new Stack<int>();
            Stack<int> tempS2 = new Stack<int>();

            while (s1.Count > 0)
            {
                int t = s1.Pop();
                Union.Push(t);
                tempS1.Push(t);
            }
            while (tempS1.Count > 0)
            {
                s1.Push(tempS1.Pop());
            }

            while (s2.Count > 0)
            {
                int e = s2.Pop();
                bool flag = true;
                tempS2.Push(e);
                while (Union.Count > 0)
                {
                    int t = Union.Pop();
                    tempS1.Push(t);
                    if (e == t)
                    {
                        flag = false;
                        break;
                    }
                }
                while (tempS1.Count > 0)
                {
                    Union.Push(tempS1.Pop());
                }
                if (flag)
                {
                    Union.Push(e);
                }
            }

            while (tempS2.Count > 0)
            {
                s2.Push(tempS2.Pop());
            }

            return Union;

        }


    }
}

