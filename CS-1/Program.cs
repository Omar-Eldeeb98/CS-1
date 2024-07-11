namespace CS_1
{
    internal class Program
    {
        #region (Value type Parameters)  Passing parameters by value  
        //public static void Swap(int x , int y)
        //{
        //    int temp = 0;
        //    x = y;
        //    y = temp;
        //}

        #endregion

        #region (Value type Parameters) Passing Paramerters by Ref
        public static void Swap(ref int x, ref int y)
        {
            int temp = 0;
            x = y;
            y = temp;
        }


        #endregion


        #region (Reference type Parameters) Passing parameters by value
        //public static int SumArray(int[] arr)
        //{

        //    arr[0] = 1000;  // ---- 

        //    int sum = 0;
        //    for(int i = 0; i<arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }

        //    return sum;

        //}

        #endregion

        #region (Reference Type parameters) passing parameters by ref
        public static int SumArray(ref int[] arr)
        {

            arr[0] = 1000;  // ---- 

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;

        }
        #endregion


        #region  passing parameters by out
        //public static void Sum(int x,int y, out int sum,out int mult)
        // {
        //     sum = x + y;
        //     mult = x * y;

        // }

        #endregion


        #region passing by params 

        //public static int SumArray(params int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum = sum + arr[i];
        //    }

        //    return sum;
        //}

        #endregion

        static void Main(string[] args)
        {
            #region  Boxing
            //[boxing]  --------> from value type to reference type  , safe casting

            //object obj = new object();

            //obj = "omar";    // casting from reference to reference type variable
            //obj = 1;         //  casting from value type to reference type (Boxing)
            //obj = 'A';       // casting from value type to reference type (Boxing) 

            #endregion


            #region  Unboxing 
            //[UnBoxing]  ---------> from reference type to value typ ,   unsafe casting

            //object obj = 10;  // casting from reference to value type ,  unsafe casting.
            //int x =  (int) obj;
            #endregion


            #region  Nullable , with value type 

            // int x = null;  // invalid
            //int ?x = null;    //valid , allow null or int value
            //int y = (int)x;  // valid, explicit casting, unsafe casting

            #endregion


            #region Nullable , with Reference type

            //string x = null; // valid with warning
            /*string x = null!;*/ //  valid without warning
            /*string ?x = null;*/  // valid without warninig

            #endregion

            #region Null Propagation Operator  ?   

            /*int[] Numbers = default;*/   // output =  null 
            /*  Console.WriteLine(Numbers.Length); */  // Null exception
            /*   Console.WriteLine(Numbers?.Length); */ // (null propagation) if null will print null , or array length 

            //int x = Numbers?.Length ?? 0;  // if Numbers.lenght = null , X will take the (0) as value.
            //Console.WriteLine(x);

            #endregion



            #region (Value type Parameters)  Passing parameters by value  
            //int x = 5;
            //int y = 10;
            //Console.WriteLine("x before swap = " + x);  //5
            //Console.WriteLine("y before swap = " + y);  //10
            //Swap(x, y);
            //Console.WriteLine("x after swap = " + x); //5
            //Console.WriteLine("y after swap = " + y); //10


            #endregion


            #region (Value type Parameters) Passing Paramerters by Ref

            //int x = 5;
            //int y = 10;
            //Console.WriteLine("x before swap = " + x);  //5
            //Console.WriteLine("y before swap = " + y);  //10
            //Swap(ref x, ref  y);
            //Console.WriteLine("x after swap = " + x); //10
            //Console.WriteLine("y after swap = " + y); //5
            #endregion


            #region (Reference type Parameters) Passing parameters by value
            //int[] MyArray = {1, 2, 3 };
            //Console.WriteLine("MyArray[0] before =  " + MyArray[0]);
            //int result = SumArray(MyArray); 
            //Console.WriteLine("result = " + result);
            //Console.WriteLine("MyArray[0] after = " + MyArray[0]);
            #endregion


            #region (Reference Type parameters) passing parameters by ref


            //int[] MyArray = { 1, 2, 3 };
            //Console.WriteLine("MyArray[0] before =  " + MyArray[0]);
            //int result = SumArray(ref MyArray);
            //Console.WriteLine("result = " + result);
            //Console.WriteLine("MyArray[0] after = " + MyArray[0]);
            #endregion


            #region  passing parameters by out

            //int a = 10; 
            //int b = 20;
            //int sum;
            //int multi;

            //Sum(a, b, out sum, out multi);
            //Console.WriteLine(sum); // 30
            //Console.WriteLine(multi);  // 200 

            #endregion


            #region passing by params 

            //int res = SumArray(1, 2, 3);
            //Console.WriteLine(res); // 6 

            #endregion

        }
    }
}
