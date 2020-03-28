﻿using System;

namespace BankInterestRecrussion
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter number total month :");
            int numberMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter balance :");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CalculateInterest(numberMonth, balance));
            Console.ReadKey();
        }

        //
        // Summary:
        //    Program to callculate Bank Interest using recrusion 
        // Parameters:
        //   numberMonth:
        //     An integer number for numberMonth
        //   balance:
        //     An integer number for balance
        // Returns:
        //     A double-precision floating-point number that is result of total balance 

        static double CalculateInterest(int numberMonth, double balance)
        {
            if (numberMonth == 0)
            {
                return balance;
            }
            else
            {
                double rate = 0.01;
                balance += balance * rate;

                numberMonth -= 1;
                //call recrusion function
                return CalculateInterest(numberMonth, balance);
            }

        }

    }
}


