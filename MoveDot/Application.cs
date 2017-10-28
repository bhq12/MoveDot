using System.ComponentModel;
using MoveDot.Controller;
using MoveDot.Model;
using MoveDot.View;

namespace MoveDot
{
    public class Application
    {
        private Dot _dot;
        private IDotView _view;
        private IDotController _controller;

        public Application()
        {
            _dot = new Dot();
            //_view = new SimpleDotView(_dot);
            _view = new ConsoleDotView(_dot);
            _controller = new KeyboardDotController(_dot, _view);
            
        }

        public void StartUp()
        {
            _view.Update();
            _controller.Run();
        }
        
    }
}