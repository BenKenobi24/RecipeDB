using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{


    class Program
    {
        static void Main(string[] args)
        {
            Recipe pizza = new Recipe();
            pizza.Name = "pizza";
            pizza.Price = 10;

            Console.WriteLine(pizza);
            Console.ReadKey();
        }
    }
}
