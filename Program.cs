using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter obj1 = Counter.getInstance;
            Counter obj2 = Counter.getInstance;
                /*
            Both the obj1 and obj2 are are referring to same instance and this is Singleton design pattern 
                */
            obj1.Increment(); //count=1
            obj2.Decrement(); //count=0
            obj1.Increment(); //count=1

            int value = obj1.count;
            Console.WriteLine(value);
        }
    }
}
