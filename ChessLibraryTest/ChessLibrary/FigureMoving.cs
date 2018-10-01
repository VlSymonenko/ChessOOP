﻿namespace ChessLibrary
{
    class FigureMoving
    {
        public Figure figure { get; private set; }
        public Square from { get; private set; }
        public Square to { get; private set; }
        public Figure promotion { get; private set; }
        public FigureMoving(FigureOnSquare fs, Square to, Figure promotion = Figure.none)
        {
            figure = fs.figure;
            from = fs.square;
            this.to = to;
            this.promotion = promotion;
        }

        public FigureMoving (string move) //Pe2e4
        {
            figure = (Figure)move[0];
            from = new Square(move.Substring(1, 2));
            to = new Square(move.Substring(3, 2));
            promotion = (move.Length == 6) ? (Figure)move[5] : Figure.none;
        }
    }
}
