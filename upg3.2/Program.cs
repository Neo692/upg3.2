using System;
using System.ComponentModel.Design;

namespace upg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du klarat gymnasiet? svara j för ja och n för nej");
            string gymnasiet = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasiet == "j" && ålder < 22)
                Console.WriteLine("Vi vill anställa dig");
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal");
            }
             
            }
        }
    }
