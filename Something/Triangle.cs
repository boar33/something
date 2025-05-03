namespace Something
{
    internal class Triangle
    {
        private int _base;
        private int _height;

        public Triangle(int b, int height)
        {
            _base = b;
            _height = height;
        }

        public int CalculateArea()
        {
            return (_base * _height) / 2;
        }

        public string AsString()
        {
            return $"Base is {_base}, height is {_height}";
        }
    }
}
