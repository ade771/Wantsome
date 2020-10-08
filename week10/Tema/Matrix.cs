using System;


namespace TemaGeneric
{
    public class Matrix<T>
    {
        public T[,] Data { get; set; }
        public int sizeRow { get; set; }
        public int sizeCol { get; set; }

        public Matrix(int sizeRow, int sizeCol)
        {
            this.Data = new T[sizeRow, sizeCol];
            this.sizeRow = sizeRow;
            this.sizeCol = sizeCol;
        }

        public void Print()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < sizeRow; i++)
            {
                for (int j = 0; j < sizeCol; j++)
                {
                    Console.Write(string.Format("{0} ", Data[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 && row >= sizeRow && col < 0 && col >= sizeCol)
                {
                    throw new IndexOutOfRangeException("");
                }
                return Data[row, col];
            }
            set
            {
                if (row < 0 && row >= sizeRow && col < 0 && col >= sizeCol)
                {
                    throw new IndexOutOfRangeException("");
                }
                Data[row, col] = value;
            }
        }
    }
}
