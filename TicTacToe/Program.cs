using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our tic tac toe game!" + "\n");

            char[,] board = new char[3, 3];
            char pos = '1';

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = pos;
                    pos++;

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


            // check for winner in while loop

            Console.WriteLine("\n");
            

            pos = '1';
            int turn = 0;
            //for (int turn = 0; turn < 9; turn++)
            while (Supporting.Winner(board) == false)
            {
                
                // Ask for player's choice
                Console.WriteLine("\nPlayer {0}, please enter your choice: ", (turn % 2) + 1);
                int ans = Convert.ToInt32(Console.ReadLine());
                        
                switch (ans)
                {
                    case 1:
                        board[0, 0] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                    case 2:
                        board[0, 1] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                    case 3:
                        board[0, 2] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                    case 4:
                        board[1, 0] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                    case 5:
                        board[1, 1] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                    case 6:
                        board[1, 2] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                    case 7:
                        board[2, 0] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                    case 8:
                        board[2, 1] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                    case 9:
                        board[2, 2] = (turn % 2 == 0) ? 'X' : 'O';
                        break;
                }
                Supporting.BoardPrint(board);
                turn++;
                Supporting.Winner(board);
            }
        }
    }
}
