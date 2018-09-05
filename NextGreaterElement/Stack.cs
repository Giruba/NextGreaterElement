using System;
using System.Collections.Generic;
using System.Text;

namespace NextGreaterElement
{
    class Stack
    {
        private int top = -1;
        private int size = 0;
        private int[] array;
        public Stack(int size) {
            this.size = size;
            array = new int[size];
        }

        public void Push(int Element) {
            if (top == size - 1)
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                top = top + 1;
                array[top] = Element;     
            }
        }

        public int Peek() {
            return array[top];
        }

        public bool IsEmpty() {
            return top == -1;
        }

        public int Pop() { 
            if(top == -1){
                Console.WriteLine("Stack is Empty! Cannot pop :(");
                return -1;
            }
            int index = top ;
            top -= 1;
            return array[index];
        }

        public int Size() {
            return size;
        }
    }
}
