using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
    internal class Pawn : Piece
    {
        public Pawn()
        {
            Symbol = "PAW";
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }

        public override string[] MoveChessPiece(string fromPosition, string toPosition)
        {
            var column = fromPosition[0] - toPosition[0];
            var row = fromPosition[1] - toPosition[1];
            var moves = new List<string>();

            if (Math.Abs(row) == 2)
            {
                moves.Add($"{(char)(fromPosition[0])}{(char)(fromPosition[1] + 1)}");
            }
            else
            {
                moves.Add($"{(char)(fromPosition[0])}{(char)(fromPosition[1] - 1)}");
            }

            return moves.ToArray();

        }
    }
}

