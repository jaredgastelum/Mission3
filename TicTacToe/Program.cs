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
            Console.WriteLine("Player 1's turn (choose a number on the board): ");
            int ans = Convert.ToInt32(Console.ReadLine());
            
            

            pos = '1';
            for (int i = 0; i < 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = pos;
                    pos++;
                    

                    switch (ans)
                    {
                        case 1:
                            board[0, 0] = 'X';
                            break;
                        case 2:
                            board[0, 1] = 'X';
                            break;
                        case 3:
                            board[0, 2] = 'X';
                            break;
                        case 4:
                            board[1, 0] = 'X';
                            break;
                        case 5:
                            board[1, 1] = 'X';
                            break;
                        case 6:
                            board[1, 2] = 'X';
                            break;
                        case 7:
                            board[2, 0] = 'X';
                            break;
                        case 8:
                            board[2, 1] = 'X';
                            break;
                        case 9:
                            board[2, 2] = 'X';
                            break;
                    }

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
    }
}
