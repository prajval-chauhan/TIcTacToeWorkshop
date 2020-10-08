using System;
using System.Runtime.ExceptionServices;

namespace TicTacToeWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Program");
        }

        public static void UC1()
        {
            char[] board = new char[10];
            for (int i=0; i<10; i++)
            {
                board[i] = ' ';
            }
        }
    }
}
