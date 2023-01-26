using System;
using System.Collections.Generic;
using System.Text;
namespace TicTacToe
{
    class Supporting
    {
        //method to print board
        public static void BoardPrint(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    if (j < 2)
                    {
                        Console.Write(" | ");
                    }
                }

                if (i < 2)
                {
                    Console.WriteLine("\n---------");//new line at each row 
                }
            }

        }

        //method for checking winner
        public static bool Winner(char[,] board)
        {
            // Check for a winner by checking rows, columns, and diagonals
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ') return true;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ') return true;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ') return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ') return true;
            return false;
        }
    }
}
