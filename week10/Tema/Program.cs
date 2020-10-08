using System;

namespace TemaGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> fruits = new GenericList<string>(10);
            fruits.Add(0, "apple");
            fruits.Add(1, "plum");
            fruits.Add(2, "pear");
            fruits.Add(3, "banana");
            fruits.Add(4, "pineapple");
            fruits.Add(5, "water melon");
            fruits.Add(6, "grapes");
            fruits.Add(7, "figs");
            fruits.Add(8, "lemon");
            fruits.Add(9, "orange");

            Console.WriteLine("Enter the number of item:");
            int getItem = int.Parse((Console.ReadLine()));

            Console.WriteLine($"The item is:{fruits.GetData(getItem - 1)} ");

            Console.WriteLine("Enter the number of item which you want to delete:");
            int getItem2 = int.Parse((Console.ReadLine()));
            Console.WriteLine("The new list is:");
            fruits.RemoveData(getItem2 - 1);


            Console.WriteLine("Insert new element in fruits list:");
            fruits.InsertData(1, "dates");

            Console.WriteLine("Search for an index of element :");
            Console.WriteLine(fruits.FindIndex("dates"));

            fruits.Clear();

            Console.WriteLine("------------------------------PROBLEMA2-----------------------------");


            //Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
            AutoGrow numbers = new AutoGrow();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine("Elements of array:");

            for (int i = 0; i < numbers.size; i++)
            {
                Console.Write(numbers.array[i] + " ");
            }

            Console.WriteLine();


            Console.WriteLine($"Size of array: {numbers.size}");
            Console.WriteLine($"Number of elements in array:{ numbers.count}");

            numbers.ShrinkSize();
            Console.WriteLine("Elements of array after shrink");

            for (int i = 0; i < numbers.size; i++)
            {
                Console.Write(numbers.array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Size of array:{numbers.size}");
            Console.WriteLine($"No of elements in array:  { numbers.count}");


            numbers.AddAt(1, 5);
            Console.WriteLine("Elements of array after add an element");

            for (int i = 0; i < numbers.size; i++)
            {
                Console.Write(numbers.array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"Size of array:{ numbers.size}");
            Console.WriteLine($"Number of elements in array: {numbers.count}");

            numbers.Remove();
            Console.WriteLine("After delete last element:");

            for (int i = 0; i < numbers.size; i++)
            {
                Console.Write(numbers.array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Size of array: " + numbers.size);
            Console.WriteLine($"Number of elements in array: { numbers.count}");

            numbers.RemoveAt(1);
            Console.WriteLine("Elements of array after delete: ");

            for (int i = 0; i < numbers.size; i++)
            {
                Console.Write(numbers.array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Size of array: { numbers.size}");
            Console.WriteLine($"Number of elements in array: { numbers.count}");


            Console.WriteLine("------------------------------PROBLEMA3-----------------------------");

            // Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
            //You may need to add generic constraints for type T.


            GenericList2 array = new GenericList2();
            int[] numbers1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Console.WriteLine($"max number is :{array.Max(numbers1)}");
            Console.WriteLine($"min number is: {array.Min(numbers1)}");

            Console.WriteLine("------------------------------PROBLEMA4-----------------------------");

            // Define a class Matrix<T> to hold a matrix of numbers(e.g.integers, floats, decimals).


            Matrix<double> numbers2 = new Matrix<double>(3, 3);

            for (int i = 0; i < numbers2.sizeRow; i++)
            {
                for (int j = 0; j < numbers2.sizeCol; j++)
                {
                    Console.WriteLine($"Element- [{i},{j}]");
                    numbers2.Data[i, j] = double.Parse(Console.ReadLine());
                }
            }
            numbers2.Print();

            Console.WriteLine("------------------------------PROBLEMA5-----------------------------");
            //  Implement an indexer this[row, col] to access the inner matrix cells.

            Console.WriteLine(numbers2.Data[0, 1]);


            Console.WriteLine("------------------------------PROBLEMA6-----------------------------");

            //            Problem 6.Matrix operations
            //Implement the operators +and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
            //Throw an exception when the operation cannot be performed.
            //Implement the true operator (check for non - zero elements).

            Console.WriteLine("******************************ADDITION****************************************");
            Matrix<double> numbers3 = new Matrix<double>(3, 3);
            for (int i = 0; i < numbers3.sizeRow; i++)
            {
                for (int j = 0; j < numbers3.sizeCol; j++)
                {
                    Console.WriteLine($"Element- [{i},{j}]");
                    numbers3.Data[i, j] = double.Parse(Console.ReadLine());
                }
            }
            numbers3.Print();

            Matrix<double> numbers4 = new Matrix<double>(3, 3);
            for (int i = 0; i < numbers4.sizeRow; i++)
            {
                for (int j = 0; j < numbers4.sizeCol; j++)
                {
                    numbers4.Data[i, j] = numbers2.Data[i, j] + numbers3.Data[i, j];
                }


            }
            Console.WriteLine("Result of addition is :");
            numbers4.Print();

            Console.WriteLine("*****************************subtraction*****************************************");
            for (int i = 0; i < numbers4.sizeRow; i++)
            {
                for (int j = 0; j < numbers2.sizeCol; j++)
                {
                    numbers4.Data[i, j] = numbers3.Data[i, j] - numbers2.Data[i, j];
                }
            }
            Console.WriteLine("the result of substraction");
            numbers4.Print();

            Console.WriteLine("*****************************Multiplication*****************************************");
            Console.WriteLine("Enter the number of row:");
            int row1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of col:");
            int col1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of row2:");
            int row2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of col2:");
            int col2 = int.Parse(Console.ReadLine());

            if (col1 != row2)
            {
                throw new InvalidOperationException("Multiplication is not possible");
            }

            Matrix<double> matrix1 = new Matrix<double>(row1, col1);
            Matrix<double> matrix2 = new Matrix<double>(row2, col2);
            Matrix<double> matrix3 = new Matrix<double>(row1, col2);

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.WriteLine($"Element- [{i},{j}]");
                    matrix1.Data[i, j] = double.Parse(Console.ReadLine());
                }
            }
            matrix1.Print();

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.WriteLine($"Element- [{i},{j}]");
                    matrix2.Data[i, j] = double.Parse(Console.ReadLine());
                }
            }
            matrix2.Print();

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    matrix3.Data[i, j] = 0;
                    for (int k = 0; k < row1; k++)
                    {
                        for (int l = 0; l < col2; l++)
                        {
                            double sum = 0;
                            for (int m = 0; m < col1; m++)
                            {
                                sum = sum + matrix1.Data[i, m] * matrix2.Data[m, j];
                                matrix3.Data[i, j] = sum;
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine("The resulting matrix is:\n");
                    matrix3.Print();

            Console.WriteLine("------------------------------PROBLEMA7-----------------------------");
            Console.WriteLine("Input a string :");

            String str = Console.ReadLine();

            if (str == "")
            {
                throw new ArgumentNullException("Try again!");
            }

            char[] charArray = str.ToCharArray();

            Console.WriteLine("Input string: " + str);
            ReverseString reversestr = new ReverseString();
            reversestr.Reverse(charArray);

            String revStr = new String(charArray);

            Console.WriteLine("Output string: " + revStr);
        }
    }








}





