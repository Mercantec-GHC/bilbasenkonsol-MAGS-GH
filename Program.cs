using Class_Domain_Models;

namespace BilbasenKonsol
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allCars = new CreateVehicles().CreateListOfCars();

            Console.WriteLine("There are " + allCars.Count + " of cars in our system!");

            allCars = FilterColor(allCars);
            allCars = FilterMoreThanHP(allCars);

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
        static void ShowEVs(List<Vehicle> allCars)
        {
            var evCars = allCars.OfType<EVCar>().ToList();

            foreach (var evCar in evCars) { evCar.DisplayVehicle(); }
        }

        static void ShowPetrols(List<Vehicle> allCars)
        {
            var petrolCars = allCars.OfType<PetrolCar>().ToList();

            foreach (var petrolCar in petrolCars) { petrolCar.DisplayVehicle(); }
        }

        static void ShowAllCars(List<Vehicle> allCars)
        {
            foreach (var car in allCars) { car.DisplayVehicle(); }

        }

        static List<Vehicle> FilterColor(List<Vehicle> allCars)
        {

            Console.WriteLine("Do you want a specific color? Then write it here or press enter for all colors");
            var colorFilter = Console.ReadLine();
            if (colorFilter != "")
            {
                allCars = allCars.Where(car => car.color.ToUpper() == colorFilter.ToUpper()).ToList();
            }
            if (allCars.Count == 0) { Console.WriteLine("We have no cars with that color :( "); }
            else
            {
                Console.WriteLine("There are " + allCars.Count + " of cars in our system with that color!");
            }

            return allCars;
        }

        static List<Vehicle> FilterMoreThanHP(List<Vehicle> allCars)
        {
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
            return allCars;
        }

    }
}
