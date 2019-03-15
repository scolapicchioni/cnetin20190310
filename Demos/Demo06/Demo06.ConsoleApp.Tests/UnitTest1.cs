using Moq;
using System;
using Xunit;

namespace Demo06.ConsoleApp.Tests
{
    public class GameTests
    {
        [Fact]
        public void PlayShouldReturnPlayer1WhenPlayer1RollsMoreThanPlayer2()
        {
            //arrange
            var p1 = new Mock<IPlayer>();
            var p2 = new Mock<IPlayer>();

            p1.Setup(p => p.Roll()).Returns(6);
            p2.Setup(p => p.Roll()).Returns(1);

            Game g = new Game(p1.Object, p2.Object);

            //act
            IPlayer actual = g.Play();

            //assert
            Assert.Equal(g.Player1, actual);
        }

        [Fact]
        public void PlayShouldReturnPlayer2WhenPlayer1RollsLessThanPlayer2()
        {
            //arrange
            var p1 = new Mock<IPlayer>();
            var p2 = new Mock<IPlayer>();

            p1.Setup(p => p.Roll()).Returns(1);
            p2.Setup(p => p.Roll()).Returns(6);

            Game g = new Game(p1.Object, p2.Object);

            //act
            IPlayer actual = g.Play();

            //assert
            Assert.Equal(g.Player2, actual);
        }

        [Fact]
        public void PlayShouldReturnNullWhenPlayer1RollsTheSameAsPlayer2()
        {
            //arrange
            var p1 = new Mock<IPlayer>();
            var p2 = new Mock<IPlayer>();

            p1.Setup(p => p.Roll()).Returns(3);
            p2.Setup(p => p.Roll()).Returns(3);

            Game g = new Game(p1.Object, p2.Object);
            
            //act
            IPlayer actual = g.Play();

            //assert
            Assert.Null(actual);
        }
    }
}
