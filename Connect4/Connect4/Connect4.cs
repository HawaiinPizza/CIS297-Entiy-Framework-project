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
        Piece currentPlayer;

        public Connect4Game()
        {
            currentPlayer = Piece.Red;
            pieces = new List<List<Piece>>();

            for (int row = 0; row < 6; row++)
            {
                pieces.Add(new List<Piece> { Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty });
            }
        }

        public Piece getCurrentPlayer()
        {
            return currentPlayer;
        }

        public bool dropPieceInColumn(int columnIndex)
        {
            if ( isGameOver() )
            {
                return false;
            }
            if (columnIndex < 0 || columnIndex > 6 )
            {
                throw new IndexOutOfRangeException();
            }
            for ( int rowIndex = 5; rowIndex >= 0; rowIndex--)
            {
                if ( pieces[rowIndex][columnIndex] == Piece.Empty)
                {
                    pieces[rowIndex][columnIndex] = currentPlayer;
                    currentPlayer = currentPlayer == Piece.Red ? Piece.Green : Piece.Red;
                    return true;
                }
            }
            return false;
        }

        public Piece getPieceAt(int row, int column)
        {
            if (row < 0 || row >= pieces.Count || column < 0 || column >= pieces[row].Count)
            {
                throw new ArgumentOutOfRangeException("don't do that thing");
            }
            return pieces[row][column];
        }

        public bool isGameOver()
        {
            return hasWonVertically() || hasWonHorizontally()
                || hasWonDiagonally() || isTie();

        }

        public bool isTie()
        {
            if (hasWonVertically() || hasWonHorizontally()
                || hasWonDiagonally())
            {
                return false;
            }
            foreach (var row in pieces)
            {
                if (row.Contains(Piece.Empty))
                {
                    return false;
                }
            }
            return true;
        }

        private bool hasWonDiagonally()
        {
            return hasWonDiagonallyUp() || hasWonDiagonallyDown();
        }

        private bool hasWonDiagonallyDown()
        {
            for( int columnIndex = 0; columnIndex < 4; columnIndex++)
            {
                for( int rowIndex = 0; rowIndex < 3; rowIndex++)
                {
                    if ( pieces[rowIndex][columnIndex] != Piece.Empty
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex+1][columnIndex+1]
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex + 2][columnIndex + 2]
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex + 3][columnIndex + 3])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool hasWonDiagonallyUp()
        {
            for (int columnIndex = 0; columnIndex < 4; columnIndex++)
            {
                for (int rowIndex = 5; rowIndex > 2; rowIndex--)
                {
                    if (pieces[rowIndex][columnIndex] != Piece.Empty
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex - 1][columnIndex + 1]
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex - 2][columnIndex + 2]
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex - 3][columnIndex + 3])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool hasWonHorizontally()
        {
            foreach (var row in pieces)
            {
                for (int columnIndex = 0; columnIndex < 4; columnIndex++)
                {
                    if (row[columnIndex] != Piece.Empty
                        && row[columnIndex] == row[columnIndex + 1]
                        && row[columnIndex] == row[columnIndex + 2]
                        && row[columnIndex] == row[columnIndex + 3])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool hasWonVertically()
        {
            for (int columnIndex = 0; columnIndex < 7; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < 3; rowIndex++)
                {
                    if (pieces[rowIndex][columnIndex] != Piece.Empty
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex + 1][columnIndex]
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex + 2][columnIndex]
                        && pieces[rowIndex][columnIndex] == pieces[rowIndex + 3][columnIndex])
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
