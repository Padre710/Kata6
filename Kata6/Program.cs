using System;
using System.Collections.Generic;
using System.Linq;


//You are given an array (which will have a length of at least 3
//, but could be very large) containing integers.
//The array is either entirely comprised of odd integers or entirely comprised of 
//even integers except for a single integer N. Write a method that takes the array 
//as an argument and returns this "outlier" N.

//Examples
//[2, 4, 0, 100, 4, 11, 2602, 36]
//Should return: 11 (the only odd number)

//[160, 3, 1719, 19, 11, 13, -21]
//Should return: 160(the only even number)

namespace Kata6

{

    class Program
    {
        public  class Kata
        {
            public static int Find(int[] integers)
            {
                

                List<int> even = new List<int>();
                List<int> odd = new List<int>();
                foreach (var num in integers)
                { 
                    if (num % 2 == 0)
                    {
                        even.Add(num);
                    }
                    else
                    {
                        odd.Add(num);
                    }
                }
                    int[] even_no = even.ToArray();
                    int[] odd_no = odd.ToArray();
                if (even_no.Length == 1)
                {
                    return even_no[0];
                }
                else
                    return odd_no[0];


               
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers =  { 160, 3, 1719, 19, 11, 13, -21 };
            Console.WriteLine(Kata.Find(numbers));
        }
    }
}
