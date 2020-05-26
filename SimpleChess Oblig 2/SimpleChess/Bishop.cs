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

        public override string[] MoveChessPiece(string fromPosition, string toPosition)
        {

            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            var moves = new List<string>();
            if (diffCol < 0)
            {
                for (int i = 1; i < Math.Abs(diffRow); i++)
                {
                    if (diffRow > 0)
                    {
                        moves.Add($"{(char) (fromPosition[0] + i)}{(char) (fromPosition[1] - i)}");
                    }
                    else
                    {
                        moves.Add($"{(char) (fromPosition[0] + i)}{(char) (fromPosition[1] + i)}");
                    }
                }
            }
            else
            {
                for (int i = 1; i < Math.Abs(diffCol); i++)
                {
                    if (diffCol < 0)
                    {
                        moves.Add($"{(char) (fromPosition[0] - i)}{(char) (fromPosition[1] - i)}");
                    }
                    else
                    {
                        moves.Add($"{(char) (fromPosition[0] - i)}{(char) (fromPosition[1] + i)}");
                    }
                }
            }

            return moves.ToArray();
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            var column = fromPosition[0] - toPosition[0];
            var row = fromPosition[1] - toPosition[1];
            return Math.Abs(row) == Math.Abs(column);
        }
    }
}
