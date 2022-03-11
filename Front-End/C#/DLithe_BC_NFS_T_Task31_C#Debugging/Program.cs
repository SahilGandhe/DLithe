using System;

namespace InterfaceDemo
{
    public interface interface1
    {
        void Test();
        void Show();
    }
    public interface interface2
    {
        void Test();
        void Show();
    }
    public class Interafce : interface1, interface2
    {
        public void Test()
        {
            Console.WriteLine("Test method is implemented");
        }
        public void Show()
        {
            Console.WriteLine("Show method is implemented");
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Interafce obj = new Interafce();

                obj.Test();
                obj.Show();
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}