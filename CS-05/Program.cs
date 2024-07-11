namespace CS_05
{
    internal class Program
    {

        #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        static void Fun1(int x)
        {
            x = x + 10;
        }


        static void Fun2(ref int y)
        {
            y = y + 10;
        }



        #endregion

        #region  2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        static void PassingByValue1(int[] arr)
        {
            arr[0] = 1000;
            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        static void PassingByValue2(ref int[] arr)
        {
            arr[0] = 1000;
            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        #endregion

        #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers  

        public static (int, int) Calculate(int n1, int n2, int n3, int n4)
        {
            int sum = n1 + n2;
            int sub = n3 - n4;
            return (sum, sub);
        }


        #endregion

        #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

        public static void DigitsSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine($"the sum of digits of Number = {sum}");


        }


        #endregion

        #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:  

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {

                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;

        }


        #endregion

        #region  6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        public static void MinMaxArray(int[] array, ref int min, ref int max)

        {
            // ex:   1 2 3 4

            min = array[0]; // 1
            max = array[0]; // 2 / 3 / then ->  4 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {

                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }

            }

        }

        #endregion


        #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

        public static void Factorial(long number)
        {

            if (number > 0)
            {
                long result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                Console.WriteLine($"factorial of {number}  = {result}");
            }
        }


        #endregion



        #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter.


        public static void ChangeChar(ref string letter, int position, char c)
        {
            letter = letter.Remove(position, 1);
            letter = letter.Insert(position, c.ToString());
        }


        #endregion



        static void Main(string[] args)
        {

            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //int x = 10;
            //Fun1(x);
            //Console.WriteLine(x);

            /* value of X will be not affected because function take a copy the the value not the reference   */

            //int y = 10;
            //Fun2(ref y);
            //Console.WriteLine(y);

            /* the value of Y will be affected and will be changed because we passing the Ref of the variable (المتغير ذات نفسة مش نسخه منه) */


            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //int[] x = { 1, 2, 3 };
            //PassingByValue1(x);
            //Console.WriteLine(x[0]);

            /*  value of x[0] = 1000  , because and arr[] and x[] refer to the same object in memory   */


            //int[] y = { 1, 2, 3 };
            //PassingByValue2(ref y);
            //Console.WriteLine(y[0]);

            /* value of y[0] = 1000, because arr[] refer to the original y[]  (المتغير ذات نفسة )  */


            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //Console.Write("Enter n1: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter n2: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter n3: ");
            //int n3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter n4: ");
            //int n4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("------------------------------------");

            //(int sum, int sub) = Calculate(n1, n2, n3, n4);
            //Console.WriteLine($"the summation of n1 , n2  =  {sum}");
            //Console.WriteLine($"the summation of n3 , n4  =  {sub}");


            #endregion


            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //Console.Write("enter a num: ");
            //int Num = Convert.ToInt32(Console.ReadLine());

            //DigitsSum(Num);

            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.Write("enter number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            // bool result  =   IsPrime(number);
            //Console.WriteLine(result);


            #endregion


            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] array = { 0,1, 2, 3, 4, 5, 6, 500 };
            //int min = 0;
            //int max = 0;

            //MinMaxArray(array, ref min, ref max);

            //Console.WriteLine("min value in array is :" + min);
            //Console.WriteLine("max value in array is : " + max);




            #endregion


            #region  7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("enter number : ");
            //long number = long.Parse(Console.ReadLine());
            //Factorial(number);

            #endregion


            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter.
            //string letter = "omar";
            //int position = 2;
            //char c = 'N';
            //Console.WriteLine("before modifying : " + letter);
            //ChangeChar(ref letter , position , c);
            //Console.WriteLine("after modifying : " + letter);


            #endregion




        }
    }
}
