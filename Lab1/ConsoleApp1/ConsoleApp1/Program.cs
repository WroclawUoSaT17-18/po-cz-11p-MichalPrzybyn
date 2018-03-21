using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            student s1 = new student();


            Console.WriteLine("podaj imie");
            s1.im = Console.ReadLine();
            Console.WriteLine("podaj naziwsko");
            s1.naz = Console.ReadLine();
            Console.WriteLine("podaj nr albumu");
            s1.nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ocene nr1");
            s1.o1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ocene nr2");
            s1.o2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ocene nr3");
            s1.o3 = int.Parse(Console.ReadLine());


            Console.WriteLine("\n{0}", s1.im);
            Console.WriteLine("{0}", s1.naz);
            Console.WriteLine("{0}", s1.nr);

            double sr = (s1.o1 + s1.o2 + s1.o3) / 3.0;



            Console.WriteLine("Twoja srednia ocen to: {0}", sr);

            Console.Read();


        }

        class student
        {

            public string im;
            public string naz;
            public double nr;
            public int o1;
            public int o2;
            public int o3;

        }
    }
}
