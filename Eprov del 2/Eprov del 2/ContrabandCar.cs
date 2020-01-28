using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_del_2
{
    class ContrabandCar : Car
    {
        //changing variables by creating public contrabanded car
        public ContrabandCar()
        {

            passanger = generator.Next(1, 4);

            contrabandAmount = generator.Next(1, 4);

        }

    }
}
