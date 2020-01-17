using System.Collections.Generic;
using NUnit.Framework;

namespace GreedKata
{
    [TestFixture]
    public class Tests
    {
        private List<int> _diceRolls;
        private Greed _greed;

        [SetUp]
        public void SetUp()
        {
            _greed = new Greed();
        }


        [Test]
        public void SingleOne()
        {
            _diceRolls = new List<int>{1};
            Assert.AreEqual(100,_greed.Score(_diceRolls));
        }

        [Test]
        public void TwoOnes()
        {
            _diceRolls = new List<int>{1, 1};
            Assert.AreEqual(200, _greed.Score(_diceRolls));
        }

        [Test]
        public void SingleFive()
        {
            _diceRolls = new List<int>{5};
            Assert.AreEqual(50, _greed.Score(_diceRolls));
        }

        [Test]
        public void ThreeOnes()
        {
            _diceRolls = new List<int>{1,1,1};
            Assert.AreEqual(1000, _greed.Score(_diceRolls));
        }

        [Test]
        public void ThreeTwos()
        {
            _diceRolls = new List<int>{2,2,2};
            Assert.AreEqual(200, _greed.Score(_diceRolls));
        }

        [Test]
        public void FourOfAKind()
        {
            _diceRolls = new List<int>{1,1,1,1};
            Assert.AreEqual(2000,_greed.Score(_diceRolls));
        }

        [Test]
        public void FiveOfAKind()
        {
            _diceRolls = new List<int> { 1, 1, 1, 1, 1};
            Assert.AreEqual(4000, _greed.Score(_diceRolls));
        }

        [Test]
        public void SixOfAKind()
        {
            _diceRolls = new List<int> { 1, 1, 1, 1, 1, 1};
            Assert.AreEqual(8000, _greed.Score(_diceRolls));
        }

        [Test]
        public void ThreePair()
        {
            _diceRolls = new List<int>{2,2,3,3,4,4};
            Assert.AreEqual(800, _greed.Score(_diceRolls));
        }

        [Test]
        public void Straight()
        {
            _diceRolls = new List<int>{1,2,3,4,5,6};
            Assert.AreEqual(1200,_greed.Score(_diceRolls));
        }

        [Test]
        public void TwoThreePairs()
        {
            _diceRolls = new List<int>{1,1,1,2,2,2};
            Assert.AreEqual(1200,_greed.Score(_diceRolls));
        }

        [Test]
        public void SingleThree()
        {
            _diceRolls = new List<int>(3);
            Assert.AreEqual(0, _greed.Score(_diceRolls));
        }
    }
}