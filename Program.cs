using System;
using System.Threading;

namespace DogMove
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogPosition1 = (@"
           __
      (___()'`;
      /,,,,,/`
      \\   \\");




            string dogPosition2 = (@"
             __
        )___()'`;
        /,,,,,/`
       //   //");

            for(int i=0;i<100;i++)
            {
                Console.WriteLine(dogPosition1);
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine(dogPosition2);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
