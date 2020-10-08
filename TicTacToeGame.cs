using System;
using System.Runtime.ExceptionServices;

namespace TicTacToeWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Program");
            CreateBoard();
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
        }

        public static void CreateBoard()
        {
            char[] board = new char[10];
            for (int i=0; i<board.Length; i++)
            {
                board[i] = ' ';
                Console.WriteLine(board[i]);
            }
           
        }

        public static char ZeroOrCross()
        {
            Console.WriteLine("Enter 'X' to select X and O to select 'O'");
            char input = Convert.ToChar(Console.ReadLine().ToUpper());
            return input;
        }

        public static void dispBoard()
        {
            Console.WriteLine("Current Board: \n");
            Console.WriteLine("1 | 2 | 3 ");
            Console.WriteLine("----------");
            Console.WriteLine("4 | 5 | 6 ");
            Console.WriteLine("----------");
            Console.WriteLine("7 | 8 | 9 ");
        }
    }
}
