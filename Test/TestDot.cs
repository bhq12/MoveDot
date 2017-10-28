using System;
using NUnit.Framework;
using MoveDot.Model;

namespace Test
{
    [TestFixture]
    public class TestDot
    {
        [Test]
        public void TestLeftMovement()
        {
            var dot = new Dot();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
            
            dot.MoveLeft();
            
            Assert.AreEqual(-1,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
        }
        
        [Test]
        public void TestRightMovement()
        {
            var dot = new Dot();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
            
            dot.MoveRight();
            
            Assert.AreEqual(1,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
        }
        
        [Test]
        public void TestDownwardsMovement()
        {
            var dot = new Dot();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
            
            dot.MoveDown();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(-1,dot.Position.Y);
        }
        
        [Test]
        public void TestUpwardsMovement()
        {
            var dot = new Dot();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
            
            dot.MoveUp();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(1,dot.Position.Y);
            
            
        }
        
        [Test]
        public void TestCircle()
        {
            var dot = new Dot();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
            
            dot.MoveUp();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(1,dot.Position.Y);
            
            dot.MoveRight();
            
            Assert.AreEqual(1,dot.Position.X);
            Assert.AreEqual(1,dot.Position.Y);
            
            dot.MoveDown();
            
            Assert.AreEqual(1,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
            
            dot.MoveLeft();
            
            Assert.AreEqual(0,dot.Position.X);
            Assert.AreEqual(0,dot.Position.Y);
            
            
        }
    }
}