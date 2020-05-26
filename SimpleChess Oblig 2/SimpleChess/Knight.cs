using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{

    internal class Knight : Piece
    {
        public Knight()
        {
            Symbol = "KNI";
        }
        public override bool Move(string fromPosition, string toPosition)
        {
            var column = fromPosition[0] - toPosition[0];
            var row = fromPosition[1] - toPosition[1];
            return (Math.Abs(row) == 2 && Math.Abs(column) == 1) || (Math.Abs(row) == 1 && Math.Abs(column) == 2);
        }

        public override string[] MoveChessPiece(string fromPosition, string toPosition)
        {
            return new string[0];
        }
    }
}