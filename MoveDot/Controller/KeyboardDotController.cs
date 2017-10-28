using System;
using System.ComponentModel;
using MoveDot.Model;
using MoveDot.View;

namespace MoveDot.Controller
{
    public class KeyboardDotController : IDotController
    {
        private Dot _dot;
        private IDotView _view;
        public KeyboardDotController(Dot dot, IDotView view)
        {
            _dot = dot;
            _view = view;
        }

        public void Run()
        {
            _view.Update();
            while (true)
            {
                var keyPress = Console.ReadKey(true);
                MapPress(keyPress);
            }
        }

        public void MapPress(ConsoleKeyInfo keyPress)
        {
            switch (keyPress.Key)
            {
                case ConsoleKey.UpArrow:
                    _dot.MoveUp();
                    _view.Update();
                    break;
                case ConsoleKey.DownArrow:
                    _dot.MoveDown();
                    _view.Update();
                    break;
                case ConsoleKey.LeftArrow:
                    _dot.MoveLeft();
                    _view.Update();
                    break;
                case ConsoleKey.RightArrow:
                    _dot.MoveRight();
                    _view.Update();
                    break;
            }
            
        }
    }
}