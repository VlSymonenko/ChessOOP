using System;

namespace ChessLibrary
{
    class Moves
    {
        FigureMoving fm;
        Board board;
        public Moves(Board board)
        {
            this.board = board;
        }
        public bool CanMove(FigureMoving fm)
        {
            this.fm = fm;
            return
                CanMoveTo() &&
                CanMoveFrom() &&
                CanFigureMove();
               
        }
        bool CanMoveFrom()
        {
            return fm.from.OnBoard() &&
                fm.figure.GetColor() == board.moveColor;
        }
        bool CanMoveTo()
        {
            return fm.to.OnBoard() &&
                board.GetFigureAt(fm.to).GetColor() != board.moveColor;
        }
        bool CanFigureMove()
        {
            return true;
        }
    }
}
