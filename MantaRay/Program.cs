using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace MantaRay
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 5 
            int[] numberArray = {12,11,10,9,8};
            string[] stringArray = { "Drummers Drumming", "Pipers Piping", "Lords-a-Leaping", "Ladies Dancing", "Maids-a-Milking" };

            string[] songArray = new string[5];

            for (int i = 0; i < 5; i++)
            {
                int num = numberArray[i];
                string word = stringArray[i];
                string song = num + " " + word;
                songArray[i] = song;
            }

            Console.Write(" Please enter a command (sing/quit): ");
            string input = Console.ReadLine();

            if(input == "sing")
            { 
                foreach(string song in songArray)
                    {
                        Console.WriteLine(song);
                    }
            }
            else
            {
                Environment.Exit(0);
            }


            //EXERCISE 4 - let the user enter the size and elements of an integer array, calculate the min, max, and avg
            /* Console.Write("How many values do you want to enter into your array? ");
            var input1 = Console.ReadLine();
            int size = int.Parse(input1);
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please enter a number to add to the array: ");
                var input2 = Console.ReadLine();
                array[i] = int.Parse(input2);
            }

            Console.WriteLine("The maximum value is: " + array.Max());
            Console.WriteLine("The minimum value is: " + array.Min());
            Console.WriteLine("The average is: " + array.Average()); */


            //EXERCISE 3 - calculate an array based on user input
            /* int[] myArray = {16,32,64,128,256};

            Console.Write("Would you like to double or half the array? ");
            string input = Console.ReadLine();

            double multiplier = 0;
            if(input.ToLower() == "half")
                {
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        multiplier = .5;
                    }
                }
                else if(input == "double")
                {
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        multiplier = 2;
                    }
                }
                else
                {
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        multiplier = 1;
                    }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                double num = myArray[i] * multiplier;
                Console.WriteLine(num);
            } */


            // EXERCISE 1 - Create an array and check for a certain number
            /*  int[] myArray = { 2, 8, 0, 24, 51 };
              Console.Write("Please enter a number to search for in the array: ");
              string input = Console.ReadLine();
              int number = int.Parse(input);
              for (int i = 0; i < myArray.Length; i++)
              {
                  if(myArray[i] == number)
                      {
                          Console.WriteLine($"Success! {myArray[i]} is in the array, at index location {i}.");
                          break;
                      }
                  else
                  {
                      continue;
                  }
              } */


            //ARRAY EXAMPLE
            /* int[] myArray = { 1, 2, 3 };
             for (int i = 0; i < myArray.Length; i++)
             {
                 Console.WriteLine(myArray[i]);
             }

             int sum = 0;
             sum += 5;
             sum = sum + 5; //this is the same thing as the line above */


            //STRING EXAMPLE
            /*             int num = 100;
            string helloWorld = "Hello World! ";

            Console.WriteLine(String.Concat(helloWorld, num));
            Console.WriteLine("Hello World!" + num);
            Console.WriteLine("Hello " + "World!" + num);
            Console.WriteLine($"Hello World! {num}");

            Console.WriteLine(helloWorld.IndexOf("e"));
            Console.WriteLine(helloWorld.LastIndexOf("o"));
            Console.WriteLine(helloWorld.Replace('o', '5'));
            */
        }
}
}
