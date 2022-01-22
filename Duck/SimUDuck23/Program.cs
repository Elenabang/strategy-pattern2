using System;
using Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck23
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardduck = new MallardDuck();
            Duck redheadduck = new RedheadDuck();

            Duck[] duck = new Duck[] { mallardduck, redheadduck };

            for (int i = 0; i < duck.Length; i++)
            {
                Console.WriteLine(duck[i].Quack());
                Console.WriteLine(duck[i].Swim());
                Console.WriteLine(duck[i].Display());
            }

            Console.ReadKey();
        }
    }
}
