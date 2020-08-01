using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace Exercise1
{
public class Program
    {
       
        public static IEnumerable<long> Power2()
        {          
                for (long pow = 1; ; pow++)
            {
               
                 yield return pow * pow;
            }
        }
        public static void Main(string[] args)
        {

            foreach (long pow in Power2())
            {
                Console.WriteLine(pow);
                Console.ReadKey();
            }
        }
    }
}