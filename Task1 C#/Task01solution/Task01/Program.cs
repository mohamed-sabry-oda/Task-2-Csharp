using System;


namespace Task01
{
    internal class Program
    {
        static void Main()
        {
            #region problem1
            // problem 1 
            /*
             1-definition two variables
             2-sum the two variables
             3-then show
             */
            //int x = 10;
            //int y = 20;
            //int sum = x + y;
            //Console.WriteLine(sum);
            #endregion

            #region question1
            // question 1
            // comment == ctrl + k + c
            // uncomment == ctrl + k + u
            #endregion


            #region problem2
            // problem 2
            //code
            //int x = "10";
            //console.WriteLine(x + y);
            /* This line attempts to assign a string value ("10") to an integer variable (x)
             * the error in the code is y is undefined 
             * and capital c in console is small 
             */
            // fix error
            //int x = 10;
            //int y = 0;
            //Console.WriteLine(x + y);
            #endregion


            #region question2
            //question 2
            /*
            A runtime error occurs while the program is executing(running) 
            after it has been successfully compiled and is example of
                Division by Zero
            A logical error is a flaw in the program's design or algorithm 
            that causes it to produce incorrect or unexpected output,
             even though the program runs without crashing
             and is example of  Incorrect Formula / Algorithm
            */
            #endregion


            #region problem3
            // problem 3
            //Console.WriteLine("enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter your age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter your salary");
            //decimal salary = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Are you student");
            //string student = Console.ReadLine(); 
            #endregion

            #region question3
            //I explained the importance of following naming conventions like 
            //PascalCase in C#. These conventions are crucial for:
            //Readability and Understandability: Makes code easier to read and comprehend,
            //especially in large codebases or team environments.
            //Maintainability: Simplifies debugging, refactoring, and onboarding new developers.
            #endregion



            #region problem 4
            //Point P1 = new Point();
            //Point P2 = new Point();
            //Console.WriteLine(P1.x);//0
            //Console.WriteLine(P1.y);//0
            //P1.x = 15;
            //Console.WriteLine(P1.x);//15
            //P2 = P1;
            //Console.WriteLine(P2.x);//15
            #endregion


            #region question 4
            /*
             * Value Types:
             * Store their actual data directly.
             *Allocated primarily on the stack (for local variables) or inline within objects on the heap.
             *When assigned, a copy of the actual value is made.
             *        Examples: int, char, structs.
             *
             *Reference Types:
             *Store a reference (memory address) to where the actual data (the object) is stored.

             *The actual object data is allocated on the heap.

             *When assigned, the reference (memory address) is copied, meaning multiple variables can point to the same single object on the heap.

             *Examples: classes
             *
             *
             */


            #endregion

            #region problem5
            //int x = 15;
            //int y = 4;
            //int sum = x + y;
            //int diff = x - y;
            //int product = x * y;
            //int devision = x / y;
            //int remainder = x % y;
            //Console.WriteLine("sum is " + sum);
            //Console.WriteLine("difference is "  +diff);
            //Console.WriteLine("product is " +product);
            //Console.WriteLine("devision is "  +devision);
            //Console.WriteLine("remainder is "  +remainder);
            #endregion


            #region question 5
            //int a = 2, b = 7;
            //Console.WriteLine(a%b);// output 2
            #endregion


            #region problem 6
            //Console.WriteLine("enter nmuber");
            //int number = int.Parse(Console.ReadLine());
            //bool answer = number > 10 && number % 2 == 0 ? true : false;
            //Console.WriteLine(answer);
            #endregion

            #region question 6
            //&& (logical AND):The logical AND operator is used to combine two or more boolean expressions
            //example: true && false => false ,true && true => true
            //The entire expression connected by && will only evaluate to true 
            //if all of the individual expressions on both sides of the && are true.
            //If even one of the expressions is false, the entire && expression will be false

            //&(bitwise AND) :The bitwise AND operator works on the individual bits of its operands
            //example: 1&0 => 0 , 1&1=>1
            #endregion

            #region problem 7
            //Console.WriteLine("enter a double number");
            //double numberDouble = double.Parse(Console.ReadLine());
            ////Explicit conversion double to int 
            //int NumberInt = (int)numberDouble;
            //Console.WriteLine(NumberInt);
            ////Implicit conversion int to double
            //int NumberInt1 = 15;
            //double numberDouble1 = (double)NumberInt1;
            //Console.WriteLine(numberDouble1);
            #endregion


            #region question 7
            //Why is explicit casting required when converting a double to an int?
            //because it's a narrowing conversion that can cause loss of data and precision
            #endregion



            #region problem 8
            //Console.WriteLine("enter your age");
            //int age = int.Parse(Console.ReadLine());
            //string AgeStatus = age > 0 ? "AcceptableAge" : "UnacceptableAge";
            //Console.WriteLine(AgeStatus);
            #endregion


            #region question 8
            /*
             * a question asked about exceptions for invalid input and how to handle them.
             *The likely exceptions were identified as FormatException (for non-numeric input) 
             *and OverflowException (for numbers out of range).
             *handled with checked
             */
            #endregion


            #region problrm 9
            //int x = 10;
            //Console.WriteLine(x++); // print : 10   , x=11  is postfix
            //Console.WriteLine(++x);// print : 12 ,x=12 is prefix
            #endregion


            #region question 9
            //int x = 5;
            //int y = ++x + x++; // y = 6 + 6 = 12
            // ++x is prefix , ++x is postfix
            //Console.WriteLine(y);
            #endregion
            Console.ReadKey();
}
}
}
