using System;
// provides us various methods to use in an array
using System.Linq;

namespace C_Level1
{
    internal class Program
    {
        public static int Add(int x , int y)
        {
            return x + y;
        }

        // You should use static if you want to call the method without having obejct.
        static void PrintMyName()
        {
            Console.WriteLine("Mohamed Mostafa ^_^ ");
        }
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        enum enWeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }
        struct stStudent
        {
            public string FirstName;
            public string LastName;
        }

        static void Main(string[] args)
        {
            Console.Write("\bWolcome First Line of code with {0} ^_^ \n", "C#");
            Console.WriteLine("\a");
            Console.WriteLine("x+y= " + (5+6));
            Console.Write(Add(5,9));

            //  Nullable<int> can be assigned any value
            //  from -2147483648 to 2147483647, or a null value.
            Nullable<int> i = null;

            //Anonymous Type is a type (object) without Class
            var student = new
            {
                Id = 20,
                FirstName = "Mohammed",
                LastName = "Abu-Hadhoud",

                Address = new
                {
                    Id = 1,
                    City = "Amman",
                    Country = "Jordan"
                }
            };


            //Sturct 
            //you must assign values to each member before accessing them
            //using new does not mean it's allocated in heap.
            stStudent Student = new stStudent();
            stStudent Student2;

            Student.FirstName = "Mohammed";
            Student.LastName = "Abu-Hadhoud";
            Student2.FirstName = "Ali";
            Student2.LastName = "Ahmed";

            Console.WriteLine(Student.FirstName);
            Console.WriteLine(Student.LastName);
            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student2.LastName);

            //var = Compile time type inference , NOT reassgin
            //dynamic = Runtime binding
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            /*
              Compile Time = البرنامج لسه بيتجهز للتشغيل.
              Runtime = البرنامج بدأ يشتغل فعليًا.
             */


            //DateTime
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            // Current DateTime
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
            Console.WriteLine(dt);


            //ticks
            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks


            // Datetime Static Fields
            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);


            //TimeSpan
            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);


            //Subtraction of two dates results in TimeSpan
            DateTime dt5 = new DateTime(2023, 2, 21);
            DateTime dt6 = new DateTime(2023, 2, 25);
            TimeSpan result = dt6.Subtract(dt5);

            Console.WriteLine("RESULTs: "+ result.Days);


            //Operators in DateTime
            DateTime dt7 = new DateTime(2015, 12, 20);
            DateTime dt8 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt8 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt8 - dt7); //377.05:10:20
            Console.WriteLine(dt7 == dt8); //False
            Console.WriteLine(dt7 != dt8); //True
            Console.WriteLine(dt7 > dt8); //False
            Console.WriteLine(dt7 < dt8); //True
            Console.WriteLine(dt7 >= dt8); //False
            Console.WriteLine(dt7 <= dt8);//True


            // Convert String to DateTime
            /*
              A valid date and time string can be converted to a DateTime object
              using Parse(), ParseExact(), TryParse() and TryParseExact() methods.
              
              The Parse() and ParseExact() methods will "throw an exception" if the specified string is not a valid representation of a date and time.
              So, it's recommended to use TryParse() or TryParseExact() method because they return false if a string is not valid.
             */

          
            var str = "6/12/2023";
            DateTime dt9;
            bool isValidDate = DateTime.TryParse(str , out dt9);

            if (isValidDate)
                Console.WriteLine(dt9);
            else
                Console.WriteLine($"{str} is not a valid date string");


            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt10;
            var isValidDate2 = DateTime.TryParse(str2, out dt10);

            if (isValidDate2)
                Console.WriteLine(dt10);
            else
                Console.WriteLine($"{str2} is not a valid date string");


            // string
            string S1 = "Mohammed Abu-Hadhoud";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Ali,Ahmed,Khalid";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Abu-Hadhoud  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());



            //  String Interpolation
            string firstName = "Mohammed";
            string lastName = "Abu-Hadhoud";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";
            Console.WriteLine(fullName);


            //Implicit Casting
            int myint = 17;
            double dbl = myint;
            
            //Explicit Casting
            double myDouble = 17.58;
            int myInt =(int) myDouble;

            //Type Conversion Methods
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


            //User Input
            Console.WriteLine("Enter your age?");
            //if you dont convert you will get error, and if you enter string you will get error
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);


            // Ternary Operator
            int number = 12;
            string reslt;

            reslt = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", number, reslt);


            //Array 
            int[] arrAge = new int[5];
            int[] Nums = { 1, 2, 3, 4, 5 };
            int[,] X = new int[2, 3];
            int[,] Y = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] Z = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
            }


            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };

            // get the minimum element
            Console.WriteLine("Smallest  Element: " + numbers.Min());
            // Max() returns the largest number in array
            Console.WriteLine("Largest Element: " + numbers.Max());
            // compute Count
            Console.WriteLine("Count : " + numbers.Count());
            // compute Sum
            Console.WriteLine("Sum : " + numbers.Sum());
            // compute the average
            Console.WriteLine("Average: " + numbers.Average());


            //C# Math
            Math.Max(5, 10);
            Math.Min(5, 10);
            Math.Sqrt(64);
            Math.Abs(-4.7);
            Math.Round(9.99);

            //Methods
            //You should use static if you want to call the method without having obejct.
            PrintMyName();

            //see the order of sending parameters is not important.
            MyMethod(child3: "Omar", child1: "Saqer", child2: "Hamza");

            Console.ReadKey();
        }
    }
}
