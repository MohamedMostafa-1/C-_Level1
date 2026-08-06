using System;


namespace C_Level1
{
    internal class Program
    {
        public static int Add(int x , int y)
        {
            return x + y;
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
            DateTime dt = new DateTime();

            Console.WriteLine(dt);




            Console.ReadKey();
        }
    }
}
