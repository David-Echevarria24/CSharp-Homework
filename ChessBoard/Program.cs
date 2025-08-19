namespace ChessBoard;

class ChessBoards
{
    public  static void PrintBoard(int gridSize, char X, char O)
    {
        for (int row = 0; row < gridSize; row++)
        {
            for (int column = 0; column < gridSize; column++)
            {
                if (((column + row) & 1) == 1)
                {
                    Console.Write(O);
                }
                else
                {
                    Console.Write(X);
                }
            }
            Console.WriteLine();
        }
        return;

        
    }

    static void Main(string[] args)
    {
        // Test the chessboard with different sizes and characters
        PrintBoard(4, 'X', 'O');
       
    }
}
