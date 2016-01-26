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


            //CREATE CAR
            Vehicle car = new Vehicle { Model = "audi", Name = "R8" };
            car.addTyre(tyre); // car contains tyres
            car.addTyre(tyre);
            car.addTyre(tyre);
            car.addTyre(tyre);
            Console.WriteLine(car.ToString());
            //   List<Tyre> tyres = new List<Tyre>();



           

        }
    }
}
