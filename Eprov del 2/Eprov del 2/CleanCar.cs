using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_del_2
{
    class CleanCar : Car
    {
        //changing variables by creating a public clean car
        public CleanCar()
        {
            passanger = generator.Next(1, 3);

            contrabandAmount = 0;
        }
    }
}
