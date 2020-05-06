using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
    internal class Bishop : Piece
    {
        public Bishop()
        {
            Symbol = "BIS";
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            var column = fromPosition[0] - toPosition[0];
            var row = fromPosition[1] - toPosition[1];
            return Math.Abs(row) == Math.Abs(column);
        }
    }
}
