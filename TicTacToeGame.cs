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
            dispBoard();
            int position = User_Input();
            currentBoard[position] = humanInput;

        }

        public static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i=0; i<board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
           
        }

        public static char ZeroOrCross()
        {
            Console.WriteLine("Enter 'X' to select X and O to select 'O' : \n");
            char input = Convert.ToChar(Console.ReadLine().ToUpper());
            return input;
        }

        public static void dispBoard()
        {
            Console.WriteLine("Current Board: \n");
            Console.WriteLine("1 | 2 | 3 " );
            Console.WriteLine("----------");
            Console.WriteLine("4 | 5 | 6 ");
            Console.WriteLine("----------");
            Console.WriteLine("7 | 8 | 9 ");
        }

        public static int User_Input()
        {
            Console.WriteLine("Enter the position where you'd like to mark: ");
            int userMove = Convert.ToInt32(Console.ReadLine());
            return userMove;
        }
        
    }
}
