namespace ChessLibrary
{
    public class Chess
    {
        static void Main(string[] args)
        {
        }
        public string fen { get; private set; }
        Board board;
        Moves moves;
        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            this.fen = fen;
            board = new Board(fen);
            moves = new Moves(board);
        }
        Chess(Board board)
        {
            this.board = board;
            fen = board.fen;
            moves = new Moves(board);
        }

        public Chess Move(string move)
        {
            FigureMoving fm = new FigureMoving(move);
            if (!moves.CanMove(fm))
                return this;
            Board nextboard = board.Move(fm);
            Chess nextChess = new Chess(nextboard);
            return nextChess;
        }

        public char GetFigureAt(int x , int y)
        {
            Square square = new Square(x, y);
            Figure f = board.GetFigureAt(square);
            return f == Figure.none ? '.' : (char)f;
        }
    }
}