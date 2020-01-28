using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_del_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //generator and variables
            Random generator = new Random();

            string carAmount;
            string numberOfTheCar;
            int numberOfCars;
            int whichCar;
            int maxNumberForCarChoice;
            int carToSearch;
            bool examine;
            //list for cars
            List<Car> cars = new List<Car>();
            
            //how many cars
            Console.WriteLine("How many cars should be created?");

            carAmount = Console.ReadLine();
            //imput check
            while (!int.TryParse(carAmount, out numberOfCars))
            {

                carAmount = Console.ReadLine();

                Console.WriteLine("Please enter a number!");

            }
            //loop for creating all of the cars
            for (int i = 0; i < numberOfCars; i = i++)
            {


                whichCar = generator.Next(1, 2);

                if (whichCar == 1)
                {
                    //create an instance of car that is a clean car
                    Car volvo = new CleanCar();


                    cars.Add(volvo);

                }
                else
                {
                    //create an instance of car that is a contrabanded car
                    Car audi = new ContrabandCar();

                    cars.Add(audi);
                }

            }

            maxNumberForCarChoice = numberOfCars--;
            //what cars do you want to examine
            Console.WriteLine("Which car do you want to look at? [" + 0 + " " + maxNumberForCarChoice + "]");
            numberOfTheCar = Console.ReadLine();
            //imput check
            while (!int.TryParse(numberOfTheCar, out carToSearch))
            {

                numberOfTheCar = Console.ReadLine();

                Console.WriteLine("Please enter a number!");

            }

            if (cars[carToSearch].alreadyChecked != true)
            {


                examine = cars[carToSearch].Examine();

                Console.WriteLine(examine);
                Console.WriteLine(cars[carToSearch].contrabandAmount);



            }
            else
            {
                Console.WriteLine("Car has been checked already");
            }

            Console.ReadLine();



        }
    }
}
