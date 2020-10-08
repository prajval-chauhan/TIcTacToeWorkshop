using System;
using System.Runtime.ExceptionServices;
using System.Transactions;

namespace TicTacToeWorkshop
{
    class Program
    {
        public static void Main(string[] args)
        {
            //position vasriable for marking the move on board
            int position;
            int filledPositions = 0;
            int checkResult;

            Console.WriteLine("Welcome to the Tic Tac Toe Program");
            char[] currentBoard = CreateBoard();
            
            char humanInput = ZeroOrCross();
            char computerInput;
            if (humanInput == 'X')
            {
                computerInput = 'O';
            }
            else
                computerInput = 'X';
            Console.WriteLine("Computer will play with : " + computerInput);
            
            DispBoard(currentBoard);
            
            Console.WriteLine("\nChoose H or T:");
            char userToss = Convert.ToChar(Console.ReadLine());
            int tossResult = Toss();
            if(tossResult == 0)
                Console.WriteLine("You Lost the Toss");
            else
                Console.WriteLine("You won the Toss");

            
            
            switch(tossResult)
            {
                case 0:
                    for (; ; )
                    {
                        position = ComputerInput();
                        if (currentBoard[position] == ' ')
                            currentBoard[position] = computerInput;
                        else
                        {
                            position = ComputerInput();
                        }
                        DispBoard(currentBoard);
                        checkResult = resultCheck(currentBoard);
                        if(checkResult == 0)
                        {
                            Console.WriteLine("Computer Won");
                            break;
                        }

                        
                        filledPositions = filledPositions + 1;
                        if (filledPositions == 9)
                        {
                            Console.WriteLine("Match Drawn");
                            break;
                        }
                        // User Moves
                        position = User_Input();
                        if (currentBoard[position] == ' ')
                            currentBoard[position] = humanInput;
                        else
                        {
                            Console.WriteLine("Position not empty");
                            position = User_Input();
                        }
                        DispBoard(currentBoard);
                        checkResult = resultCheck(currentBoard);
                        if (checkResult == 0)
                        {
                            Console.WriteLine("User Won");
                            break;
                        }
                        Console.Read();
                        filledPositions = filledPositions + 1;

                        if (filledPositions == 9)
                        {
                            Console.WriteLine("Match Drawn");
                            break;
                        }
                    }
                        break;
                    

                case 1:
                    for (; ; )
                    {
                        position = User_Input();
                        if (currentBoard[position] == ' ')
                            currentBoard[position] = humanInput;
                        else
                        {
                            Console.WriteLine("Position not empty");
                            position = User_Input();
                        }
                        filledPositions = filledPositions + 1;
                        DispBoard(currentBoard);
                        checkResult = resultCheck(currentBoard);

                        if (checkResult == 0)
                        {
                            Console.WriteLine("User Won");
                            break;
                        }
                        if (filledPositions == 9)
                        {
                            Console.WriteLine("Match Drawn");
                            break;
                        }

                        position = ComputerInput();
                        if (currentBoard[position] == ' ')
                            currentBoard[position] = computerInput;
                        else
                        {
                            position = ComputerInput();
                        }
                        DispBoard(currentBoard);
                        checkResult = resultCheck(currentBoard);
                        if (checkResult == 0)
                        {
                            Console.WriteLine("Computer Won");
                            break;
                        }
                        Console.ReadKey();
                        if (filledPositions == 9)
                        {
                            Console.WriteLine("Match Drawn");
                            break;
                        }
                    }
                    break;


            }
            

        }
        /// <summary>
        /// creates a board with null values
        /// </summary>
        /// <returns></returns>
        public static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i=0; i<board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
           
        }
        /// <summary>
        /// Assigns O or X to the user input
        /// </summary>
        /// <returns></returns>
        public static char ZeroOrCross()
        {
            Console.WriteLine("Enter 'X' to select X and O to select 'O' : \n");
            char input = Convert.ToChar(Console.ReadLine().ToUpper());
            return input;
        }
        /// <summary>
        /// Displays the board.
        /// </summary>
        public static void DispBoard(char[] board)
        {
            Console.WriteLine("Current Board: \n");
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("----------");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("----------");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
        }
        /// <summary>
        /// Takes User input
        /// </summary>
        /// <returns></returns>
        public static int User_Input()
        {
            Console.WriteLine("Enter the position where you'd like to mark: ");
            int userMove = Convert.ToInt32(Console.ReadLine());
            return userMove;
        }
        public static int Toss()
        {
            Random randomNum = new Random();
            int Toss = randomNum.Next(0, 1);
            return (Toss);
        }

        public static int ComputerInput()
        {
            Random randomNum = new Random();

            Console.WriteLine("Computer's Turn: ");
            int compMove = randomNum.Next(1, 10);
            return compMove;
        }

        public static int resultCheck(char [] board)
        {
            int playResult = 1;
            if ((board[1] == board[2] && board[2] == board[3]) || (board[4] == board[5] && board[5] == board[6])
                || (board[7] == board[8] && board[8] == board[9]) || (board[1] == board[4] && board[4] == board[7])
                || (board[2] == board[5] && board[5] == board[8]) || (board[3] == board[6] && board[6] == board[9])
                || (board[1] == board[5] && board[5] == board[9]) || (board[3] == board[5] && board[5] == board[7])
                )
                playResult = 0;
            
            return playResult;

        }
    }
}
