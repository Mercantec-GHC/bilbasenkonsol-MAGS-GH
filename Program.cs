using Class_Domain_Models;

namespace BilbasenKonsol
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Eksempel med rigtige biler, lavet af ChatGPT ud fra jeres standart klasse
            // Creating an EVCar object
            List<Car> allCars = new CreateCars().CreateListOfCars();

            Console.WriteLine("There are " + allCars.Count + " of cars in our system!");
            Console.WriteLine("Do you want a specific color? Then write it here or press enter for all colors");
            var colorFilter = Console.ReadLine();
            if (colorFilter != "") { 
               allCars = allCars.Where(car => car.color == colorFilter).ToList(); 
            }
            if (allCars.Count == 0) { Console.WriteLine("We have no cars with that color :( "); }
            else
            {
                Console.WriteLine("There are " + allCars.Count + " of cars in our system with that color!");
            }

            Console.WriteLine("Do you want it to have over a specific amount of HP? Then write it here or press enter for all colors");
            var hpFilter = Console.ReadLine();
            if (hpFilter != "")
            {
                allCars = allCars.Where(car => car.hoursePower >= Int32.Parse(hpFilter)).ToList();
            }
            if (allCars.Count == 0) { Console.WriteLine("We have no cars with that amount of HP and that color :( "); }
            else
            {
                Console.WriteLine("There are " + allCars.Count + " of cars in our system with that color and that amount of HP");
            }

            Console.WriteLine("Do you want it to have over a specific fuel type? Write EV for electric, P for petrol or press enter for All types");
            var fuelFilter = Console.ReadLine();
            switch (fuelFilter.ToUpper())
            {
                case "EV":
                    ShowEVs(allCars);
                    break;
                case "P":
                    ShowPetrols(allCars); 
                    break;
                default:
                    ShowAllCars(allCars);
                    break;
            }






        }
        static void ShowEVs(List<Car> allCars)
        {
            var evCars = allCars.OfType<EVCar>().ToList();

            foreach (var evCar in evCars) { evCar.DisplayCar(); }
        }

        static void ShowPetrols(List<Car> allCars)
        {
            var petrolCars = allCars.OfType<PetrolCar>().ToList();

            foreach (var petrolCar in petrolCars) { petrolCar.DisplayCar(); }
        }

        static void ShowAllCars(List<Car> allCars)
        {
            foreach (var car in allCars) { car.DisplayCar(); }

        }

    }
}
