using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = new char[3, 3];

            //arr[0, 1] = 'x';//initialization  
            //arr[1, 2] = 'x';
            //arr[2, 0] = 'x';

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] == ' ')
                    {
                        Console.Write(arr[i, j] + "_ ");
                    }
               
                }
                Console.WriteLine();//new line at each row  
            }
        }
    }
}
