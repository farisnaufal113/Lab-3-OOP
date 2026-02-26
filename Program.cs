using System;

namespace Lab3MatrixVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] arr1 = { 2, -1, 5 };
            double[] arr2 = { 1, 3, 4 };

            Vector v1 = new Vector(arr1);
            Vector v2 = new Vector(arr2);

            Console.WriteLine("v1:");
            v1.Print();

            Console.WriteLine("v2:");
            v2.Print();

            Vector vAdd = v1.Add(v2);
            Console.WriteLine("v1 + v2:");
            if (vAdd != null) vAdd.Print();

            Vector vSub = v1.Subtract(v2);
            Console.WriteLine("v1 - v2:");
            if (vSub != null) vSub.Print();

            double dot = v1.Dot(v2);
            Console.WriteLine("v1 · v2 = " + dot);

            Console.WriteLine();

            
            double[][] aData = {
                new double[] { 1, 2, 3 },
                new double[] { 4, 5, 6 }
            };

            double[][] bData = {
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 2, -1 }
            };

            Matrix a = new Matrix(aData);
            Matrix b = new Matrix(bData);

            Console.WriteLine("Matrix A:");
            a.Print();

            Console.WriteLine("Matrix B:");
            b.Print();

            Matrix c = a.Multiply(b);
            Console.WriteLine("A * B:");
            if (c != null) c.Print();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}