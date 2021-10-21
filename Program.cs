using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
    {
    class Program
        {
        static void Main(string[] args)
            {
            

            Console.WriteLine("The ticket is £5, please insert your cash to the machine!");
             int cash =    Convert.ToInt32(Console.ReadLine());


            if (cash < 5)
                {
                int remaing = 5 - cash;
                Console.WriteLine("Please inser your remaing £" + remaing);
                int cash1 = Convert.ToInt32(Console.ReadLine());
                int cash2 = cash1 + remaing;
                int change1 = cash2 - 5;
                int change2 = cash - 5;

                if (cash2 == 5)
                    {
                    Console.WriteLine("Please collect your ticket from the machine");
                    }
                else 
                    if (cash2 > 5)
                    {
                    Console.WriteLine("Please Collect your ticket and £" + change1 + " from the machine!");
                    }
                }
                 else
                    if (cash == 5)
                
                    {
                    Console.WriteLine("Please collect your ticket from the machine");
                    }
                else
                    if(cash > 5)
                    {
                    Console.WriteLine("Please Collect your ticket and £" + change2 + " from the machine!");
                    }
                




            //wait before closing the programme
            Console.ReadKey();
         
            }
        }
    }
