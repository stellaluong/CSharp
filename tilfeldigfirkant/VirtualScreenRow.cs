using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tilfeldigfirkant
{
    public class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
            for (int i = 0; i < screenWidth; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddLowerLeftCorner();
            for (var i = 1; i < boxWidth - 1; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }
            _cells[boxX + boxWidth - 1].AddUpperRightCorner();
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddUpperLeftCorner();
            for (var i = 1; i < boxWidth - 1; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }
            _cells[boxX + boxWidth - 1].AddLowerRightCorner();
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddVertical();
            _cells[boxX + boxWidth - 1].AddVertical();
        }

        public void Show()
        {
            Console.CursorLeft = 0;
            var chars = _cells.Select(cell => cell.GetCharacter()).ToArray();
            Console.WriteLine(chars);
        }
    }
}
