using System;
using System.Reflection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string name1;
        static string name2;
        static string symbolOfPlayer1AsString;
        static char symbolOfPlayer1;
        static char symbolOfPlayer2;
        static char[] arrayPositions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int playerChose;
        static string playerChoseAsString;
        static string winner;
        static bool stopGame = false;
        /**************************/
        static void Main(string[] args)
        {
            heandsUpDisplay();
            choseOurSymbol();
            printBoard();
            printToBoardPlayer1();

        }
        static void printToBoardPlayer1()
        {
            Console.WriteLine($"{name1} Please mark ur symbol on the board 1 - 9 :");
            playerChoseAsString = Console.ReadLine();
            if (playerChoseAsString == "1" ||
                playerChoseAsString == "2" ||
                playerChoseAsString == "3" ||
                playerChoseAsString == "4" ||
                playerChoseAsString == "5" ||
                playerChoseAsString == "6" ||
                playerChoseAsString == "7" ||
                playerChoseAsString == "8" ||
                playerChoseAsString == "9")
            {
                playerChose = Convert.ToInt32(playerChoseAsString);
            }
            if (arrayPositions[playerChose] != symbolOfPlayer1 && arrayPositions[playerChose] != symbolOfPlayer2)
            {
                arrayPositions[playerChose] = symbolOfPlayer1;
                Console.Clear();
                printBoard();
                winner = name1;
                checkWinner();
                if (stopGame != true)
                {
                    printToBoardPlayer2();

                }
            }
            else
            {
                Console.Clear();
                printBoard();
                printToBoardPlayer1();
            }
        }
        static void printToBoardPlayer2()
        {
            Console.WriteLine($"{name2} Please mark ur symbol on the board 1 - 9 :");
            playerChoseAsString = Console.ReadLine();

            if (playerChoseAsString == "1" ||
                playerChoseAsString == "2" ||
                playerChoseAsString == "3" ||
                playerChoseAsString == "4" ||
                playerChoseAsString == "5" ||
                playerChoseAsString == "6" ||
                playerChoseAsString == "7" ||
                playerChoseAsString == "8" ||
                playerChoseAsString == "9")
            {
                playerChose = Convert.ToInt32(playerChoseAsString);
            }
            if (arrayPositions[playerChose] != symbolOfPlayer1 && arrayPositions[playerChose] != symbolOfPlayer2)
            {
                arrayPositions[playerChose] = symbolOfPlayer2;

                Console.Clear();
                printBoard();
                winner = name2;
                checkWinner();
                if (stopGame != true)
                {
                   printToBoardPlayer1();
                }
            }
            else
            {
                Console.Clear();
                printBoard();
                printToBoardPlayer2();
            }

        }
        static void printBoard()
        {
            Console.WriteLine("********************************");
            Console.WriteLine($"* Welcome the GAME TIC TAC TOE *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");

            Console.WriteLine($"{name1} = {symbolOfPlayer1}");
            Console.WriteLine($"{name2} = {symbolOfPlayer2}");

            Console.WriteLine("===================");
            Console.WriteLine("*  {0}  |  {1}  |  {2}  *", arrayPositions[1], arrayPositions[2], arrayPositions[3]);
            Console.WriteLine("*-----+-----+-----*");
            Console.WriteLine("*  {0}  |  {1}  |  {2}  *", arrayPositions[4], arrayPositions[5], arrayPositions[6]);
            Console.WriteLine("*-----+-----+-----*");
            Console.WriteLine("*  {0}  |  {1}  |  {2}  *", arrayPositions[7], arrayPositions[8], arrayPositions[9]);
            Console.WriteLine("===================");
        }
        static void choseOurSymbol()
        {
            Console.WriteLine($"{name1} chose your symbol please x or o ");
            symbolOfPlayer1AsString = Console.ReadLine();
            if (symbolOfPlayer1AsString == "x" || symbolOfPlayer1AsString == "X")
            {
                symbolOfPlayer1 = char.Parse(symbolOfPlayer1AsString);
                symbolOfPlayer2 = 'o';
            }
            else if (symbolOfPlayer1AsString == "o" || symbolOfPlayer1AsString == "O")
            {
                symbolOfPlayer1 = char.Parse(symbolOfPlayer1AsString);
                symbolOfPlayer2 = 'x';
            }
            else
            {
                Console.Clear();
                choseOurSymbol();
            }
        }
        static void heandsUpDisplay()
        {
            //1.2  
            Console.WriteLine("Player 1 Please put your name :");
            name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Player 2 Please put your name :");
            name2 = Console.ReadLine();
            Console.Clear();
        }
        static void checkWinner()
        {
            //Rows Conditions
            if (arrayPositions[1] == arrayPositions[2] && arrayPositions[2] == arrayPositions[3])
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine($"{winner} has won the game!!!");
            }
            if (arrayPositions[4] == arrayPositions[5] && arrayPositions[5] == arrayPositions[6])
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine($"{winner} has won the game!!!");
            }
            if (arrayPositions[7] == arrayPositions[8] && arrayPositions[8] == arrayPositions[9])
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine($"{winner} has won the game!!!");
            }

            //Columns Conditions
            if (arrayPositions[1] == arrayPositions[4] && arrayPositions[4] == arrayPositions[7])
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine($"{winner} has won the game!!!");
            }
            if (arrayPositions[2] == arrayPositions[5] && arrayPositions[5] == arrayPositions[8])
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine($"{winner} has won the game!!!");
            }
            if (arrayPositions[3] == arrayPositions[6] && arrayPositions[6] == arrayPositions[9])
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine($"{winner} has won the game!!!");
            }
            //Diagonals Conditions
            if (arrayPositions[1] == arrayPositions[5] && arrayPositions[5] == arrayPositions[9])
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine($"{winner} has won the game!!!");
            }
            if (arrayPositions[3] == arrayPositions[5] && arrayPositions[5] == arrayPositions[7])
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine($"{winner} has won the game!!!");
            }
            //Draw Condition
            if (arrayPositions[1] != '1' &&
                arrayPositions[2] != '2' &&
                arrayPositions[3] != '3' &&
                arrayPositions[4] != '4' &&
                arrayPositions[5] != '5' &&
                arrayPositions[6] != '6' &&
                arrayPositions[7] != '7' &&
                arrayPositions[8] != '8' &&
                arrayPositions[9] != '9')
            {
                Console.Clear();
                stopGame = true;
                printBoard();
                Console.WriteLine("The game has ended with a draw");
            }
        }
    }
}

//