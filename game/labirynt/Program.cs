namespace labirynt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = InitializationBoard();

            //pozycja startowa gracza
            int playerPositionX = 0;
            int playerPositionY = 1;
            int exitX = 9;
            int exitY = 8;

            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();

                board[playerPositionX, playerPositionY] = '@';
                DrawBoard(board);

                if (playerPositionX == exitX && playerPositionY == exitY)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Winner winner chicken dinner");
                    Console.ResetColor();

                    break;
                }

                keyInfo = Console.ReadKey();
                PlayerMove(board, ref playerPositionX, ref playerPositionY, keyInfo);


            } while (keyInfo.Key != ConsoleKey.Escape);

            
        }

        //chodzenie
        private static void PlayerMove(char[,] board, ref int playerPositionX, ref int playerPositionY, ConsoleKeyInfo keyInfo)
        {
            if ((keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow) && (playerPositionX < board.GetLength(0) - 1) && board[playerPositionX + 1, playerPositionY] == ' ') //warunki chodzenia
            {
                board[playerPositionX, playerPositionY] = ' ';
                playerPositionX++;
            }
            else if ((keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow) && (playerPositionX > 0) && board[playerPositionX - 1, playerPositionY] == ' ')
            {
                board[playerPositionX, playerPositionY] = ' ';
                playerPositionX--;
            }
            else if ((keyInfo.Key == ConsoleKey.A || keyInfo.Key == ConsoleKey.LeftArrow) && (playerPositionY > 0) && board[playerPositionX, playerPositionY - 1] == ' ')
            {
                board[playerPositionX, playerPositionY] = ' ';
                playerPositionY--;
            }
            else if ((keyInfo.Key == ConsoleKey.D || keyInfo.Key == ConsoleKey.RightArrow) && (playerPositionY < board.GetLength(1) - 1) && board[playerPositionX, playerPositionY + 1] == ' ')
            {
                board[playerPositionX, playerPositionY] = ' ';
                playerPositionY++;
            }
        }

        //wyswietlanie mapy
        private static void DrawBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }

        //incjalizacja mapy
        private static char[,] InitializationBoard()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return new char[,]{
                { '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', '#' },
                { '#', ' ', '#', '#', '#', ' ', '#', '#', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', ' ', '#', ' ', '#' },
                { '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#' },
                { '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#' },
                { '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#' },
                { '#', ' ', '#', '#', '#', ' ', '#', '#', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#' },
            };
        }
    }
}
