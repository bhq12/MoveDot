using System;
using NUnit.Framework;
using MoveDot.View;
namespace Test
{
    public class TestScreenPaddingCalculator
    {
        [Test]
        public void TestZeroIndex()
        {
            int position = 0;
            int screenSize = 10;
            var offset = ScreenPaddingCalculator.GetScreenPadding(position, screenSize);
            
            Assert.AreEqual(0,offset);
        }
        
        [Test]
        public void TestScreenSize()
        {
            int position = 10;//position 10 equivalent to 0
            int screenSize = 10;
            var offset = ScreenPaddingCalculator.GetScreenPadding(position, screenSize);
            
            Assert.AreEqual(0,offset);
        }
        
        [Test]
        public void TestNegativeOne()
        {
            int position = -1;//position -1 uquivalent to 9, with a padding of 8
            int screenSize = 10;
            var offset = ScreenPaddingCalculator.GetScreenPadding(position, screenSize);
            
            Assert.AreEqual(9,offset);
        }
        
        [Test]
        public void TestOne()
        {
            int position = 1;
            int screenSize = 10;
            var offset = ScreenPaddingCalculator.GetScreenPadding(position, screenSize);
            
            Assert.AreEqual(1,offset);
        }
        
        [Test]
        public void TestWithinScreen()
        {
            int position = 3;
            int screenSize = 10;
            var offset = ScreenPaddingCalculator.GetScreenPadding(position, screenSize);
            
            Assert.AreEqual(3,offset);
        }
        
        [Test]
        public void TestPositiveWrappedWithinScreen()
        {
            int position = 13;
            int screenSize = 10;
            var offset = ScreenPaddingCalculator.GetScreenPadding(position, screenSize);
            
            Assert.AreEqual(3,offset);
        }
        
        [Test]
        public void TestNegativeWrappedWithinScreen()
        {
            int position = -7;
            int screenSize = 10;
            var offset = ScreenPaddingCalculator.GetScreenPadding(position, screenSize);
            
            Assert.AreEqual(3,offset);
        }
        
    }
}