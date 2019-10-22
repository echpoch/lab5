using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bench bench1 = new Bench { name = "bench1", length = 23, mass = 15, width = 3 };

            Console.WriteLine(bench1.Cost(2));

            Tennis tennis1 = new Tennis { number = 3, name = "tennis1", mass = 10, radius = 5 };

            Console.WriteLine(tennis1.Lifetime(5));             // методы абстрактного класса


            tennis1.ToString();

            set_of_classes ball1 = new set_of_classes();

            //cube cub = new cube();
            //cub.Print();
            Class2 cl1 = new Class2();                              // объект для одноименный метод в интерфейсе и в абстрактном классе



            Console.WriteLine(((Interface1)cl1).SUM(2, 3));         // одноименный метод в интерфейсе и в абстрактном классе

            Printer pr = new Printer();       

            Description[] arr = new Description[3] { bench1, tennis1,ball1 };
            pr.IAmPrinting(arr[0]);
            pr.IAmPrinting(arr[1]);
            pr.IAmPrinting(arr[2]);

            Console.ReadKey();

        }
    }
}
