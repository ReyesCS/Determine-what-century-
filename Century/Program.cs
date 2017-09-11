using System;

namespace Century
{
    class Program
    {
        static int Main(string[] args)
        {


            //int.TryParse((Console.ReadLine()),out year);
            int year = 2000;
                if (year % 100 >= 1)
                {
                Console.WriteLine((year / 100) + 1);
                }
                else
                {
                Console.WriteLine(year / 100);
                }

            }

        }
    }