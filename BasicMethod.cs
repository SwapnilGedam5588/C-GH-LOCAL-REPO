//using C_PRACTISE;
//using StringsPractise;
//using static C_PRACTISE.CopyElementsArray;
//using static StringsPractise.SwitchStatement;
using static C_PRACTISE.C_OOPS;






/*// Methods for Print hello and Name

HelloName hello = new HelloName();
hello.PrintMessage("John Mckenzi");
hello.PrintMessage("Ramesh Verma");

Methods for Print hello and Name by Loop
hello.PrintMessageByLoop("John Mckenzi");

//Methods for sum of two numbers

SumOfTwoNumbers sum = new SumOfTwoNumbers();
sum.num1 = 10;
sum.num2 = 20;
sum.CalculateSum1();
sum.CalculateSum2(15, 25);

//Methods for Division of two numbers

DivideNumbers divide = new DivideNumbers();
divide.Divide2Numbers(10, 5);
divide.Divide2Numbers(20, 10);

//Print specified operations result

Printresulroperations print = new Printresulroperations();
print.printoperations();

//method for swapping 2 numbers

Swap2Numbers swap = new Swap2Numbers();
swap.num1 = 10;
swap.num2 = 20;
swap.swapnumbers1();
swap.swapnumbers2();

//Method to 6. Multiply Three Numbers

//For 1st constructor()
Multiply3Numbers multiply = new Multiply3Numbers(2, 3, 6);

multiply.MultiplyNumbers();


//For 2nd constructor()
Console.WriteLine("The result constructor()02 of Multiply Three Numbers are : " + multiply.result);


//Method for 7. Arithmetic Operations

ArithmeticOperations operations = new ArithmeticOperations();
operations.OutputArithmeticOperations();

//Method using parameterize method
operations.OutputArithmeticOperations(25, 4);

// Method for 8. Multiplication Table

Multiply mult = new Multiply();
mult.OutputMultiply();


//method for 9. Average of Four Numbers

Average average = new Average();
average.Averageoutput();
average.Averageoutput1(100, 200, 300, 400);
average.Averageoutput2();
average.Averageoutput3();

//Method for 10. Specified Formula with Three Numbers

Formula formula = new Formula();
formula.ResultFormula();

//11. Print Age Message

Age age = new Age();

//Using parameterized method
age.Ageinput(25);



//Using default parameterized method
age.Ageinput1();
age.Ageinput1(30);
age.Ageinput1(10);

//12. Repeat Number in Rows

RepeatNumber RN = new RepeatNumber();
RN.RowsRepeat1();
RN.RowsRepeat2();

//13. Rectangle Pattern with Number

RectanglePattern RP = new RectanglePattern();
RP.ColumnsRows1();
RP.ColumnsRows2();

//14. Celsius to Kelvin and Fahrenheit

Temperature Temp = new Temperature();
Temp.CalculateTemperatureConversion();

//15. Remove Character by Index

RemoveCharacter RC = new RemoveCharacter();
RC.CharacterRemove();


//16.1.Swap First and Last Characters

SwapFirstLastCharacters FLC = new SwapFirstLastCharacters();
FLC.SwapCharactersName();
FLC.SwapCharactersLanguage();

////16.2. Swap 2nd and 2nd last Characters

SwapSecondCharacters SSC = new SwapSecondCharacters();
SSC.SwapCharactersName();

//17. Add First Character to Front and Back

AddCharacter AC = new AddCharacter();
AC.AddFirstCharacter();

// 18. Check Positive and Negative Pair

CheckPair CP = new CheckPair();
CP.CheckPairs();

//19. Sum or Triple Sum of Integers

SumTripleSum TripleSum = new SumTripleSum();
TripleSum.SumTripleSums();

//20. Absolute Difference or Double It

AbsoluteDifference AB = new AbsoluteDifference();
AB.DifferenceAbsolute();


//21. Check for 20 or Sum Equals 20

CheckSum20 CS = new CheckSum20();
CS.Checksum20();

//22. Check Within 20 of 100 or 200
//it is return type method so we need to store the result in boolean variable and print it without creating object of the
//class because it is static method

bool result = Checkdifference.CheckReturn();
Console.WriteLine("The result is : " + result);

// it is return type method so we need to store the result in boolean variable and print it with creating object of the class because it is not a static method

Checkdifference cd = new Checkdifference();
bool result1 = cd.CheckReturn1();
Console.WriteLine("The result is : " + result);

//23. Convert String to Lowercase

Lowercase lc = new Lowercase();
lc.ConvertToLowercase();

//24.1.Find Longest Word in String

Longestword lw = new Longestword();
lw.FindLongestWord();

//24.2. find total space in a text
Totalspace ts = new Totalspace();
ts.CountSpaces();

//25. Print Odd Numbers 1 to 99

OddNumbers od = new OddNumbers();
od.PrintOddNumbers();

//26. Sum of First 500 Primes 

SumofPrimes sp = new SumofPrimes();
sp.PrintSumofPrimes();

//Practise of Access Modifiers / properties/inheritance /Polymorphism

AccessModifiers AM = new AccessModifiers();
AM.Public();
AM.InternalMethod();
//AM.PrivateMethod(); //make method public to access this method
//AM.ProtectedMethod(); //make method public to access this method

//Practise for Encapsulation / properties
Person person = new Person();
person.Name = "John Mckenzi";
Console.WriteLine("The name of the person is : " + person.Name);
person.Age = 30;
Console.WriteLine("The age of the person is : " + person.Age);
person.PersonID = 12345;
Console.WriteLine("The age of the person is : " + person.PersonID);

Employee emp = new Employee();

emp.EmployeeID = 54321;
Console.WriteLine("The Employee ID is : " + emp.EmployeeID);
emp.FirstName = "Test";
Console.WriteLine("The Employee First Name is : " + emp.FirstName);
emp.LastName = "User";
Console.WriteLine("The Employee Last Name is : " + emp.LastName);

Console.WriteLine("The Employee Name is : " + emp.FirstName + " " + emp.LastName);


//Practise for Inheritance inherit from BasicClass to EmployeeInheritance class in DerivedClass.cs and access the method of BasicClass in EmployeeInheritance class

EmployeeInheritance Ei = new EmployeeInheritance();
Ei.FirstName = "John";
Ei.LastName = "Mckenzi";
Ei.EmployeeID = 12345;
Ei.salary = 750;
Ei.DisplayEmployeeInfo();
Ei.CalculateSalary(40, 15);

//Inheritance - Person2 class inherits from Person class and has additional properties for company name, salary, and nickname.

Person2 P2 = new Person2();
P2.Name= "Ram";
P2.Age = 30;
P2.PersonID = 54321;
P2.DisplayInfo();


P2.CompanyName = "Test Company";
P2.Salary = 500;
P2.NickName1 = "Tester";
P2.DisplayPersonInfo();

//Multiple inheritance with Cars

Cars car = new Cars();

car.CarBrand = "BMW";
car.Model = "X5";
car.color = "Black";
car.Mileage = 15000;
car.Price = 50000;
car.DisplayCarInfo();
car.BMW();

car.CarBrand = "Audi";
car.Model = "A6";
car.color = "White";
car.Mileage = 20000;
car.Price = 45000;
car.DisplayCarInfo();
car.Audi();

car.CarBrand = "Mercedes";
car.Model = "C-Class";
car.color = "Silver";
car.Mileage = 18000;
car.Price = 55000;
car.DisplayCarInfo();
car.Mercedes();

//car2 class inherit from car class in InheritanceDerivedClass

car2 car2 = new car2();
car.BMW();
car.CarBrand = "BMW";
car.Model = "X5";
car.color = "Black";
car.Mileage = 15000;
car.Price = 50000;
car.DisplayCarInfo();
car2.CarID = 12345;
car2.Year = 2020;
car2.Month = "January";
car2.Volumne = 2.5;
car2.horsepower = 35;
car2.DisplayCarInfo2();

car.Audi();
car.CarBrand = "Audi";
car.Model = "A6";
car.color = "White";
car.Mileage = 20000;
car.Price = 45000;
car.DisplayCarInfo();
car2.CarID = 12345;
car2.Year = 2020;
car2.Month = "January";
car2.Volumne = 2.5;
car2.horsepower = 35;
car2.DisplayCarInfo2();

car.Mercedes();
car.CarBrand = "Mercedes";
car.Model = "C-Class";
car.color = "Silver";
car.Mileage = 18000;
car.Price = 55000;
car.DisplayCarInfo();
car2.CarID = 12345;
car2.Year = 2020;
car2.Month = "January";
car2.Volumne = 2.5;
car2.horsepower = 35;
car2.DisplayCarInfo2();

//Methods for Polymorphism method overloading without return types

Sum sum = new Sum();
sum.SumIntegers(10,5);
sum.SumIntegers(50,10,5.0);
sum.DisplaySum();

//Methods for Polymorphism method overloading with return types

// With the correct static method call:
int sum1 = Aritmetics.Calculate(50, 10);
Console.WriteLine("The sum of integers  is: " + sum1);

double difference = Aritmetics.Calculate(50.25f, 20.25f);
Console.WriteLine("The double difference is " + difference);

Aritmetics.Calculate();

char c3 = Aritmetics.Calculate('D', 'e');
Console.WriteLine("The char c3 is : " + c3 );

string StringSum = Aritmetics.Calculate("Hello !", "Swapnil", 23);
Console.WriteLine("The stringsum is c3 is : " + StringSum);

// Method for multiple inheritance

AnimalsMammals1 AM1 = new AnimalsMammals1();

AM1.AnimalName = "Lepords ";
AM1.Animalcategory = "Mammals";
Console.WriteLine("Animal Name" + AM1.AnimalName + "Animalcategory" + AM1.Animalcategory);

AM1.AnimalName = "Elephants ";
AM1.Animalcategory = "Mammals";


AnimalsMammals2 AM2 = new AnimalsMammals2();
AM2.AnimalName = "Diurnal Birds of Prey";
AM2.Animalcategory = "Accipitriformes";

Console.WriteLine("Animal Name" + AM1.AnimalName + "Animalcategory" + AM1.Animalcategory);


AM1.Mammals1Characteristics();
AM1.Displayinfo();


AM2.AnimalName = "Waterfowl Birds";
AM2.Animalcategory = "Anseriformes";


Console.WriteLine("Animal Name" + AM2.AnimalName + "Animalcategory" + AM2.Animalcategory);

AM2.Mammals2Characteristics();
AM2.Displayinfo();

AnimalsMammals3 AM3 = new AnimalsMammals3();
AM3.AnimalName = "Frogs and Toads";
AM3.Animalcategory = "Anura";

Console.WriteLine("Animal Name" + AM2.AnimalName + "Animalcategory" + AM2.Animalcategory);

AM3.Mammals3Characteristics();
AM3.Displayinfo();*/

//Constructor practise

//Parameterized constructor


Cats cat = new Cats("Tiger", "Mammals", 10, "Black");

// Fix for CS0119, CS1002, CS1022: Use the instance properties of the 'cat' object, not the type names 'Name' and 'Category'.
// Also, correct the string interpolation syntax.

Cats cats1 = new Cats("Tiger", "Mammal", 15, "Yello");
Console.WriteLine($"Name of cats is {cats1.Name} , Category of cat is {cats1.Category}, age of the cate is {cats1.Age}, color of the fur is {cats1.Color}");

Cats cats2 = new Cats("Lions", "Mammal",12, "Mix");
Console.WriteLine($"Name of cats is {cats2.Name} and Category of cat is {cats2.Category}, age of the cate is {cats2.Age}, color of the fur is {cats2.Color}");

Cats cats3 = new Cats("Cat", false, true, 10);
Console.WriteLine($"Breed of cats is {cats3.Breed} and Category of cat is {cats3.is_indoor}, age of the cate is {cats3.is_neutered}, color of the fur is {cats3.energy_level}");

























