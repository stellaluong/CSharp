using System;
using System.Collections.Generic;

namespace SimpleChess
{
    internal class Queen : Piece
    {
        public Queen()
        {
            Symbol = "QEN";
        }

        public override string[] MoveChessPiece(string fromPosition, string toPosition)
        {
            var column = fromPosition[0] - toPosition[0];
            var row = fromPosition[1] - toPosition[1];
            var moves = new List<string>();

            if (column == 0)
            {
                for (int i = 1; i < Math.Abs(row); i++)
                {
                    if (row < 0)
                    {
                        moves.Add($"{(char)(fromPosition[0])}{(char)(fromPosition[1] + i)}");
                    }
                    else
                    {
                        moves.Add($"{(char)(fromPosition[0])}{(char)(fromPosition[1] + i)}");
                    }
                }
            }
            else if (row == 0)
            {
                for (int i = 1; i < Math.Abs(column); i++)
                {
                    if (column < 0)
                    {
                        moves.Add($"{(char)(fromPosition[0] + i)}{(char)(fromPosition[1])}");
                    }
                    else
                    {
                        moves.Add($"{(char)(fromPosition[0] - i)}{(char)(fromPosition[1])}");
                    }
                }
            }
            else if (column < 0)
            {
                for (int i = 1; i < Math.Abs(row); i++)
                {
                    if (row > 0)
                    {
                        moves.Add($"{(char)(fromPosition[0] + i)}{(char)(fromPosition[1] - i)}");
                    }
                    else
                    {
                        moves.Add($"{(char)(fromPosition[0] + i)}{(char)(fromPosition[1] + i)}");
                    }
                }
            }
            else
            {
                for (int i = 1; i < Math.Abs(column); i++)
                {
                    if (column > 0)
                    {
                        moves.Add($"{(char)(fromPosition[0] - i)}{(char)(fromPosition[1]) - i}");
                    }
                    else
                    {

                        moves.Add($"{(char)(fromPosition[0] - i)}{(char)(fromPosition[1] + i)}");
                    }
                }
            }

            return moves.ToArray();
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];

            return Math.Abs(diffRow) == Math.Abs(diffCol) || (fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1]);
        }
    }
}
