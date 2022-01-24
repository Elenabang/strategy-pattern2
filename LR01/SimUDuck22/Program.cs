using System;
using Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuDuck22
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardduck = new MallardDuck();
            Duck redheadduck = new RedheadDuck();
            Duck decoyduck = new DecoyDuck();
            Duck rubberduck = new RubberDuck();

            Duck[] ducks = new Duck[] { mallardduck, redheadduck, decoyduck, rubberduck };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                if (ducks[i] is IFlyable)
                {
                    Console.WriteLine((ducks[i] as IFlyable).Fly());
                }
                if (ducks[i] is IQuackable)
                {
                    Console.WriteLine((ducks[i] as IQuackable).Quack());
                }
            }

            Console.ReadKey();
        }
    }
}
