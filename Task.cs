using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CR - remove all unused packages

namespace ConsoleApp2
{
    internal class Task
    {
       //exe1
       //CR - you should avoid using commenting in your code
        public static Boolean Cheack(int number) //CR - you need to use 'bool' and not Boolean. Naming - the name of the function doesnt indicate its meaning
        {
            bool isPrime = true; //CR - why is the default value is true? most numbers are not prime.

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break; //CR - we should avoid using break.
                }
            }

            return isPrime;
        }
       //exe2
        public static int MaxValue()
        {
            //CR - read about "do while" in C#
            //CR - why do you use int.MinValue?
            int max = int.MinValue;
            Console.WriteLine("הקש מספר");

            int x = int.Parse(Console.ReadLine());
            while (x > -1)
            {
                if (x > max)
                    max = x; //CR - use short if notation
                Console.WriteLine("הקש מספר");

                x = int.Parse(Console.ReadLine()); //CR - if the input from the user won't be a number, your program will throw an exception. 

            }
            return max;
        }
        //exe3
        static void PrintFibonacci(int n)
        {
            int first = 0, second = 1, next;

            Console.Write( first + ", " + second);

            for (int i = 2; i < n; i++) //CR - consider if using for loop here is the best way.
            {
                if (first + second > n)
                    break;
                next = first + second;
                Console.Write(", " + next);
                first = second;//2
                second = next;//3
            }

            
        }
        //exe4
        public static void ThirdMax()
        {
            //CR - why do you use int.MinValue? think of another way - maybe set the mux sum as the sum of the first 3 values.
            //CR - What about the case where the user only gives two numbers?
            int number, first = 0, second = 0, maxSum = int.MinValue, currentSum = 0, third = 0, first2 = 0, second2 = 0, third2 = 0; //CR - you don't have to use so much variables. A prominent sign for that is using first2, second2...
            //CR - pay attention naming of the variables (instead of first2 - maybe call it 'firstNumberHandler'
            Console.WriteLine("press number"); //CR - read about "do while" in C#
            number = int.Parse(Console.ReadLine()); 
            //CR - if the input from the user won't be a number, your program will throw an exception. 
            //CR -you shoud use int.TryParse() - read about it on the internet
            while (number != -1)
            {
                first = second;
                second = third;
                third = number;
                currentSum = first + second + third;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    first2 = first;
                    second2=second; 
                    third2 = third;

                }
                Console.WriteLine("press number");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0},{1},{2}", first2, second2, third2);
            
        }
       
        //CR - dont submit code with comments (especially in the main function).
        //CR - the main should be in a different file
    static void Main(string[] args)
        {
            //ex1  bool b = Cheack(11);
            //ex1   Console.WriteLine(b);
            //ex2 Console.WriteLine(MaxValue());
            //exe3 PrintFibonacci(12);
            //exe4 ThirdMax();
            // exe5
            // 1. Audi car1 = new Audi("AAA");
            // 2. Console.WriteLine(car1.Speed);
            //  3. Console.WriteLine("כמה ברצונך להאיץ?");
            //  int x=int.Parse(Console.ReadLine());
            //    car1.Accelerate(x);
            //  Console.WriteLine(car1.Speed);
            // 4. car1.PrintDetails();
            // 5. car1.Decelerate(2);
            // 6. car1.PrintDetails();
            // 7. car1.Stop();

            //8. Lexus car2 = new Lexus("bbb");
            //9.Console.WriteLine(car2.Speed);
            //10. Console.WriteLine("כמה ברצונך להאיץ?");
            // int x=int.Parse(Console.ReadLine());
            // car2.Accelerate(x);
            //11.  car2.PrintDetails();
            //12. car2.StartMusic();
            //13.  car2.Decelerate(2);
            //14.  car2.PrintDetails();
            //15. car2.StopMusic();
            //16 car2.Stop();



            Console.Read();
        }
    }
}
        
    

