namespace C_PRACTISE
{
    internal class BasicClass
    {

        // Print hello and Name

        public class HelloName
        {

            public void PrintMessage(string name)
            {
                Console.WriteLine("Hello! My name is John.");
                Console.WriteLine("Hello!" + name + " Nice to see you ");
            }

            public void PrintMessageByLoop(string name)
            {

                for (int i = 0; i < 2; i++)
                {

                    Console.WriteLine("Hello! My name is ." + name);
                }

            }
        }

        //sum of two numbers

        public class SumOfTwoNumbers
        {
            public int num1 = 0;
            public int num2 = 0;
            public int num3;
            public void CalculateSum1()
            {
                num3 = num1 + num2;
                Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + num3);
            }

            public void CalculateSum2(int a, int b)
            {
                num3 = a + b;
                Console.WriteLine("The sum of " + a + " and " + b + " is: " + num3);
            }
        }

        // Division of two numbers

        public class DivideNumbers
        {

            public void Divide2Numbers(int num1, int num2)
            {
                int num3 = num1 / num2;
                Console.WriteLine("The division of " + num1 + " and " + num2 + " is: " + num3);
            }
        }

        //Print the result of print the result of the specified operations

        /*Order of Operations
         Here are some common operators in C++, from highest to lowest priority:
        () - Parentheses
        *, /, % - Multiplication, Division, Modulus
        +, - - Addition, Subtraction
        >, <, >=, <= - Comparison
        ==, != - Equality
        && - Logical AND
        || - Logical OR
        = - Assignment*/


        public class Printresulroperations
        {

