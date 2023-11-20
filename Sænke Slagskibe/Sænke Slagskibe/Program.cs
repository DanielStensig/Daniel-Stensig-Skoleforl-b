using System.Globalization;

namespace Sænke_Slagskibe
{
    internal class Program
    {
        enum Pieces { Pawn, Knight, Bushop, Queen, King, Rook };
        enum Color { Kryds, Bolle };

        static void Main(string[] args)
        {
            // 2 times 16 arrays of 4 positions
            //                      {c, {p,  {x,y,t}}}
            int[,,] array = new int[2, 16, 4];
            // 32 arrays of 4 positions
            //                       {p   {x,y,t,c}}
            int[,] array2  = new int[32, 4];
            Console.WriteLine(
                $"Peice: {(Pieces)array2[0, 2]}\n" +
                $"Color: {(Color)array2[0, 3]}\n" +
                $"Pos (x,y): {array2[0,0]}, {array2[0, 1]}\n");

            int[,] array3 = new int[,] { { 1, 2, 3 }, { 6, 4, 5 } };
            for ( int i = 0; i < array3.GetLength(1); i++ ) { Console.WriteLine(array3[1, i]); }
        }
    }
}