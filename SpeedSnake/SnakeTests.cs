using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpeedSnake
{
    [TestClass]
    public class SnakeTests
    {
        [TestMethod]
        public void TestMenuExit()
        {
            MainMenu myForm = new MainMenu();
            myForm.Show();
            Assert.IsTrue(myForm.Visible, "Checks if form is visible");
            myForm.Close();
            Assert.IsFalse(myForm.Visible, "Checks if form is visible");
        }
        
        [TestMethod()]
        public void TestEatingIncreasesScore()
        {
            Game form = new Game(true);
            Assert.AreEqual(0, form.score);
            form.Eat();
            Assert.AreEqual(10, form.score);
        }

        [TestMethod()]
        public void TestSnakeDies()
        {
            Game form = new Game(true);
            form.StartGame();
            Assert.AreEqual(form.gameOver, false);
            form.Die();
            Assert.AreEqual(form.gameOver, true);

        }
        [TestMethod()]
        public void TestFoodGenerate()
        {
            Game game = new Game(true);
            game.GenerateFood();
            Assert.IsTrue(game.food.X >= 0);
            Assert.IsTrue(game.food.Y >= 0);

        }
        [TestMethod()]
        public void TestExit()
        {
            MainMenu form = new MainMenu();
            form.Show();

            Assert.IsTrue(form.Visible, "Test if menu is running");
            form.Close();
            Assert.IsFalse(form.Visible, "Checks if form is running");
        }
        [TestMethod()]
        public void TestGameMessages()
        {
            Game form = new Game(true);
            form.Show();
            Assert.IsTrue(form.tsiScore.Visible, "Checks if lblScore is visible");
        }
        [TestMethod()]
        public void TestWriteHighScores()
        {
            Game form = new Game(true);
            form.Show();
            form.StartGame();
            form.Die();
            Assert.AreEqual(form.score, form.iHighScores[form.iHighScores.LastIndexOf(form.score)]);
        }
    }
}
