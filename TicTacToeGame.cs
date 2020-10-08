using System;
using System.Runtime.ExceptionServices;

namespace TicTacToeWorkshop
{
    class Program
    {
        public static void Main(string[] args)
        {
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
            
            int position = User_Input();
            if (currentBoard[position] == ' ')
                currentBoard[position] = humanInput;
            else
            {
                Console.WriteLine("Position not empty");
                position = User_Input();
            }
            Console.Clear();
            DispBoard(currentBoard);

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
        
    }
}
