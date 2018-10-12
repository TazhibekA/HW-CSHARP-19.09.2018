﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_CS_19._09._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask(2,0);
        }

        static void FirstTask(int? firstNumber,int? secondNumber) {
            try
            {
                if (!firstNumber.HasValue)
                {
                    throw new ArgumentNullException();

                }
                else if (secondNumber.Value == 0)
                {
                    throw new ArgumentException();
                }
                else {
                    Console.WriteLine(firstNumber / secondNumber);
                }
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
        }

        static void SecondTask() {
            int[] numbers = new int[3];


            try
            {
                numbers[4] = 4;
            }
            catch(Exception exception) {
                Console.WriteLine("Error: " + exception.Message);
            }
        }
    }
}
