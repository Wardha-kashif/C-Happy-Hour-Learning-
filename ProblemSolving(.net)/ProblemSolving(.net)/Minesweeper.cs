using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProblemSolving_.net_
{
    public class Minesweeper
    {
        public void minesweep()
        {
            int rows = 5;
            int cols = 5;
            int[,] board = new int[rows, cols];
            int[,] mines = new int[rows, cols];

            // Place mines randomly on the board
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (rnd.Next(100) < 20) // 20% chance of a mine
                    {
                        mines[i, j] = 1;
                    }
                }
            }

            // Play the game
            bool gameOver = false;
            while (!gameOver)
            {
                // Print the board
                Console.Clear();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (board[i, j] == 0)
                        {
                            Console.Write(".");
                        }
                        else if (board[i, j] == 9)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(board[i, j]);
                        }
                    }
                    Console.WriteLine();
                }

                // Get user input
                Console.Write("Enter row and column: ");
                string[] input = Console.ReadLine().Split();
                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);

                // Check for mine
                if (mines[row, col] == 1)
                {
                    Console.WriteLine("Game over!");
                    gameOver = true;
                }
                else
                {
                    // Count adjacent mines
                    int count = 0;
                    for (int i = row - 1; i <= row + 1; i++)
                    {
                        for (int j = col - 1; j <= col + 1; j++)
                        {
                            if (i >= 0 && i < rows && j >= 0 && j < cols && mines[i, j] == 1)
                            {
                                count++;
                            }
                        }
                    }

                    // Update board
                    board[row, col] = count;

                    // Check for win
                    int untouched = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (board[i, j] == 0)
                            {
                                untouched++;
                            }
                        }
                    }
                    if (untouched == 0)
                    {
                        Console.WriteLine("You win!");
                        gameOver = true;
                    }
                }
            }
        }
    }
}
