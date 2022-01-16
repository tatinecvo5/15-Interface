using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите начальное значение x=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("шаг прогрессии s=");
            int b = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression();
            Console.WriteLine("Арифметическая пргрессия");
            arithProgression.setStart(a);
            arithProgression.setStep(b);
            //Console.WriteLine(arithProgression.setStart());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.Write("Сброс к начальному значению ");
            arithProgression.reset();
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine("Геометическая пргрессия");
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(a);
            geomProgression.setStep(b);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.Write("Сброс к начальному значению ");
            geomProgression.reset();
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();
        }
    }
}