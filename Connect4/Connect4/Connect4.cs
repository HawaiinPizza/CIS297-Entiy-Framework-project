using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4
{
    public enum Piece
    {
        Red, Green, Empty
    }
    public class Connect4Game
    {
        List<List<Piece>> pieces;

        public Connect4Game()
        {
            pieces = new List<List<Piece>>();

            for( int row = 0; row < 6; row++ )
            {
                pieces.Add(new List<Piece> { Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty });
            }
        }

        public Piece getPieceAt(int row, int column)
        {
            if ( row < 0 || row >= pieces.Count || column < 0 || column >= pieces[row].Count)
            {
                throw new ArgumentOutOfRangeException("don't do that thing");
            }
            return pieces[row][column];
        }
    }
}
