using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
    internal class King : Piece
    {
        public King()
        {
            Symbol = "KNG";
        }
        public override string[] MoveChessPiece(string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }
        public override bool Move(string fromPosition, string toPosition)
        {
            var column = fromPosition[0] - toPosition[0];
            var row = fromPosition[1] - toPosition[1];

            if (Math.Abs(row) == 1 || Math.Abs(column) == 1)
            {
                return Math.Abs(row) == Math.Abs(column) || (fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1]);
            }
            return false;
        }
    }
}
