using System;

namespace GraphicalFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicalRepresentation(7);
            Console.WriteLine();
            GraphicalRepresentation(4);
            Console.WriteLine();
            GraphicalRepresentation(3);
        }

        static void GraphicalRepresentation(int figure)
        {
            for (int i= 0; i < figure; i++)
                Console.Write('*');
        }
    }
}
