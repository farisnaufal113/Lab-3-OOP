using System;

namespace Lab3MatrixVector
{
    public class Vector
    {
        
        private double[] values;

        
        public int Size
        {
            get { return values.Length; }
        }

        
        public Vector(double[] vals)
        {
            values = vals;
        }

        
        public Vector Add(Vector other)
        {
            if (other.Size != this.Size)
            {
                Console.WriteLine("Vector sizes not same. Cannot add.");
                return null;
            }

            double[] result = new double[Size];

            for (int i = 0; i < Size; i++)
            {
                result[i] = this.values[i] + other.values[i];
            }

            return new Vector(result);
        }

        
        public Vector Subtract(Vector other)
        {
            if (other.Size != this.Size)
            {
                Console.WriteLine("Vector sizes not same. Cannot subtract.");
                return null;
            }

            double[] result = new double[Size];

            for (int i = 0; i < Size; i++)
            {
                result[i] = this.values[i] - other.values[i];
            }

            return new Vector(result);
        }

        
        public double Dot(Vector other)
        {
            if (other.Size != this.Size)
            {
                Console.WriteLine("Vector sizes not same. Cannot do dot product.");
                return 0;
            }

            double sum = 0;

            for (int i = 0; i < Size; i++)
            {
                sum += this.values[i] * other.values[i];
            }

            return sum;
        }

        
        public void Print()
        {
            Console.Write("[ ");
            for (int i = 0; i < Size; i++)
            {
                Console.Write(values[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}