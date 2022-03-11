using System;

namespace Test3
{
    class NSP
    {

        public static void Main(string[] args) {


            Console.WriteLine("Partial ");

            Console.WriteLine(" -----------------------");
            PartialClass pc = new PartialClass();
               pc.HelloWorld();
            pc.HelloUniverse();



        
            string s1 = "hello";

            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s2 = new string(ch);
            Console.WriteLine(" -----------------------");

            Console.WriteLine("String with char array and string");

        
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Nullable<int> a = 10;
            Nullable<double> d = 10.10;
            Nullable<char> c = 'S';
            Nullable<bool> b = false;
            // Displaying value  
            Console.WriteLine(a.Value);
            // assigning null values  
            a = null;
            d = null;
            c = null;
            b = null;

            Console.WriteLine(" -----------------------");
            Console.WriteLine("Nullable");

           


            // Checking, does "a" contain value ?  
            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            if (a == null)
                Console.WriteLine("It contains null value");
        }
    }

}
