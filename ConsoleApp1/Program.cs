using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] numbersAsString;
            int i = 0;

            //get input as string
            Console.WriteLine("Please enter more than 3 numbers with comma ',' between them: ");
            input = Console.ReadLine(); 

            numbersAsString = input.Split(",");

            //init int array with length of split string
            int[] numbers = new int[numbersAsString.Length]; 

            // print and add each element to int array
            foreach (string nb in numbersAsString) 
            {
                numbers[i] = int.Parse(nb);
                i++;
            }

            findMin(numbers);
            findMax(numbers);
            sortDesc(numbers);
            sortAsc(numbers);
            evenArr(numbers);
            unevenArr(numbers);
            subArr(numbers, 1, 2);
        }

        static void findMin(int[] numbers)
        {
            Console.WriteLine("The index of the smallest number is: " + Array.IndexOf(numbers, numbers.Min()));
        }

        static void findMax(int[] numbers)
        {
            Console.WriteLine("The index of the biggest number is: " + Array.IndexOf(numbers, numbers.Max()));
        }

        static void sortAsc(int[] numbers)
        {
            Array.Sort(numbers);
            Console.WriteLine("The asc sorted arr is: ");
            foreach (int el in numbers)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine(" ");
        }

        static void sortDesc(int[] numbers)
        {
            Array.Reverse(numbers);
            Console.WriteLine("The reversed arr is: ");
            foreach (int el in numbers)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine(" ");
        }

        static int[] evenArr(int[] numbers)
        {
            int length = 0; //init length
            
            //find how many even nb are
            foreach (int el in numbers)
            {
                if (el % 2 == 0)
                {
                    length++;
                }
            }

            Console.WriteLine(length);

            //use length to init return arr
            int[] evenArr = new int[length];
            int index = 0;
            //assign even elements to returned arr
            foreach (int el in numbers)
            {  
                if (el % 2 == 0)
                {
                    evenArr[index] = el;
                    index++;
                }
            }

            //print even arr
            Console.WriteLine("The even numbers are: ");
            foreach (int el in evenArr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("");
            return evenArr;
        }

        static int[] unevenArr(int[] numbers)
        {
            int length = 0; //init length

            //find how many even nb are
            foreach (int el in numbers)
            {
                if (el % 2 != 0)
                {
                    length++;
                }
            }

            //use length to init return arr
            int[] evenArr = new int[length]; 
            int index = 0;
            //assign even elements to returned arr
            foreach (int el in numbers)
            {
                if (el % 2 != 0)
                {
                    evenArr[index] = el;
                    index++;
                }
            }

            //print even arr
            Console.WriteLine("The uneven numbers are: ");
            foreach (int el in evenArr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("");
            return evenArr;
        }

        static int[] subArr(int[] numbers, int index, int length)
        {
            if (length > numbers.Length || index < 0 || (index + length) > numbers.Length)
            {
                Console.WriteLine("Your parameters are not within range");
                return null;
            }

            int[] subArr = new int[length];

            int subIndex = 0;

            Console.Write ("The sub array from index " + index + " length " + length + " is: ");
            while (subIndex < length)
            {
                subArr[subIndex] = numbers[index];
                Console.Write(subArr[subIndex] + " ");
                index++;
                subIndex++;
            }

         return subArr;
        }
    }
}
