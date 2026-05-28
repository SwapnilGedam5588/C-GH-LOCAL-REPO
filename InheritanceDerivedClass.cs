using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_PRACTISE.C_OOPS;

namespace C_PRACTISE
{
    internal class InheritanceDerivedClass
    {

        /*Practise for Inheritance inherit from BasicClass to EmployeeInheritance class in DerivedClass.cs and access the method of DerivedClass.cs in EmployeeInheritance class under
        BasicMethod.cs*/

        public class EmployeeInheritance : C_OOPS
        {   
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public int? EmployeeID { get; set; }
            public double salary { get; set; }

            public void Show()
            {
                Console.WriteLine("Welcome to Employee method");
            }

            public void DisplayEmployeeInfo()
            {
                Console.WriteLine("Employee ID: " + EmployeeID);
                Console.WriteLine("First Name: " + FirstName);
                Console.WriteLine("Last Name: " + LastName);
                Console.WriteLine("salary: " + salary);
            }

            public void CalculateSalary(double hoursWorked, double hourlyRate)
            {
                salary = hoursWorked * hourlyRate;
                Console.WriteLine("Calculated Salary: " + salary);
            }

        }

        public class Car : BasicClass
        {
            // initialize fields to avoid CS0649 warnings
            public string? CarBrand = "";
            public string? Model = "";
            public string? color = "";
            public double Mileage = 0.0;
            public double Price = 0.0;

            public void DisplayCarInfo()
            {
                Console.WriteLine("Car Brand: " + CarBrand);
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Mileage: " + Mileage);
                Console.WriteLine("Price: " + Price);
            }

            //Adding methods for different types of cars in the Cars class which is derived from BasicClass and access the method of BasicClass in Cars class under BasicMethod.cs

            public void BMW()
            {

                Console.WriteLine("This is a BMW car.");
            }

            public void Audi()
            {
                Console.WriteLine("This is an Audi car.");
            }

            public void Mercedes()
            {
                Console.WriteLine("This is a Mercedes car.");
            }

        }
        //car2 class inherit from car class in InheritanceDerivedClass
        public class car2 : InheritanceDerivedClass
        {
            public int CarID { get; set; }
            public int Year { get; set; }
            public string? Month { get; set; } = "";
            public double Volumne { get; set; } = 0.0;

            public int horsepower { get; set; }


            public void DisplayCarInfo2()
            {

                Console.WriteLine("Car ID: " + CarID);
                Console.WriteLine("Year: " + Year);
                Console.WriteLine("Month: " + Month);
                Console.WriteLine("Volume: " + Volumne);
                Console.WriteLine("Horsepower: " + horsepower);
            }
        }

        //Multiple inheritance from AnimalsMammals2 base parent class from AnimalsMammals2.cs class
        public class AnimalsMammals3 : AnimalsMammals2
        {
            public void Mammals3Characteristics()
            {
                DualLifeCycle();
                ColdBloodedEctothermic();

            }

            private static void DualLifeCycle()
            {
                Console.WriteLine("Amphibians lead a double life, starting in water as larvae with gills, then often moving to land as adults with lungs.");
            }

            private static void ColdBloodedEctothermic()
            {
                Console.WriteLine("Amphibians rely on external sources to regulate their body temperature, making them highly sensitive to environmental changes.");
            }


        }
        // Fix for CS1729: Call base constructor explicitly in WaterBorn constructors
        // Fix for CS8618: Make 'Breed' property nullable to avoid uninitialized non-nullable warning

        public class WaterBorn : Cats
        {
            public string? Name { get; set; }
            public string? Category { get; set; }
            public int? Age { get; set; }
            public string? Color { get; set; }
            public string? Breed { get; set; } // Changed to nullable
            public bool is_indoor { get; set; }
            public bool is_neutered { get; set; }
            public int energy_level { get; set; }

            public WaterBorn(string Name, string Category, int Age, string Color)
                : base() // Explicitly call base parameterless constructor
            {
                this.Name = Name;
                this.Category = Category;
                this.Age = Age;
                this.Color = Color;
            }

            public WaterBorn(string? Breed, bool is_indoor, bool is_neutered, int energy_level)
                : base() // Explicitly call base parameterless constructor
            {
                this.Breed = Breed;
                this.is_indoor = is_indoor;
                this.is_neutered = is_neutered;
                this.energy_level = energy_level;
            }
            //constructor 
            public WaterBorn()
            {
            }
        }
    }
}