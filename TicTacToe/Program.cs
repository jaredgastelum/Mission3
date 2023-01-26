using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our tic tac toe game!" + "\n");
            //create array
            char[,] board = new char[3, 3];
            char pos = '1';
            //print original board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //autofill spots with numbers 1-9
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

            Console.WriteLine("\n");


            // check for winner in while loop
            int turn = 0;
            while (Supporting.Winner(board) == false)
            {
                
                // Ask for player's choice
                Console.WriteLine("\nPlayer {0}, please enter your choice: ", (turn % 2) + 1);
                int ans = Convert.ToInt32(Console.ReadLine());
                // update array    
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
                //reprint board
                Supporting.BoardPrint(board);
                // check for winner
                Supporting.Winner(board);
                //print winner
                if (Supporting.Winner(board))
                {
                    Console.WriteLine("\nPlayer {0} wins!", (turn % 2) + 1);
                    break;
                }
                //print tie
                if (turn == 8)
                {
                    Console.WriteLine("\nIt's a tie.");
                    return;
                }
                //increment turn
                turn++;
            }
        }
    }
}
