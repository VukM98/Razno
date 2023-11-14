using System;
namespace PovršinaKruga
{
    delegate String Product(int r);
    public class Program
    {
        public static void Main(string[] args)
        {
            Product PovKruga = (r) => Convert.ToString(r * r * Math.PI);
            Console.WriteLine("Result is : " + PovKruga(10));
        }
    }
}