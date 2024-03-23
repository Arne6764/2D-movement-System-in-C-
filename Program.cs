using System;

class Program
{
    static void Main()
    {
        char[][] grid = {
                        new char[] { '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
                        new char[] { '█', '█', '█', '█', '█', '█', '░', '░', '░', '░', '█', '░', '░', '░', '█'},
                        new char[] { '█', '█', '█', '█', '█', '█', '░', '█', '█', '░', '█', '░', '█', '░', '█'},
                        new char[] { '█', '░', '░', '░', '░', '█', '░', '█', '█', '░', '█', '░', '█', '░', '█'},
                        new char[] { '█', '░', 'P', '█', '░', '█', '░', '░', '█', '░', '█', '░', '█', '░', '█'},
                        new char[] { '█', '░', '░', '█', '░', '█', '█', '░', '█', '░', '█', '░', '█', '░', '█'},
                        new char[] { '█', '░', '░', '█', '░', '░', '░', '░', '█', '░', '░', '░', '█', '░', '█'},
                        new char[] { '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█' }
                };

        int playerRow = 2;
        int playerCol = 2;

        PrintGrid(grid);

        while (true)
        {
            Console.Write("Enter direction to move (W/A/S/D): ");
            char move = Console.ReadKey().KeyChar;

            int newPlayerRow = playerRow;
            int newPlayerCol = playerCol;

            if (move == 'w' || move == 'W')
            {
                newPlayerRow -= 1;
            }
            else if (move == 'a' || move == 'A')
            {
                newPlayerCol -= 1;
            }
            else if (move == 's' || move == 'S')
            {
                newPlayerRow += 1;
            }
            else if (move == 'd' || move == 'D')
            {
                newPlayerCol += 1;
            }

            if (grid[newPlayerRow][newPlayerCol] != '█')
            {
                UpdatePlayerPosition(grid, playerRow, playerCol, newPlayerRow, newPlayerCol);
                playerRow = newPlayerRow;
                playerCol = newPlayerCol;
                Console.Clear();
                PrintGrid(grid);
            }
            else
            {
                Console.WriteLine("\nInvalid move! Try again.");
            }
        }
    }

    static void PrintGrid(char[][] grid)
    {
        foreach (var row in grid)
        {
            Console.WriteLine(string.Join("", row));
        }
    }

    static void UpdatePlayerPosition(char[][] grid, int oldRow, int oldCol, int newRow, int newCol)
    {
        grid[oldRow][oldCol] = '░';
        grid[newRow][newCol] = 'P';
    }
}
