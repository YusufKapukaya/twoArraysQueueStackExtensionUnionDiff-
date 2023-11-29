using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class CompareQueue
    {
        private Queue<int> queueOne;
        private Queue<int> queueTwo;

        public CompareQueue(Queue<int> queueOne, Queue<int> queueTwo)
        {
            this.queueOne = queueOne;
            this.queueTwo = queueTwo;

        }
        private void initilaizerArrays()
        {

        }
        public void PrintResult(Queue<int> queueTemp, Queue<int> tempQueue)
        {
            int temp;
            while (queueTemp.Count > 0)
            {
                temp = queueTemp.Dequeue();
                Console.WriteLine(temp);
                tempQueue.Enqueue(temp);
            }
            while (tempQueue.Count > 0)
            {
                queueTemp.Enqueue(tempQueue.Dequeue());
            }
        }

        public void FillFirstArr(Queue<int> taker, Queue<int> giver)
        {
            while (giver.Count > 0)
            {
                taker.Enqueue(giver.Dequeue());
            }
        }

        public void AddResultInArr(bool Flag, int temp, Queue<int> resultArr)
        {
            if (Flag)
            {
                resultArr.Enqueue(temp);
            }
        }

        public void FillTwoArrFromFirstArr(Queue<int> giver, Queue<int> takerOne, Queue<int> takerTwo)
        {
            int tempQ;
            while (giver.Count > 0)
            {
                tempQ = giver.Dequeue();
                takerOne.Enqueue(tempQ);
                takerTwo.Enqueue(tempQ);
            }
        }
        public int MoveEnqueue(Queue<int> giver, Queue<int> taker)
        {
            int tmp;
            tmp = giver.Dequeue();
            taker.Enqueue(tmp);
            return tmp;
        }


        public void UnionQueue()
        {
            Queue<int> tempQueue = new Queue<int>();
            Queue<int> tempQueue2 = new Queue<int>();
            Queue<int> queueResult = new Queue<int>();
            FillTwoArrFromFirstArr(queueOne, tempQueue, queueResult);
            FillFirstArr(queueOne, tempQueue);

            while (queueTwo.Count > 0)
            {
                bool Flag = true;
                int tempQ2 = MoveEnqueue(queueTwo, tempQueue2);

                while (queueOne.Count > 0)
                {
                    int tempQ3 = MoveEnqueue(queueOne, tempQueue);

                    if (tempQ2 == tempQ3)
                    {
                        Flag = false;
                        break;
                    }
                }
                FillFirstArr(queueOne, tempQueue);
                AddResultInArr(Flag, tempQ2, queueResult);
            }
            FillFirstArr(queueTwo, tempQueue2);
            PrintResult(queueResult, tempQueue);
        }


        public void Diff(bool a)
        {
            Queue<int> queueDiff = new Queue<int>();
            Queue<int> tempQueue = new Queue<int>();
            Queue<int> tempQueue2 = new Queue<int>();
            Queue<int> tempQueOne;
            Queue<int> tempQueTwo;

            if (a)
            {
                tempQueOne = queueOne;
                tempQueTwo = queueTwo;
            }
            else
            {
                tempQueTwo = queueOne;
                tempQueOne = queueTwo;
            }

            while (tempQueOne.Count > 0)
            {
                bool Flag = true;
                int temp = MoveEnqueue(tempQueOne, tempQueue);

                while (tempQueTwo.Count > 0)
                {
                    int temp2 = MoveEnqueue(tempQueTwo, tempQueue2);

                    if (temp == temp2)
                    {
                        Flag = false;
                        break;
                    }
                }
                FillFirstArr(tempQueTwo, tempQueue2);
                AddResultInArr(Flag, temp, queueDiff);

            }
            FillFirstArr(tempQueOne, tempQueue);
            PrintResult(queueDiff, tempQueue);
        }


        public void Intersection()
        {
            Queue<int> queueIntersection = new Queue<int>();
            Queue<int> tempQueue = new Queue<int>();
            Queue<int> tempQueue2 = new Queue<int>();
            int tempOne;
            int tempTwo;
            while (queueOne.Count > 0)
            {
                bool Flag = false;
                tempOne = MoveEnqueue(queueOne, tempQueue);
                while (queueTwo.Count > 0)
                {
                    tempTwo = MoveEnqueue(queueTwo, tempQueue2);
                    if (tempOne == tempTwo)
                    {
                        Flag = true;
                        break;
                    }
                }
                FillFirstArr(queueTwo, tempQueue2);
                AddResultInArr(Flag, tempOne, queueIntersection);
            }
            FillFirstArr(queueOne, tempQueue);
            PrintResult(queueIntersection, tempQueue);

        }

    }
}
