using System;
using System.Net.Mime;
using System.Text;

namespace SimpleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var board = new Board();
            var king = new King();
            var queen = new Queen();
            var knight = new Knight();
            var pawn = new Pawn();
            var bishop = new Bishop();
            var rook = new Rook();
            board.Set("f6", knight);
            board.Set("e5", pawn);
            board.Set("e1", queen);
            board.Set("d1", king);
            board.Set("e4", bishop);
            board.Set("f7", rook);
            while (true)
            {
                board.Show();
                Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
                var positionFrom = Ask("Hvilken rute vil du flytte fra?");
                var positionTo = Ask("Hvilken rute vil du flytte til?");
                board.Move(positionFrom, positionTo);
            }
        }

        public static string Ask(string question)
        {
            Console.Write(question);
            Console.Write(" ");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer)) Environment.Exit(0);
            return answer;
        }
    }
}
