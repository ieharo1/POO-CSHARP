using System;

namespace Indexadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var index = new Indexador();
            index[3] = 58.4F;
            index[5] = 47.3F;
            for (int i = 0; i < index.Length; i++)
            {
                Console.WriteLine($"Element #{i} = {index[i]}");
            }
            
        }

    }
    public class Indexador
    {
        public float[] temps = new float[10] { 56.2, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 62.1F, 59.2F, 57.5F ,55.7F};
        public int Length => temps.Length;
        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }

}
