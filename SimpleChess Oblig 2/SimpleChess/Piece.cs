using System;

namespace SimpleChess
{
    internal abstract class Piece
    {
        public string Symbol { get; set; }

        protected Piece()
        {
            Symbol = Symbol;
        }

        public abstract bool Move(string fromPosition, string toPosition);
        public abstract string[] MoveChessPiece(string fromPosition, string toPosition);
    }
}