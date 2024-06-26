﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeNeededToBuyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeNeededToBuyTickets(new int[] { 84, 49, 5, 24, 70, 77, 87, 8 }, 3));
            Console.WriteLine(TimeNeededToBuyTickets(new int[] { 2, 3, 2 }, 2));
            Console.WriteLine(TimeNeededToBuyTickets(new int[] { 5, 1, 1, 1 }, 0));
        }

        public static int TimeNeededToBuyTickets(int[] tickets, int k)
        {
            int count = 0;
            int time = 0;
            int person = tickets[k];
            while (count < person)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] == 0)
                        continue;
                    if (tickets[k] == 0)
                        break;
                    tickets[i]--;
                    time++;
                }
                count++;
            }
            return time;
        }
    }
}
