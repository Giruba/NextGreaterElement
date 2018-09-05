using System;

namespace NextGreaterElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Next Greater Element!");
            Console.WriteLine("--------------------");
            int[] inputArray;
            Console.WriteLine("Enter the number of elements");
            int noOfElements = int.Parse(Console.ReadLine());
            inputArray = new int[noOfElements];
            Stack stack = new Stack(noOfElements);
            Console.WriteLine("Enter the " + noOfElements + " elements by hitting Enter");
            for (int i = 0; i < noOfElements; i++) {
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            stack.Push(inputArray[0]);
            PrintNextGreaterElement(stack, inputArray);
        }

        public static void PrintNextGreaterElement(Stack stack, int[] array) {
            for (int i = 1; i < array.Length; i++) {
                if (stack.IsEmpty()) {
                    stack.Push(array[i]);
                }

                while (stack.IsEmpty() == false && stack.Peek() < array[i]) {
                    Console.WriteLine("Element: "+stack.Peek() +", Next Greater Element: "+array[i]);
                    stack.Pop();
                }
                stack.Push(array[i]);
            }
            PrintMinusOneForThoseNoNGE(stack);
        }

        public static void PrintMinusOneForThoseNoNGE(Stack stack) {
            while (stack.IsEmpty() == false) {
                Console.WriteLine("Element: "+stack.Peek()+", NGE: -1");
                stack.Pop();
            }
            Console.ReadKey();
        }
    }
}
