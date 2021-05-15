using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray
            {
                length = 5,
                data = new object[] { "A", "B", "C", "D", "E" }
            };


            Console.WriteLine(myArray.Get(2));

            //myArray.Delete(2);
            //Console.WriteLine(myArray.length);
            //foreach (var x in myArray.data)
            //{
            //    Console.WriteLine(x);
            //}

            //myArray.Pop();
            //for (var i = 0; i < myArray.length; i++)
            //{
            //    Console.WriteLine(myArray.data[i]);
            //}
            //Console.WriteLine("Length of Array: {0}", myArray.length);


            //myArray.Push("F");
            //for (var i = 0; i < myArray.length; i++)
            //{
            //    Console.WriteLine(myArray.data[i]);
            //}
            //Console.WriteLine("Length of Array: {0}", myArray.length);
        }
    }
    public class MyArray
    {
        public long length;
        public object[] data;

        public MyArray()
        {
            this.length = 0;
            this.data = new object[1];
        }

        /// <summary>
        /// Getting the element at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object Get(long index)
        {
            return this.data[index];
        }

        /// <summary>
        /// Deleting the element at specified index
        /// </summary>
        /// <param name="index"></param>
        public void Delete(long index)
        {
            if (index < this.length)
            {
                for (var i = index; i < this.length - 1; i++)
                {
                    this.data[i] = this.data[i + 1];
                }
                this.data[this.length - 1] = null;
                this.length--;
            }
        }

        /// <summary>
        /// Deleting the last element of the array
        /// </summary>
        public void Pop()
        {
            this.data[this.length - 1] = null;
            this.length--;
        }

        /// <summary>
        /// Adding element to the end of the array
        /// </summary>
        public void Push(object element)
        {
            object[] tempArray = this.data;
            this.data = new object[this.length + 1];
            Array.Copy(tempArray, this.data, this.length);
            this.data[this.length] = element;
            this.length++;
        }
    }

}
