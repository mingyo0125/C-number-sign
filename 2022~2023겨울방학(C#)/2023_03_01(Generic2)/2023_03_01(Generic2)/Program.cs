﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_03_01_Generic2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            for(int i  = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                if(list.Count-1 == i)
                {
                    Console.WriteLine("List 끝");
                }
            }
            #endregion

            #region Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("Queue 끝");
            #endregion
        }
    }
}
