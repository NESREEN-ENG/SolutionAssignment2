class Program
{
    static void Main()
    {
        //1-Write a program that allows the user to enter a number then print it.

        #region Number1:
        /*
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();
        try
        {
           double number = Convert.ToDouble(userInput);

           // Print the entered number
           Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
           Console.WriteLine("Invalid input. Please enter a valid number.");
        }
         */
        #endregion


        //2-Write C# program that converts a string to an integer,
        //but the string contains non-numeric characters.
        //And mention what will happen 


        #region Number2:
        /*
        string input = "123abc";

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("Converted number: " + number);
        }
        else
        {
            Console.WriteLine("Error: The string contains non-numeric characters and cannot be converted to an integer.");
        }

         When Convert.ToInt32 encounters a string that cannot be
        fully interpreted as a numeric value, it throws a FormatException.
         This is because the method requires the entire
        string to be a valid representation of an integer.
        */
        #endregion


        //3-Write C# program that Perform a simple arithmetic
        //operation with floating-point numbers And mention what will happen

        #region Number3:
        /*
                     float num1 = 5.75f;
                     float num2 = 2.5f;
                     float sum = num1 + num2;
                     float difference = num1 - num2;
                     float product = num1 * num2;
                     float quotient = num1 / num2;
                     Console.WriteLine("First Number: " + num1);
                     Console.WriteLine("Second Number: " + num2);
                     Console.WriteLine("Sum: " + sum);
                     Console.WriteLine("Difference: " + difference);
                     Console.WriteLine("Product: " + product);
                     Console.WriteLine("Quotient: " + quotient);
                     Four mathematical operations will be applied and the result will be displayed
           */
        #endregion


        //4-Write C# program that Extract a substring from a given string.

        #region Number4:
        /*
        string originalString = "Hello, world!";
        int startIndex = 7; 
        int length = 5;     

        try
        {
            string extractedSubstring = originalString.Substring(startIndex, length);
            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Extracted Substring: " + extractedSubstring);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Error: The specified start index or length is out of range.");
        }
        */
        #endregion

        //5-Write C# program that Assigning one value type variable to
        //another and modifying the value of one variable and mention what
        //will happen

        #region Number5:
        /*
        int originalValue = 20;
        int copiedValue = originalValue;
        copiedValue = 40;
        Console.WriteLine("Original Value: " + originalValue);
        Console.WriteLine("Copied Value: " + copiedValue);

         initially, originalValue and copiedValue both have the value 20.
         When copiedValue is modified to 40, it only changes the value of copiedValue,
          while originalValue remains 20.
        */
        #endregion


        //6-Write C# program that Assigning one reference type variable to
        //another and modifying the object through one variable and mention
        //what will happen


        #region Number6:
        /*
                Person person1 = new Person { Name = "nesrin", Age = 30 };
                Person person2 = person1;
                person2.Name = "nade";
                person2.Age = 32;
                Console.WriteLine("Person 1: Name = " + person1.Name + ", Age = " + person1.Age);
                Console.WriteLine("Person 2: Name = " + person2.Name + ", Age = " + person2.Age);

            } }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }
        initial person1 points to an object with Name = "nesrin" and Age = 30. person is assigned the reference of person1, so both point to the same object.when modificationChanging person2.Name or person2.Age modifies the shared object.
        As a result, changes made through person2 are visible when accessing the object through person1.
             */
        #endregion

        // 7-Write C# program that take two string variables and
        // print them as one variable 

        #region Number7:
        /*
                Console.Write("Enter the first string: ");
                string firstString = Console.ReadLine();
                Console.Write("Enter the second string: ");
                string secondString = Console.ReadLine();
                string combinedString = firstString + secondString;
                Console.WriteLine("Combined String: " + combinedString);
        */
        #endregion

        // 8-Which of the following statements is correct about the C#.NET
        //code snippet given below?

        #region Number8:
        /*
        int d;
        d = Convert.ToInt32(!(30 < 20));
         Output= b)A value 1 will be assigned to d.
        */
        #endregion

        //9-Which of the following is the correct output for the C#
        //code given below?

        #region Number9:
        /*
        int d;
        Console.WriteLine(13 / 2 + " " + 13 % 2);
        Output = d)6 1 .
        */
        #endregion


        //10-What will be the output of the C# code given below?

        #region Number 10:
        /*
            int num = 1, z = 5;

               if (!(num <= 0)) 
               Console.WriteLine(++num + z++ + " " + ++z); 
                 else 
             Console.WriteLine(--num + z-- + " " + --z);
        output 7 7
        */

        #endregion
    }
}