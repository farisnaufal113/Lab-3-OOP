using System;

namespace Lab3MatrixVector
{
    public class Matrix
    {
       
        private double[][] data;

        public int Rows
        {
            get { return data.Length; }
        }

        public int Cols
        {
            get { return data[0].Length; }
        }

        
        public Matrix(double[][] values)
        {
            data = values;
        }

        
        public Matrix Add(Matrix other)
        {
            if (other.Rows != this.Rows || other.Cols != this.Cols)
            {
                Console.WriteLine("Matrix sizes not same. Cannot add.");
                return null;
            }

            double[][] result = new double[Rows][];

            for (int i = 0; i < Rows; i++)
            {
                result[i] = new double[Cols];

                for (int j = 0; j < Cols; j++)
                {
                    result[i][j] = this.data[i][j] + other.data[i][j];
                }
            }

            return new Matrix(result);
        }

       
        public Matrix Multiply(Matrix other)
        {
            if (this.Cols != other.Rows)
            {
                Console.WriteLine("Matrix sizes not valid for multiplication.");
                return null;
            }

            double[][] result = new double[this.Rows][];

            for (int i = 0; i < this.Rows; i++)
            {
                result[i] = new double[other.Cols];

                for (int j = 0; j < other.Cols; j++)
                {
                    double sum = 0;

                    for (int k = 0; k < this.Cols; k++)
                    {
                        sum += this.data[i][k] * other.data[k][j];
                    }

                    result[i][j] = sum;
                }
            }

            return new Matrix(result);
        }

        
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(data[i][j] + " ");
                }
                Console.WriteLine("]");
            }
        }
    }
}