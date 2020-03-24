using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson11Task1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Запустился главный поток");
            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(RecursThreads);
            Thread recursthread = new Thread(writeSecond);
            recursthread.Start(10);

            Console.WriteLine("Закончился главный поток");
            Console.ReadLine();
        }
        
        public static void RecursThreads(object argument)
        {
             
            for (int d= (int)argument - 1; d>0; d--)
            {
                Console.WriteLine("Начался поток " + d);
                
                    RecursThreads(d);
                


            }

        }
    }
}
