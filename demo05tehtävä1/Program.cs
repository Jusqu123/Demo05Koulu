using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo05tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create tyre HUOM NEW STYLE TO WRITE IT
            Tyre tyre = new Tyre { Name = " Nokia ", Model = " hakka ", TyreSize = " 20R465 " };
            Tyre tyre2 = new Tyre { Name = " zingzong ", Model = " pong ", TyreSize = " 234t5 " };

            //CREATE CAR
            Vehicle car = new Vehicle { Model = "audi", Name = "R8" };
            car.addTyre(tyre); // car contains tyres
            car.addTyre(tyre);
            car.addTyre(tyre);
            car.addTyre(tyre);
            Console.WriteLine(car.ToString());
            //   List<Tyre> tyres = new List<Tyre>();

            Vehicle car2 = new Vehicle { Model = "ford", Name = "Fiesta" };

            car2.addTyre(tyre2);
            car2.addTyre(tyre2);
            car2.addTyre(tyre2);
            car2.addTyre(tyre2);
            Console.WriteLine(car2.ToString());


        }
    }
}
