using System;

namespace Encapsulamiento

{
    class Program
    {
        static void Main(string[] args)
        {
            var vector1 = new Vector(new int[] { 1, 4 });
            var vector2 = new Vector(new int[] { 2, 5 });
            var vectorSuma = vector1 + vector2;
        }
    }
    public class Vector
    {
        public Vector(int[] valores)
        {
            vector = valores;
        }
        private int[] vector { get; set; }
        public int Dimension { get { return vector.Length; } }
        public int this[int i]//indexador
        {
            get { return vector[i]; }
            set { vector[i] = value; }
        }
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return Sumar(vector1, vector2);
        }
        public static Vector Sumar(Vector vector1, Vector vector2)
        {
            if (vector1.Dimension != vector2.Dimension)
            {
                throw new ApplicationException("No puedes sumar vectores de dimensiones distintas");
            }

            int[] resultado = new int[vector1.Dimension];
            for (int i = 0; i < vector1.Dimension; i++)
            {
                resultado[i] = vector1[i] + vector2[i];
            }
            var vectorsuma = new Vector(resultado);
            return vectorsuma;
        }
    }
}
