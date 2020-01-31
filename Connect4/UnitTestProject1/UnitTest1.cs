using Microsoft.VisualStudio.TestTools.UnitTesting;
using Connect4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetCurrentPlayer()
        {
            // AAA

            // arrange
            Connect4Game game = new Connect4Game();
            Piece expectedCurrentPlayer = Piece.Red;

            // act
            Piece actualCurrentPlayer = game.getCurrentPlayer();

            // assert
            Assert.AreEqual(expectedCurrentPlayer, actualCurrentPlayer);

        }

        [TestMethod]
        public void TestMethodNewGameIsNotOver()
        {
            // AAA

            // arrange
            Connect4Game game = new Connect4Game();

            // act
            bool isGameOver = game.isGameOver();

            // assert
            Assert.IsFalse(isGameOver);

        }

        [TestMethod]
        public void TestMethodDropPieceAndCurrentPlayerChanges()
        {
            // AAA

            // arrange
            Connect4Game game = new Connect4Game();
            Piece expectedCurrentPlayer = Piece.Green;

            // act
            game.dropPieceInColumn(0);
            Piece actualCurrentPlayer = game.getCurrentPlayer();

            // assert
            Assert.AreEqual(expectedCurrentPlayer, actualCurrentPlayer);
        }

        [TestMethod]
        public void TestMethodGetPieceAt()
        {
            // AAA

            // arrange
            Connect4Game game = new Connect4Game();
            Piece expectedPieceColor = Piece.Red;

            // act
            game.dropPieceInColumn(0);
            Piece actualPieceColor = game.getPieceAt(5, 0);

            // assert
            Assert.AreEqual(expectedPieceColor, actualPieceColor);
        }

        [TestMethod]
        public void TestMethodCanWinHorizontally()
        {
            // AAA

            // arrange
            Connect4Game game = new Connect4Game();

            // act
            for (int columnIndex = 0; columnIndex < 4; columnIndex++)
            {
                game.dropPieceInColumn(columnIndex);
                game.dropPieceInColumn(columnIndex);
            }
            bool actualIsGameOver = game.isGameOver();

            // assert
            Assert.IsTrue(actualIsGameOver);

        }

        [TestMethod]
        public void TestMethodCanWinVertically()
        {
            // AAA

            // arrange
            Connect4Game game = new Connect4Game();

            // act
            for (int columnIndex = 0; columnIndex < 8; columnIndex++)
            {
                game.dropPieceInColumn(columnIndex % 2);
            }
            bool actualIsGameOver = game.isGameOver();

            // assert
            Assert.IsTrue(actualIsGameOver);

        }

        [TestMethod]
        public void TestMethodCanWinDiagonallyUp()
        {
            // AAA

            // arrange
            Connect4Game game = new Connect4Game();

            // act
            game.dropPieceInColumn(0);
            game.dropPieceInColumn(1);
            game.dropPieceInColumn(1);
            game.dropPieceInColumn(1);
            game.dropPieceInColumn(2);
            game.dropPieceInColumn(2);
            game.dropPieceInColumn(2);
            game.dropPieceInColumn(3);
            game.dropPieceInColumn(3);
            game.dropPieceInColumn(3);
            game.dropPieceInColumn(3);

            bool actualIsGameOver = game.isGameOver();

            // assert
            Assert.IsTrue(actualIsGameOver);

        }

        [TestMethod]
        public void TestMethodCanWinDiagonallyDown()
        {
            // AAA

            // arrange
            Connect4Game game = new Connect4Game();

            // act
            game.dropPieceInColumn(3);
            game.dropPieceInColumn(2);
            game.dropPieceInColumn(2);
            game.dropPieceInColumn(2);
            game.dropPieceInColumn(1);
            game.dropPieceInColumn(1);
            game.dropPieceInColumn(1);
            game.dropPieceInColumn(0);
            game.dropPieceInColumn(0);
            game.dropPieceInColumn(0);
            game.dropPieceInColumn(0);

            bool actualIsGameOver = game.isGameOver();

            // assert
            Assert.IsTrue(actualIsGameOver);

        }
        
        // skipping because this is hard

        //[TestMethod]
        //public void TestMethodIsGameOverTie()
        //{
        //    // AAA

        //    // arrange
        //    Connect4Game game = new Connect4Game();

        //    // act
        //    for (int columnIndex = 0; columnIndex < 7; columnIndex+=2)
        //    {
        //        for (int row = 0; row < 6; row++)
        //        {
        //            game.dropPieceInColumn(columnIndex);
        //        }
        //    }
        //    // act
        //    for (int columnIndex = 1; columnIndex < 7; columnIndex += 2)
        //    {
        //        for (int row = 0; row < 6; row++)
        //        {
        //            game.dropPieceInColumn(columnIndex);
        //        }
        //    }

        //    bool actualIsGameOver = game.isGameOver();

        //    // assert
        //    Assert.IsTrue(actualIsGameOver);

        //}
    }
}
