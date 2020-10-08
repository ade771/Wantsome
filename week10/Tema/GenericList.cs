using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace TemaGeneric
{
    public class GenericList<T> 
    {
        public T[] Data { get; set; }
        private int size { get; set; }

        public GenericList(int size)
        {
            this.Data = new T[size];
            this.size = size;


        }

        public void Add(int index, T element)
        {
            if (index >= 0 && index < this.size)
            {
                this.Data[index] = element;
            }

            if (index == this.size - 1)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(Data[i]);
                }
            }
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < this.size)
                return Data[index];
            else
                return default;
        }

        public void RemoveData(int index)
        {

            if (index <= this.size - 1)
            {
                Data = Data.Except(new T[] { Data[index] }).ToArray();
            }

            for (int i = 0; i < this.size - 1; i++)
            {
                Console.WriteLine(Data[i]);
            }
        }

        public void InsertData(int index, T element)
        {
            this.size = size - 1;
            for (int i = size - 1; i >= index; i--)
            {
                Data[i] = Data[i - 1];

            }
            Data[index] = element;

            for (int i = 0; i < this.size; i++)
            {
                Console.WriteLine(Data[i]);
            }
        }

        public int FindIndex(T element)
        {
            for (int i = 0; i < size; i++)
            {
                if (EqualityComparer<T>.Default.Equals(element,Data[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            Data = new T[size];
            Console.WriteLine("The list is clear");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(Data[i]);
            }
        }

    }
}
