using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int G = 10, Z = 0;
            int H = -1;
            H+= H;
            H= H+1;
            G-= H;
            Z = G;
            G = 5;
            H = 5;

            Console.WriteLine(Z);
            

        }
    }
}
