using System;

namespace Polimorfismo_por_herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            NuevoAlbum(new Barry());
            NuevoAlbum(new Mourice());
        }
        static void NuevoAlbum( BeeGees beegees)
        {
            beegees.Cantar();
        }
        public abstract class BeeGees
        {
            public abstract void Cantar();
        }
        public class Barry : BeeGees
        {
            public override void Cantar()
            {
                Console.WriteLine("Stayin Alive");
            }
        }
        public class Mourice : BeeGees
        {
            public override void Cantar()
            {
                Console.WriteLine("Alone");
            }
        }
    }
}
