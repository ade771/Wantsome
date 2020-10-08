using System;
using System.Collections.Generic;
using System.Text;

namespace TemaGeneric
{
    public class AutoGrow
    {
        public int[] array;
        public int count;
        public int size;

        // constructor initialize value to variable 
        public AutoGrow()
        {
          
            array = new int[1];
            count = 0;
            size = 1;
        }

        public void Add(int data)
        {
            if (count == size)
            {
                GrowSize(); 
            }  
            array[count] = data;
            count++;
        }
        public void GrowSize()
        {

            int[] temp = null;
            if (count == size)
            {
                temp = new int [size * 2];
                {
                    for (int i = 0; i < size; i++)
                    {
                        temp[i] = array[i];
                    }
                }            
            }
            array = temp;
            size = size * 2;
        }
        public void ShrinkSize()
        {
            int[] temp = null;
            if (count > 0)
            {
                temp = new int[count];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = array[i];
                }

                size = count;
                array = temp;
            }
        }
        public void AddAt(int index, int data)
        {
            if (count == size)
            {
                GrowSize();
            }

            for (int i = count - 1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }
            array[index] = data;
            count++;
        }
        public void Remove()
        {
            if (count > 0)
            {
                array[count - 1] = 0;
                count--;
            }
        }
        public void RemoveAt(int index)
        {
            if (count > 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[count - 1] = 0;
                count--;
            }
        }
    }
}
