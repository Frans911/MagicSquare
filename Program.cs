using System;

namespace MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"Magic Square",70}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            int oddNumber = 0;
            Console.Write("Enter an odd number : ");
            while (!(int.TryParse(Console.ReadLine(),out oddNumber)))
            {
                Console.Write("Enter an odd number : ");
            }

            int[,] magicSquare = new int[oddNumber, oddNumber];
            int number = 1;
            int row = 0;
            int column = oddNumber/2;
            int currentRow;
            int currentColumn;

            while (number <= oddNumber * oddNumber)
            {
                magicSquare[row, column] = number;
                number++;
                currentRow = row;
                currentColumn = column;
                row -= 1;
                column += 1;
                if (row == -1)
                {
                    row = oddNumber - 1;
                }
                if (column == oddNumber)
                {
                    column = 0;
                }

                if (magicSquare[row,column] != 0)
                {
                    row = currentRow + 1;
                    column = currentColumn;
                    if (column == oddNumber)
                    {
                        column = 0;
                    }
                }
            }
            for (int x = 0; x < oddNumber; x++)
            {
                for (int y = 0; y < oddNumber; y++)
                {
                    Console.Write($"|{magicSquare[x, y],1}|");
                }
                Console.WriteLine();
            }

        }
    }
}
