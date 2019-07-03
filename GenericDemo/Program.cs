using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public interface IName
    {
        string SayName();
    }
    class Program
    {
        static void Introduce<T>(T m) where T : IName
        {
            Console.Write("i am");
            Console.WriteLine(m.SayName());
            Console.WriteLine("thank you");

        }
        /*
        static void Introduce(Marine m) 
        {
            Console.Write("i am");
            Console.WriteLine(m.SayName());
            Console.WriteLine("thank you");

        }
        static void Introduce(Firebat f) 
        {
            Console.Write("i am");
            Console.WriteLine(f.SayName());
            Console.WriteLine("thank you");

        }
        */  // 제네릭을 사용하지 않을 경우 다음과 같은 Introduce를 통해 marine과 firebat를 만들어야 한다.

        static void Main(string[] args)
        {
            Marine m = new Marine(3, "a");
            Introduce(m);


            IntStack stack = new IntStack();

            stack.Push(3);
            stack.Push(5);
            stack.Push(1);
            stack.Push(2);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            MarineStack ms = new MarineStack();
            ms.Push(new Marine(3, "a"));
            ms.Push(new Marine(5, "b"));
            ms.Push(new Marine(1, "c"));
            ms.Push(new Marine(2, "d"));

            Console.WriteLine(ms.Pop());
        }
    }
}
