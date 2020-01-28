using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_del_2
{
    class Car
    {
        //cariables
        public Random generator = new Random();

        public int passanger;

        public int contrabandAmount;

        public bool alreadyChecked;

        public bool hasContraband;



        //bool for examination of a car
        public bool Examine()
        {

            if (contrabandAmount > 0)
            {
                alreadyChecked = true;

                return hasContraband = true;
            }

            else
            {
                alreadyChecked = true;
                
                return hasContraband = false;
                
            }

            
        }


    }
}
