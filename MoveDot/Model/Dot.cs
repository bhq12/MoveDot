namespace MoveDot.Model
{
    public class Dot
    {
        private Coordinate _position;

        public Coordinate Position
        {
            get { return _position; }
        }

        public Dot()
        {
            _position = new Coordinate(0,0);
        }

        public void MoveLeft()
        {
            _position.X--;
        }
        
        public void MoveRight()
        {
            _position.X++;
        }

        public void MoveUp()
        {
            _position.Y++;
        }

        public void MoveDown()
        {
            _position.Y--;
        }
    }
}