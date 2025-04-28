using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reworkwk4ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {// ask user input
            Console.WriteLine("enter number (n)");
            int n = Convert.ToInt32(Console.ReadLine()); // convert input to int
            //declare int array
            int[] ints = new int[n];
            Input(ints); // call method for user to input values
            Console.WriteLine("array elements"); // show title
            Display(ints); // call method to display 
            int sum = CalcSum(ints); // method to calc sum
            Console.WriteLine("sum of elements: " + sum); // display sum

            int max = FindMax(ints); // call method to find max
            int min = FindMin(ints); // call method to find min
            // display max
            Console.WriteLine("max val: " + max);
            // display min
            Console.WriteLine("min val: " + min);
            // display title
            Console.WriteLine("reversed array:");
            // call method to reverse array
            Reverse(ints);
            // display array
            Display(ints);
        }
        // method to input values
        static void Input(int[] ints)
        { // loop through each i of the array
            for (int i = 0; i < ints.Length; i++)
            {// ask user to inpput values
                Console.WriteLine($"enter elements [{i}]: ");
                // convert to int
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //method to display 
        static void Display(int[] ints)
        {// loop through each i of the array
            for (int i = 0; i < ints.Length; i++)
            { // display each elements with a space
                Console.WriteLine(ints[i] + " ");

            }
            // enter newline
            Console.WriteLine();
        }
        // method to cal sum
        static int CalcSum(int[] ints)
        {// init sum to 0
            int sum = 0;
            // loop through each i of the array
            for (int i = 0; i < ints.Length; i++)
                // add sum to ints[i]
            { sum += ints[i];
            } // return sum
            return sum;
        }
        // method to find the max
        static int FindMax(int[] ints)
        {// init max to the 1st element
            int max = ints[0];
            // loop through array beginging at the 2nd element
            for (int i = 1; i < ints.Length; i++)
            { // if > max
                if (ints[i] > max)
                    //max will equal ints[i] element
                    max = ints[i];

            }// return max
            return max;
        }
        // method to find min
        static int FindMin(int[] ints) {
            //init min to 1st element
            int min = ints[0];
            // loop through array beginging at the 2nd element
            for (int i = 1; i < ints.Length; i++)
            { //if < min
                if (ints[i] < min)
                    // min will = ints[i] element
                    min = ints[i];

            }// return
            return min;
        }
        // method to reverse array
        static void Reverse(int[] ints)
        { // init start to zeor
            int start = 0;
            // init end to last element
            int end = ints.Length - 1;
            // loop until start pass end
            while (start < end)
            { // give value start to e
                int e = ints[start];
                // set end to start
                ints[start] = ints[end];
                //set e value to end 
                ints[end] = e;
                // move start forwards
                start++;
                //move end back
                end--;
                    }
        }

    }
}
