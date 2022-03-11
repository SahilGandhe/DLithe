using System;


namespace ConsoleApp1
{
    class Animal
    {
            public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }

        public class Dog : Animal
        {
            public override void eat()
            {
                Console.WriteLine("Eating bread...");
            }
        }
        class GenericClass<T>
        {
            public GenericClass(T msg)
            {
                Console.WriteLine(msg);
            }
        }
        public class TestOverriding
        {
            public static void Main(string[] args)
            {

                Console.WriteLine("Virtual Function");
                Console.WriteLine("----------");
                Console.WriteLine("");

                Dog d = new Dog();
                d.eat();

                FileStream f = new FileStream("E:\\output.txt", FileMode.Create);
                StreamWriter s = new StreamWriter(f);

                Console.WriteLine("Files");
                Console.WriteLine("----------");
                Console.WriteLine("");
                s.WriteLine("hello c#");
                s.Close();
                f.Close();
                Console.WriteLine("File created successfully...");

             
                Console.WriteLine("Generics");
                Console.WriteLine("----------");
                Console.WriteLine("");

                GenericClass<string> gen = new GenericClass<string>("This is generic class");
                GenericClass<int> genI = new GenericClass<int>(101);
                GenericClass<char> getCh = new GenericClass<char>('I');
            }
        }
    }
}
    
    