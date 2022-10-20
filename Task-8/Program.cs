using System;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. 
            // 2. JumpKangaroo();
            // 3.
             SalesByMatch();

        }

        static void JumpKangaroo()
        {
            Random rnd = new Random();
            int x1 = rnd.Next(1, 10);
            int x2 = rnd.Next(x1, 10);
            int j1 = rnd.Next(1, 10);
            int j2 = rnd.Next(1, 10);



            if (j1>j2 && (x2-x1)%(j1-j2) ==0)

            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void SalesByMatch()
        {
            Random rand = new Random();
            int [] corab = new int[rand.Next(1,20)];     

            for (int i = 0; i < corab.Length; i++)
            {
                corab[i] = rand.Next(1,10);
               
            }
            Console.WriteLine("*************************************************************");

            int netice = 0;
            for (int i = 1; i <= 10; i++) // corab[i] = aldighi reqemler 1-10 arasinda oldughu uchun
            {
                int say = 0; // listdeki bir reqemden neche eded oldughunu saxlayan sayghac
                for (int j = 0; j < corab.Length; j++) // listin uzunlighu
                {
                    if (i == corab[j]) // 1-10 arasi reqemle listin indexsinin aldighi reqem
                    {
                        say++; 
                    }                                      
                }
                
                   Console.WriteLine($"{i} reqeminden {say} eded");
                
                int cut = 0;
                if (say%2==0)
                {
                    cut = say/2; 
                   
                }
                else if (say%2==1)
                {
                    cut = say/2;
                }

                netice = netice+cut;
                                       
            }
            Console.WriteLine($"{netice}cut corab");





        }


    }
}
