using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ChessLibraryL
{

   public enum Figure
    {
        none,

        whiteKing = 'K',
        whiteQueen = 'Q',
        whiteRook = 'R',
        whiteBishop = 'B',
        whiteKnight = 'N',
        whitePawn = 'P',

        blackKing = 'k',
        blackQueen = 'q',
        blackRook = 'r',
        blackBishop = 'b',
        blackKnight = 'n',
        blackPawn = 'p'
    }
    //extensions
    static class FigureMethods
    {
        public static Color GetColor(this Figure figure)
        {
            if (figure == Figure.none)
                return Color.none;
            return (figure == Figure.whiteKing ||
            figure == Figure.whiteKnight ||
            figure == Figure.whiteBishop ||
            figure == Figure.whiteQueen ||
            figure == Figure.whiteRook ||
            figure == Figure.whitePawn)
            ? Color.white : Color.black;
        }
    }
}
