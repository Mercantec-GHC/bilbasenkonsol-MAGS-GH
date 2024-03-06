using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Domain_Models;

namespace BilbasenKonsol
{
    public class CreateCars
    {
        public List<Car> CreateListOfCars()
        {
            List<Car> AllCars = new List<Car>();
            // Creating more EV cars
            AllCars.Add(new EVCar
            {
                brand = "Nissan",
                model = "Leaf",
                year = 2023,
                color = "Silver",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "LED Headlights", "Automatic Emergency Braking" },
                batteryCapacity = 40,
                range = 250
            });

            AllCars.Add(new EVCar
            {
                brand = "Chevrolet",
                model = "Bolt",
                year = 2022,
                color = "White",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Lane Keep Assist", "Wireless Charging" },
                batteryCapacity = 60,
                range = 270
            });

            // Creating more Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "Honda",
                model = "Accord",
                year = 2023,
                color = "Black",
                hoursePower = 200,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Apple CarPlay", "Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Ford",
                model = "Fusion",
                year = 2024,
                color = "Gray",
                hoursePower = 180,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Blind Spot Monitoring", "Rear Cross Traffic Alert" },
                numberOfCylinders = 4
            });

            // Add more cars as needed...
            // More EV cars
            AllCars.Add(new EVCar
            {
                brand = "Volkswagen",
                model = "ID.4",
                year = 2023,
                color = "Green",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Adaptive Cruise Control", "Panoramic Sunroof" },
                batteryCapacity = 55,
                range = 260
            });

            AllCars.Add(new EVCar
            {
                brand = "Audi",
                model = "e-tron",
                year = 2024,
                color = "Orange",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Virtual Cockpit", "Matrix LED Headlights" },
                batteryCapacity = 80,
                range = 320
            });

            // More Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "BMW",
                model = "3 Series",
                year = 2024,
                color = "Silver",
                hoursePower = 250,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Wireless Charging", "Gesture Control" },
                numberOfCylinders = 6
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Mercedes-Benz",
                model = "C-Class",
                year = 2023,
                color = "Red",
                hoursePower = 220,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "MBUX Infotainment", "Active Parking Assist" },
                numberOfCylinders = 4
            });

            // Add more cars as needed...

            // More EV cars
            AllCars.Add(new EVCar
            {
                brand = "Porsche",
                model = "Taycan",
                year = 2023,
                color = "Black",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Porsche Communication Management", "Sport Chrono Package" },
                batteryCapacity = 93,
                range = 280
            });

            AllCars.Add(new EVCar
            {
                brand = "Rivian",
                model = "R1T",
                year = 2023,
                color = "Blue",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Gear Tunnel", "Camp Kitchen" },
                batteryCapacity = 135,
                range = 300
            });

            // More Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "Lexus",
                model = "ES",
                year = 2024,
                color = "White",
                hoursePower = 215,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mark Levinson Audio", "Heated Steering Wheel" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Acura",
                model = "TLX",
                year = 2023,
                color = "Gray",
                hoursePower = 272,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "AcuraWatch Safety Suite", "ELS Studio 3D Premium Audio" },
                numberOfCylinders = 6
            });

            // Add more cars as needed...
            // More EV cars
            AllCars.Add(new EVCar
            {
                brand = "Hyundai",
                model = "Kona Electric",
                year = 2023,
                color = "White",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Bluelink Connected Car Services", "Wireless Device Charging" },
                batteryCapacity = 64,
                range = 258
            });

            AllCars.Add(new EVCar
            {
                brand = "Kia",
                model = "Niro EV",
                year = 2024,
                color = "Black",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "UVO Link Infotainment System", "Smart Cruise Control with Stop & Go" },
                batteryCapacity = 64,
                range = 239
            });

            // More Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "Subaru",
                model = "Legacy",
                year = 2023,
                color = "Blue",
                hoursePower = 182,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Subaru EyeSight Driver Assist Technology", "Harman Kardon Audio System" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Mazda",
                model = "Mazda6",
                year = 2024,
                color = "Red",
                hoursePower = 187,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mazda Connect Infotainment System", "Advanced Smart City Brake Support" },
                numberOfCylinders = 4
            });

            // Add more cars as needed...
            // More EV cars
            AllCars.Add(new EVCar
            {
                brand = "Tesla",
                model = "Model Y",
                year = 2023,
                color = "Silver",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Autopilot", "Full Self-Driving Capability" },
                batteryCapacity = 75,
                range = 326
            });

            AllCars.Add(new EVCar
            {
                brand = "Ford",
                model = "Mustang Mach-E",
                year = 2024,
                color = "Yellow",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Ford Co-Pilot360", "B&O Sound System by Bang & Olufsen" },
                batteryCapacity = 98,
                range = 305
            });

            // More Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "Chevrolet",
                model = "Malibu",
                year = 2023,
                color = "Gray",
                hoursePower = 160,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment 3 System", "Wireless Apple CarPlay/Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Nissan",
                model = "Altima",
                year = 2024,
                color = "Brown",
                hoursePower = 188,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Nissan Safety Shield 360", "NissanConnect Services" },
                numberOfCylinders = 4
            });

            // Add more cars as needed...
            // More EV cars
            AllCars.Add(new EVCar
            {
                brand = "BMW",
                model = "iX",
                year = 2023,
                color = "Blue",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "BMW Operating System 8", "BMW Intelligent Personal Assistant" },
                batteryCapacity = 105,
                range = 300
            });

            AllCars.Add(new EVCar
            {
                brand = "Rimac",
                model = "C_Two",
                year = 2024,
                color = "Purple",
                hoursePower = 0,
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Rimac Driver Coach", "Rimac Performance Data Logger" },
                batteryCapacity = 120,
                range = 340
            });

            // More Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "Volvo",
                model = "S60",
                year = 2023,
                color = "White",
                hoursePower = 250,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Volvo Sensus Infotainment System", "Volvo Pilot Assist" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Infiniti",
                model = "Q50",
                year = 2024,
                color = "Silver",
                hoursePower = 300,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "INFINITI InTouch Dual HD Display System", "INFINITI InTouch Services" },
                numberOfCylinders = 6
            });

            // Add more cars as needed...
            // More EV cars
            AllCars.Add(new EVCar
            {
                brand = "Audi",
                model = "Q4 e-tron",
                year = 2024,
                color = "Gray",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Audi Virtual Cockpit", "Audi Pre Sense Front" },
                batteryCapacity = 82,
                range = 280
            });

            AllCars.Add(new EVCar
            {
                brand = "Mercedes-Benz",
                model = "EQB",
                year = 2023,
                color = "Red",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mercedes-Benz User Experience (MBUX)", "Mercedes me connect" },
                batteryCapacity = 66,
                range = 260
            });

            // More Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "Toyota",
                model = "Corolla",
                year = 2024,
                color = "Black",
                hoursePower = 169,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Toyota Safety Sense 2.0", "Apple CarPlay and Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Hyundai",
                model = "Elantra",
                year = 2023,
                color = "Silver",
                hoursePower = 147,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Hyundai SmartSense", "Wireless Device Charging" },
                numberOfCylinders = 4
            });

            // Add more cars as needed...
            // More EV cars
            AllCars.Add(new EVCar
            {
                brand = "Polestar",
                model = "2",
                year = 2023,
                color = "Gray",
                hoursePower = 0,
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Polestar Digital Key", "Polestar Connect" },
                batteryCapacity = 78,
                range = 270
            });

            AllCars.Add(new EVCar
            {
                brand = "Lucid",
                model = "Air",
                year = 2024,
                color = "White",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Lucid DreamDrive", "Space Concept Interior" },
                batteryCapacity = 113,
                range = 517
            });

            // More Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "Kia",
                model = "Optima",
                year = 2023,
                color = "Blue",
                hoursePower = 178,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Kia UVO Link", "Wireless Phone Charger" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Genesis",
                model = "G70",
                year = 2024,
                color = "Silver",
                hoursePower = 252,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Genesis Smart Sense", "Lexicon Premium Audio System" },
                numberOfCylinders = 6
            });

            // Add more cars as needed...
            // More EV cars
            AllCars.Add(new EVCar
            {
                brand = "Volkswagen",
                model = "ID.3",
                year = 2023,
                color = "Blue",
                hoursePower = 0,
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Volkswagen Car-Net", "Augmented Reality Head-Up Display" },
                batteryCapacity = 58,
                range = 263
            });

            AllCars.Add(new EVCar
            {
                brand = "Ford",
                model = "F-150 Lightning",
                year = 2024,
                color = "Silver",
                hoursePower = 0,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Ford BlueCruise", "Pro Power Onboard" },
                batteryCapacity = 110,
                range = 300
            });

            // More Petrol cars
            AllCars.Add(new PetrolCar
            {
                brand = "Audi",
                model = "A4",
                year = 2023,
                color = "Black",
                hoursePower = 201,
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Audi MMI Navigation Plus", "Audi Virtual Cockpit" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar
            {
                brand = "Chevrolet",
                model = "Camaro",
                year = 2024,
                color = "Red",
                hoursePower = 455,
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment 3", "Wireless Charging" },
                numberOfCylinders = 8
            });

            // Add more cars as needed...

            return AllCars;
        }

    }
}
