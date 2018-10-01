using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    class FigureOnSquare
    {
        public Figure figure { get; private set; }
        public Square square { get; private set; }

        internal FigureMoving FigureMoving
        {
            get => default(FigureMoving);
            set
            {
            }
        }

        internal Figure Figure
        {
            get => default(Figure);
            set
            {
            }
        }

        internal Square Square
        {
            get => default(Square);
            set
            {
            }
        }

        public FigureOnSquare(Figure figure,Square square)
        {
            this.square = square;
            this.figure = figure;
        }
    }
}
