using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWork0._01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nump> numps = new List<Nump>();

            Addy(numps);
            Print(numps);



            Console.ReadKey();
        }
        private static void Addy(List<Nump> list)
        {
            Random rand = new Random();

            for (int i = 1; i <= 100; i++)
            {
                list.Add(new Nump() { NumpID = i, NumpIS = (int)rand.Next(1, 101) });
            }
        }


        private static void Print(List<Nump> list)
        {
            Console.WriteLine();
            foreach (Nump s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}