            public void printoperations()
            {
                Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);//3
                Console.WriteLine(14 + -4 * 6 / 11);//12
                Console.WriteLine((35 + 5) % 7);//5
                Console.WriteLine(-1 + 4 * 6);//23
            }
        }

        // 5. Swap Two Numbers

        public class Swap2Numbers
        {
            public int num1;
            public int num2;
            public int temp;

            public void swapnumbers1()
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
                Console.WriteLine("After swapping: num1 = " + num1 + ", num2 = " + num2 + ", temp = " + temp);
            }

            //prompt to the user to enter two numbers and swap them without using a temporary variable

            public void swapnumbers2()
            {
                Console.WriteLine("Enter the first number i.e. num1:");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number i.e. num2:");
                num2 = Convert.ToInt32(Console.ReadLine());

                temp = num1;
                num1 = num2;
                num2 = temp;
                Console.WriteLine("After swapping num1 number is:" + num1);
                Console.WriteLine("After swapping num2 number is:" + num2);

                Console.ReadLine();

            }
        }

        // 6. Multiply Three Numbers

        public class Multiply3Numbers
        {

            public int num1;
            public int num2;
            public int num3;

            public int result;

            public int number1;
            public int number2;
            public int number3;

            public void MultiplyNumbers()
            {

                Console.WriteLine("Enter the first number i.e. num1");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number i.e. num2");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the third number i.e. num3");
                num3 = Convert.ToInt32(Console.ReadLine());

                result = num1 * num2 * num3;
                Console.WriteLine("The result of Multiply Three Numbers are: " + result);

            }

            //Using constructor()1 to initialize the values of num1, num2, and num3 and calculate the result of multiplying three numbers
            public Multiply3Numbers(int Num1, int Num2, int Num3)
            {
                num1 = Num1;
                num2 = Num2;
                num3 = Num3;

                result = num1 * num2 * num3;
                Console.WriteLine("The result constructor()01 of Multiply Three Numbers are : " + result);
            }

            //Using constructor()2 to initialize the values of number1, number2, and number3 and calculate the result of multiplying three numbers
            public Multiply3Numbers()
            {
                number1 = 2;
                number2 = 3;
                number3 = 3;

                result = num1 * num2 * num3;
            }

        }

        //7. Arithmetic Operations
        public class ArithmeticOperations
        {
            internal int number1;
            internal int number2;
            internal int Result;


            internal void OutputArithmeticOperations()
            {
                Console.WriteLine("Input the first number: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input the 2nd number: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                //Addition
                Result = number1 + number2;
                Console.WriteLine("The addition of 2 numbers is : " + Result);

                //subtraction
                Result = number1 - number2;
                Console.WriteLine("The subtraction of 2 numbers is : " + Result);

                //multiplying 
                Result = number1 * number2;
                Console.WriteLine("The multiplying of 2 numbers is : " + Result);

                //division
                Result = number1 / number2;
                Console.WriteLine("The division of 2 numbers is : " + Result);

                //modulas
                Result = number1 % number2;
                Console.WriteLine("The modulas of 2 numbers is : " + Result);

            }

            //Using method parameter to perform arithmetic operations

            internal void OutputArithmeticOperations(int number1, int number2)
            {
                //Addition
                Result = number1 + number2;
                Console.WriteLine("The addition of 2 numbers is : " + Result);

                //subtraction
                Result = number1 - number2;
                Console.WriteLine("The subtraction of 2 numbers is : " + Result);

                //multiplying 
                Result = number1 * number2;
                Console.WriteLine("The multiplying of 2 numbers is : " + Result);

                //division
                Result = number1 / number2;
                Console.WriteLine("The division of 2 numbers is : " + Result);

                //modulas
                Result = number1 % number2;
                Console.WriteLine("The modulas of 2 numbers is : " + Result);
            }

        }

        //8. Multiplication Table

        public class Multiply
        {
            internal int startNumber;
            public int result;

            internal void OutputMultiply()
            {
                Console.WriteLine("Please enter the starting number to multiply ");
                startNumber = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= 10; i++)
                {
                    result = startNumber * i;
                    Console.WriteLine("The multiplication of the table is {0} * {1} = {2}", startNumber, i, result);
                }
            }

        }

        //9. Average of Four Numbers

        public class Average
        {

            public int firstnum;
            public int secondnum;
            public int thirdnum;
            public int fourthnum;

            public double average;

            public int sum = 0;
            public int count = 5;
            int i = 0;


            //General 
            public void Averageoutput()
            {
                Console.WriteLine("Please enter the first number: ");
                firstnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                secondnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the third number: ");
                thirdnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the fourth number: ");
                fourthnum = Convert.ToInt32(Console.ReadLine());

                average = (firstnum + secondnum + thirdnum + fourthnum) / 4.0;
                Console.WriteLine("The avergae of 4 numbers is : " + average);

            }

            //Using method parameter
            public void Averageoutput1(int firstnum, int secondnum, int thirdnum, int fourthnum)
            {

                Console.WriteLine("Please enter the first number: ");
                firstnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                secondnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the third number: ");
                thirdnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the fourth number: ");
                fourthnum = Convert.ToInt32(Console.ReadLine());


                average = (firstnum + secondnum + thirdnum + fourthnum) / 4.0;
                Console.WriteLine("The avergae of 4 numbers is : " + average);

            }
            //Using loop's

            public void Averageoutput2()
            {

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Number " + (i + 1) + " : ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    sum += num;
                }

                average = (double)sum / count;
                Console.WriteLine("The average of 5 numbers is: " + average);
            }

            public void Averageoutput3()
            {


                while (i < count)
                {
                    Console.WriteLine("Number " + (i + 1) + " : ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    sum += num;
                    i++;
                }
                average = (double)sum / count;
                Console.WriteLine("The average of 5 numbers is: " + average);
            }
        }

        //10. Specified Formula with Three Numbers

        public class Formula
        {

            public int x, y, z;
            public int result1;
            public int result2;

            internal void ResultFormula()
            {
                Console.WriteLine("Enter the value for x");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value for y");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value for z");
                z = Convert.ToInt32(Console.ReadLine());

                result1 = (x + y) * z;
                Console.WriteLine("The (x + y) * z is : " + result1);

                result2 = (x * y) + (y * z);
                Console.WriteLine("The (x*y) + (y*z) is : " + result2);

            }

        }

        //11. Print Age Message

        public class Age
        {
            public int age;

            //Using parameterized method
            public void Ageinput(int fage)
            {
                age = fage;
                Console.WriteLine("Enter the input age of a person");
                fage = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ageinput - Hey! seeing You look older than " + age);
            }

            //Using default parameterized method

            public void Ageinput1(int fage = 25)
            {
                Console.WriteLine("Ageinput1 - Hey! seeing You look older than " + fage);
            }
        }

        //12. Repeat Number in Rows

        public class RepeatNumber
        {
            internal int digit;

            internal void RowsRepeat1()
            {
                Console.WriteLine("Enter the input number digit");
                digit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(+digit + " " + digit + " " + digit + " " + digit);
                Console.WriteLine("\n" + digit + +digit + digit + digit + digit);
                Console.WriteLine("{0} {0} {0} {0}", +digit);
                Console.WriteLine("{0}{0}{0}{0}", +digit);
            }


            internal void RowsRepeat2()
            {
                Console.WriteLine("Enter the input number digit");
                digit = Convert.ToInt32(Console.ReadLine());

                //Part A - 25 25 25 25

                Console.Write(digit);
                Console.Write(" ");

                Console.Write(digit);
                Console.Write(" ");

                Console.Write(digit);
                Console.Write(" ");

                Console.Write(digit);
                Console.Write(" ");
                Console.Write("\n");


                //Part B - 25252525

                Console.Write(digit);
                Console.Write(digit);
                Console.Write(digit);
                Console.Write(digit);
                Console.WriteLine();

                //Part C- 25 25 25 25
                Console.WriteLine("{0} {0} {0} {0}", digit);

                //Part D -25252525
                Console.WriteLine("{0}{0}{0}{0}", digit);
            }
        }

        //13. Rectangle Pattern with Number

        public class RectanglePattern
        {
            public int digit;

            public int rows = 0;

            public void ColumnsRows1()
            {
                Console.WriteLine("Enter the input digit");
                digit = Convert.ToInt32(Console.ReadLine());

                //For top rows
                Console.WriteLine("{0}{0}{0}", digit);

                //for rows
                Console.WriteLine("{0} {0}", digit);
                Console.WriteLine("{0} {0}", digit);
                Console.WriteLine("{0} {0}", digit);

                //For bottom rows
                Console.WriteLine("{0}{0}{0}", digit);
            }

            public void ColumnsRows2()
            {
                Console.WriteLine("Enter the input digit");
                digit = Convert.ToInt32(Console.ReadLine());

                //Total 5 rows

                for (int rows = 1; rows <= 5; rows++)
                {
                    if (rows == 1 || rows == 5)
                    {
                        Console.WriteLine("{0}{0}{0}", digit);

                    }
                    else //// Middle rows (2,3,4) - spaced
                    {
                        Console.WriteLine("{0} {0}", digit);
                    }
                }
            }

            //14. Celsius to Kelvin and Fahrenheit

            public class Temperature
            {
                public void CalculateTemperatureConversion()
                {
                    Console.WriteLine("Enter the temperature in celsius");
                    double celsius = Convert.ToDouble(Console.ReadLine());


                    //Celsius to Kelvin(K)
                    double Kelvin = celsius + 273.15;

                    //Celsius to Fahrenheit(F)
                    double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;


                    Console.WriteLine($"Celsius: {celsius}°C");
                    Console.WriteLine($"Kelvin: {Kelvin:F2} K");
                    Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");

                }
            }

            //15. Remove Character by Index

            public class RemoveCharacter
            {
                public string Name = "w3resource";
                public int indextoremove = 1;


                public void CharacterRemove()
                {
                    //Access the character in the string
                    Console.WriteLine(Name[1]);

                    //Index of method
                    Console.WriteLine(Name.IndexOf("3"));

                    string result = Name.Remove(indextoremove, 1);
                    Console.WriteLine($"After removing character at index {indextoremove}: {result}");

                }
            }


            //16.1. Swap First and Last Characters


            public class SwapFirstLastCharacters
            {
                public string Name = "w3resource";
                public string Language = "Python";

                public void SwapCharactersName()
                {
                    //Access the first and last character in the string
                    Console.WriteLine("The total length of Name is : " + Name.Length);
                    Console.WriteLine("The first character index number is : " + Name[0]);
                    Console.WriteLine("The last character index number is : " + Name[Name.Length - 1]); //calculates the last index (11-1=10), accessing 'e'

                    //Swap the first and last characters
                    char firstChar = Name[0]; //w
                    char lastChar = Name[Name.Length - 1]; //e

                    string middlePart = Name.Substring(1, Name.Length - 2);
                    string result = lastChar + middlePart + firstChar;

                    Console.WriteLine($"After swapping first and last characters: {result}");
                }

                public void SwapCharactersLanguage()
                {
                    //Access the first and last characters in string language with total length

                    Console.WriteLine("The total length of string Language is :" + Language.Length);
                    Console.WriteLine("The first character index number for language is :" + Language[0]);
                    Console.WriteLine("The last character index number for languageis :" + Language[Language.Length - 1]);

                    //swap first and last characters in string language

                    char firstchar = Language[0]; //P
                    char lastchar = Language[Language.Length - 1]; //n
                    string middlepart = Language.Substring(1, Language.Length - 2);
                    string result = lastchar + middlepart + firstchar;

                    Console.WriteLine($"After swapping first and last characters in string language is : {result}");
                }
            }


            //16.2. Swap 2nd and 2nd Last Characters


            public class SwapSecondCharacters
            {
                public string Name = "w3resource";
                public string Language = "Python";

                public void SwapCharactersName()
                {
                    //Access the first and last character in the string
                    Console.WriteLine("The total length of Name is : " + Name.Length);
                    Console.WriteLine("The second character index number is : " + Name[1]);
                    Console.WriteLine("The second last character index number is : " + Name[Name.Length - 2] + "'"); //calculates the second last index (11-2=8), accessing 'c'

                    //Swap the first and last characters
                    char firstChar = Name[1]; //3
                    char lastChar = Name[Name.Length - 2]; //c

                    string startPart = Name.Substring(0, 2);
                    string middlePart = Name.Length > 4 ? Name.Substring(2, Name.Length - 4) : "";  // "resou"
                    string endPart = Name.Substring(Name.Length - 1);     // "e"

                    // build result and print to avoid "assigned but never used" warning
                    string result = startPart[0] + lastChar + middlePart + firstChar + endPart;
                    Console.WriteLine($"After swapping second and second-last characters: {result}");
                }


                //17. Add First Character to Front and Back


                public class AddCharacter
                {
                    public string input = "The quick brown fox jumps over the lazy dog.";

                    public void AddFirstCharacter()
                    {
                        //Access the first character in the string
                        Console.WriteLine("The total length of input string is : " + input.Length);
                        Console.WriteLine("The first character index number is : " + input[0]);

                        //Add the first character to the front and back of the string
                        char firstChar = input[0]; //T
                        string result = firstChar + input + firstChar;
                        Console.WriteLine($"After adding the first character to the front and back: {result}");
                    }

                }

                //18. Check Positive and Negative Pair

                public class CheckPair
                {
                    internal int num1;
                    internal int num2;

                    internal void CheckPairs()
                    {
                        Console.WriteLine("Enter the first number:");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the second number:");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        /*if((num1 <0 && num2 > 0) || (num1 > 0 && num2 < 0))
                        { 
                            Console.WriteLine("The pair is positive and negative.");
                        }*/

                        if (num1 < 0 && num2 < 0)
                        {
                            Console.WriteLine("The pair is both positive or both negative.");
                        }
                        else if (num1 > 0 && num2 > 0)
                        {
                            Console.WriteLine("The pair is both positive or both negative.");

                        }
                        Console.WriteLine("The pair includes zero.");

                    }

                    //19. Sum or Triple Sum of Integers

                    public class SumTripleSum
                    {
                        internal int num1;
                        internal int num2;
                        internal int sum;
                        internal int triplesum;

                        internal void SumTripleSums()
                        {
                            Console.WriteLine("Enter the first number:");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the second number:");
                            num2 = Convert.ToInt32(Console.ReadLine());

                            if (num1 != num2)
                            {
                                sum = num1 + num2;
                                Console.WriteLine("The sum of the two numbers is: " + sum);
                            }
                            else if (num1 == num2)
                            {
                                sum = num1 + num2;
                                triplesum = 3 * sum;
                                Console.WriteLine("The sum is triple because both numbers are equal. Triple Sum: " + triplesum);

                            }
                        }
                    }

                    //20. Absolute Difference or Double It

                    public class AbsoluteDifference
                    {
                        public int number1;
                        public int number2;
                        public int AbsoluteDiff;


                        public void DifferenceAbsolute()
                        {
                            Console.WriteLine("Enter the number1 number:");
                            number1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the number2 number:");
                            number2 = Convert.ToInt32(Console.ReadLine());

                            AbsoluteDiff = Math.Abs(number1 - number2);
                            Console.WriteLine("The absolute difference is: " + AbsoluteDiff);

                            if ((number1 > number2))
                            {

                                AbsoluteDiff *= 2;
                                Console.WriteLine("The absolute difference is doubled: " + AbsoluteDiff);

                            }
                        }

                        //21. Check for 20 or Sum Equals 20

                        internal class CheckSum20
                        {
                            internal int num1;
                            internal int num2;
                            internal int sum;

                            internal void Checksum20()
                            {
                                Console.WriteLine("Enter the number1 number:");
                                num1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter the number2 number:");
                                num2 = Convert.ToInt32(Console.ReadLine());

                                /*if((num1==20 || num2== 20) || (num1 + num2 == 20))
                                { 
                                    Console.WriteLine("The result is true because either one of the numbers is 20 or their sum equals 20.");
                                }
                                else
                                {
                                    Console.WriteLine("The result is false because neither of the numbers is 20 nor their sum equals 20.");

                                }*/

                                //convert string to boolean
                                bool result = ((num1 == 20 || num2 == 20) || (num1 + num2 == 20));
                                Console.WriteLine(result ? "true" : "false");

                            }

                        }

                        //22. Check Within 20 of 100 or 200
                        //100+20=120 or 100-20=80,
                        //200+20=220 or 200-20=180


                        public class Checkdifference
                        {
                            internal int inputNumber;

                            public static bool CheckReturn() //remove static to access by object of the class
                            {
                                Console.WriteLine("Enter the number1 value : ");
                                int inputNumber = Convert.ToInt32(Console.ReadLine());

                                int diff100 = Math.Abs(inputNumber - 100);
                                int diff200 = Math.Abs(inputNumber - 200);


                                // Check if within 20 of 100 or 200
                                bool result = (diff100 <= 20) || (diff200 <= 20);
                                return result;
                            }

                        }

                        //23. Convert String to Lowercase

                        public class Lowercase
                        {
                            internal string? input;
                            public string? lowercase;

                            public void ConvertToLowercase()
                            {
                                Console.WriteLine("Enter the input string : ");
                                input = Console.ReadLine() ?? string.Empty;

                                // safe conversion: coalesce before calling instance method
                                lowercase = input.ToLowerInvariant();
                                Console.WriteLine("The lowercase version of the input string is : " + lowercase);
                            }
                        }

                        // 24.1. Find Longest Word in String

                        public class Longestword
                        {
                            internal string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
                            public string word = "";
                            public int ctr = 0;

                            public void FindLongestWord()
                            {
                                //Breaks the sentence into individual words and stores them in an array (list) called words.

                                /*Split() cuts the string wherever it finds a space " "

                                new[] { " " } tells it to cut on spaces

                                StringSplitOptions.None handles multiple spaces properly

                                Result: words[0] = "Write", words[1] = "a", words[2] = "C#", etc.*/

                                int totalLength = line.Length; //total length of the string line is 77 characters
                                Console.WriteLine("The total length of the string line is : " + totalLength);

                                string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

                                foreach (String s in words)
                                {
                                    if (s.Length > ctr)
                                    {
                                        ctr = s.Length;
                                        word = s;
                                    }
                                }
                                Console.WriteLine(word);  // Outputs: following
                            }
                        }

                        //24.2. find total space in a text

                        public class Totalspace
                        {

                            internal string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
                            internal int spacecounter = 0;

                            internal void CountSpaces()
                            {
                                /* int spaceCount = line.Length - line.Replace(" ", "").Length;*/

                                foreach (char c in line)

                                {
                                    if (c == ' ')
                                    {
                                        spacecounter++;
                                    }
                                }
                                Console.WriteLine("Total no of spaces is : " + spacecounter);

                                /* 
                                 for (int c = 0; c < line.Length; c++)
                                {
                                    if (line[c] == ' ')
                                    {
                                        spacecounter++;
                                    }

                                }*/


                            }
                        }

                        //25. Print Odd Numbers 1 to 99

                        public class OddNumbers
                        {
                            public int number;

                            public void PrintOddNumbers()
                            {
                                Console.WriteLine("Enter the numbers you want to print.. : ");
                                number = Convert.ToInt32(Console.ReadLine());

                                for (number = 1; number < (99 + 1); number++)
                                {
                                    if (number % 2 != 0)
                                    {
                                        Console.WriteLine(number);

                                    }

                                }

                            }
                        }

                        //26.  Sum of First 500 Primes

                        public class SumofPrimes
                        {
                            public int count = 0; // Counts how many prime numbers found. Tracks how many prime numbers are found
                            public int Number = 2; // Number to check for prime. Current number being checked
                            public int sum = 0; // Stores sum of prime numbers. Stores total sum of primes

                            public void PrintSumofPrimes()
                            {
                                //counting prime numbers until we find 50 primes

                                while (count < 10)
                                {
                                    bool isPrime = true;

                                    //check if the number is prime

                                    for (int i = 2; i <= Math.Sqrt(Number); i++)
                                    {
                                        if (Number % i == 0)
                                        {
                                            isPrime = false;
                                            break; //exit the loop if number is not prime
                                        }
                                    }
                                    //if prime , add to sum and increment count
                                    if (isPrime)
                                    {
                                        sum += Number;
                                        count++;

                                        Console.WriteLine("Prime Count: " + count + " Prime Number: " + Number + " Current Sum: " + sum);
                                    }
                                    Number++; //move to the next number to check
                                }
                                Console.WriteLine("\nFinal Sum of First 10 Prime Numbers = " + sum);
                            }
                        }

                    }

                }
            }
        }
    }
}
            
        
    

