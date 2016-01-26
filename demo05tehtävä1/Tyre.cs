using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo05tehtävä1
{
     class Tyre 
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string TyreSize { get; set; }
        public override string ToString()
        {
            return "  Name:" + Name + "  Model:" + Model + "  TyreSize:" + TyreSize;
        }

    }
}
