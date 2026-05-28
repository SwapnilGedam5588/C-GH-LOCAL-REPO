using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRACTISE
{
    internal class C_OOPS
    {
        //Practise of Access Modifiers

        public class AccessModifiers
        {
            public int publicVariable = 10; // Accessible from anywhere
            private int privateVariable = 20; // Accessible only within the class
            protected int protectedVariable = 30; // Accessible within the class and derived classes
            internal int internalVariable = 40; // Accessible within the same assembly

            public void Public()
            {
                Console.WriteLine("This is a public method.");
                Console.WriteLine("Public Variable: " + publicVariable);

            }

            internal void InternalMethod()
            {
                Console.WriteLine("This is an internal method.");
                Console.WriteLine("Internal Variable: " + internalVariable);
            }

            private void PrivateMethod()
            {
                Console.WriteLine("This is a private method.");
                Console.WriteLine("Private Variable: " + privateVariable);
            }

            protected void ProtectedMethod()
            {
                Console.WriteLine("This is a protected method.");
                Console.WriteLine("Protected Variable: " + protectedVariable);
            }
        }

        //Practise for Encapsulation / properties / inheritance / Polymorphism

        public class Person
        {
            protected string name = ""; //private field (initialized to avoid null)
            protected int age; //private field
            protected int personID; //private field

            public string Name //property
            {
                get { return name; }
                set { name = value; }

            }

            public int Age //property
            {
                get { return age; }
                set { age = value; }
            }

            public int PersonID
            {
                get { return personID; }
                set { personID = value; }

            }

            public void DisplayInfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("PersonID: " + personID);

            }

        }
        //Inheritance - Person2 class inherits from Person class and has additional properties for company name, salary, and nickname.
        public class Person2 : Person
        {
            double salary = 0.0;

            public string CompanyName { get; set; } = "";

            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public string NickName1 { get; set; } = "";

            public void DisplayPersonInfo()
            {
                Console.WriteLine("companyName: " + CompanyName);
                Console.WriteLine("Salary: " + Salary);
                Console.WriteLine("NickName1: " + NickName1);

            }
        }


        public class Employee
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public int? EmployeeID { get; set; }

            public void Show()
            {
                Console.WriteLine("Welcome to Employee method");
            }

        }

        //Multiple inheritance

        public class Cars
        {
            public string CarBrand = "";
            public string Model = "";
            public string color = "";
            public double Mileage = 0.0;
            public double Price = 0.0;

        }

        //Polymorphism static Polymorphism - Method overloading 

        //Method overloading without return type

        public class Sum
        {
            public int sumInteger1;
            public double sumInteger2;


            public void SumIntegers(int num1, int num2)
            {
                sumInteger1 = num1 + num2;
            }

            public void SumIntegers(int num2, int num1, double num3) //Different type, sequence and no. of parameters
            {
                sumInteger2 = num1 + num2 + num3;
            }

            public void DisplaySum()
            {
                Console.WriteLine("The result of integer SUM is :" + sumInteger1);
                Console.WriteLine("The result of integer SUM is :" + sumInteger2);
            }

        }
        //Polymorphism static Polymorphism - Method overloading with return type

        public class Aritmetics
        {
            public int num5 = 0;
            public int num6 = 0;
            public int divisionResult = 0;

            public static int Calculate(int num1, int num2)
            {
                return num1 + num2;

            }

            public static double Calculate(double num3, double num4)
            {
                return num3 - num4;
            }

            public static void Calculate()
            {
                Console.WriteLine("Enter the number num5 for division...");
                int num5 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number num6 for division...");
                int num6 = Convert.ToInt32(Console.ReadLine());

                int divisionResult = num5 / num6;
                Console.WriteLine("The divisionResult is : " + divisionResult);
            }

            public static char Calculate(char c1, char c2)
            {
                return (char)(c1 + c2);
            }

            public static string Calculate(string s1, string s2, int s3)
            {

                return s1 + s2 + s3;
            }
        }

        //inheritance for Animal Base class (Parent class)

        public class Animals
        {
            public string AnimalName { get; set; } = "";
            public string Animalcategory { get; set; } = "";

            public void Displayinfo()
            {
                Console.WriteLine($"AnimalName: {AnimalName} | Category: {Animalcategory}");

            }

            private void TypeofMammals1()

            {
                Console.WriteLine("Monotremes Mammals + Marsupial Mammals");

            }

            private void TypeofMammals2()

            {
                Console.WriteLine("Birds of Prey  + Songbirds ");

            }

            private void TypeofMammals3()

            {
                Console.WriteLine("Anura  + Caudata ");

            }

        }

        //Constructor practise

        //no-argument constructor

        public class Constructor
        {
            public Constructor()
            {
                Console.WriteLine("This is a no argument constructor calling");

            }

            static void Main(string[] args)
            {
                Constructor constructor = new Constructor();

                //This object belongs to default automatically constructor
                Sumint si = new Sumint();
                si.SumOnly();

            }

        }

        //This is by default automatially constructor called. no constructorr is created.
        public class Sumint
        {
            private int sum1 = 20;
            private int sum2 = 10;
            private int sumresult;

            public void SumOnly()
            {
                sumresult = sum1 + sum2;
                Console.WriteLine("The default constructor SumOnly result is " + sumresult);
            }
        }

        //Parameterized constructor

        public class Cats
        {
            public string? Name;
            public string? Category;
            public int? Age;
            public string? Color;
            public string Breed;
            public bool is_indoor;
            public bool is_neutered;
            public int energy_level;

            //constructor 
            public Cats()
            {
            }


            //parameterized constructor

            public Cats(string Name, string Category, int Age, string Color)
            {
                //this. --> points to current object, refers to the current object instance

                this.Name = Name;
                this.Category = Category;
                this.Age = Age;
                this.Color = Color;
            }

            //Parameterized constructor with method overloading and different parameters

            public Cats(string Breed, bool is_indoor, bool is_neutered, int energy_level)
            {
                this.Breed = Breed;
                this.is_indoor = is_indoor;
                this.is_neutered = is_neutered;
                this.energy_level = energy_level;
            }

        }

        //Class & objects

         internal class cars
         {

            //inside class members

            /*Inside it, you define:

            Data → fields, properties
            Behavior → methods
            Initialization → constructors
            Communication → events*/


            //class members 

            public string? CarName; //fields or DATA or Attributes

            public string? CarCategory; //fields or DATA or Attributes
            public int? CarAge { get; set; } //Properties (Encapusulation)

            public bool IsCarLicensed;//fields or DATA or Attributes


            public void carsinfo(string CarName, string CarCategory, bool IsCarLicensed) //constructors
            { 
                this.CarName = CarName;
                this.CarCategory = CarCategory;
                this.IsCarLicensed = IsCarLicensed;

            }

            public void DisplayInfo() //Methods or Functions or Behaviours
            {
                Console.WriteLine("The name of the care is : " + CarName);
                Console.WriteLine("The Car Category is : " + CarCategory);
                Console.WriteLine("The Car CarLicensed is : " + IsCarLicensed);

            }

         }

        //Variables

        internal class Variables
        {
            //Value type variables. Store actual data directly and in stack memory.Access using creating class object. Declared inside a class 

            public int x = 5;
            public double y = 5.5;
            public char c = 'd';
            public bool z = true;
            public string Text = "Hello";

            //instance variable (non-static fields).Declared inside a class but outside methods.Access using creating class object and assign value

            public string? EmployeeID;
            public int EmployeeAge;

            // static variables (class variables). Declared using the static keyword and Accessed using class name

            public static string? myText;
            public static int? Age;

            //Local variables. Declared inside a method, constructor, or block.Accessible only within that block.Must be initialized before use. called using object name and assign value

            public void DisplayInfo()
            {
                int x = 5;
                int y = 10;
                int sum = x + y;
                Console.WriteLine("The sum total is " + sum);
            
            }

            //constructor using return type. called using class name and assign value

            public int num1 = 0;
            public int num2 = 0;
            public double num3 = 0.0;
            public double num4 = 0.0;


            public static int Calculate(int num1, int num2)
            {
                return num1 + num2;

            }

            public static double Calculate(double num3, double num4)
            {
                return num3 - num4;
            }

        }

        //static constructor

        public class GeekStaticConst
        {
            //static constructor
            static GeekStaticConst()
            {
                Console.WriteLine("static constructor"); 
            }

            //Instance parameter constructor

            public GeekStaticConst(int i)
            {
                Console.WriteLine("Instance parameter constructor for i is : " + i);
            }

            //Temporary Method

            public string geek_details(string name, int id)
            {
                return "Name is" + name + " id is " + id;
            
            }
        }

        //Private constructor

        public class GeekPrivateConst
        {
            //private constructor

            private GeekPrivateConst()
            {
                Console.WriteLine("Private constructor");
            }

            // static field
            public static int count_geeks;

            //static method and increment static field
            public static int geeks_count()
            { 
                return ++count_geeks;  
            }
        }

        public class SingletonUtility
        {
            //static field
            public static int InstanceCount;

            //private field
            public string message;

            /// Static constructor - executes once when class is first accessed

            static SingletonUtility()
            {
                Console.WriteLine("1. Static constructor called (initializing static members)");
                InstanceCount = 0;

            }

            // Private constructor - prevents external instantiation

            private SingletonUtility()
            {
                Console.WriteLine("2. Private constructor called (internal instantiation)");
                this.message = "Created internally";
                InstanceCount++;
            }

            // Public static method to create/get instance (Singleton pattern)

            public static SingletonUtility GetInstance()
            { 
                Console.WriteLine("3. GetInstance() method called");
                return new SingletonUtility(); // Can call private constructor internally
            }

            // Public static method to display info
            public static void DisplayInfo()
            {
                Console.WriteLine($"4. Instance count: {InstanceCount}");
            }

        }

    }
}






