using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            for(int i=0;i<20;i++)
            {
                for(int j=0;j<33;j++)
                {

                    for (int d = 0; d <= 100; d = d + 3)
                    {

                        if (d + j + i == 100 && i * 5 + j * 3 + d/3 ==100)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(j);
                            Console.WriteLine(d);
                        }
                    }
                }
            }
           
            Console.Read();
        }
    }
}
