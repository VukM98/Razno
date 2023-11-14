using System;
using System.Reflection;
namespace Assignment_Refleksija
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(String);

            Console.WriteLine("Class name is: {0}.", t.Name);
            Console.WriteLine("Class namespace is: {0}", t.Namespace);
            Console.WriteLine("Class assembly is: {0}", t.Assembly);
            Console.WriteLine("Base class is: {0}", t.BaseType);
            Console.WriteLine("Abstract: {0}", t.IsAbstract);
            Console.WriteLine("Sealed: {0}", t.IsSealed);
            Console.WriteLine("Generic: {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Class: {0}", t.IsClass);
        }
    }
}

