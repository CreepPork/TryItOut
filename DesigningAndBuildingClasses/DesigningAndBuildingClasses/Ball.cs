namespace DesigningAndBuildingClasses
{
    public class Ball
    {
        public int Size
        {
            get => _size;
            set
            {
                if (value < 0)
                    _size = 0;
                else
                    _size = value;
            }
        }

        public Color Color { get; set; }

        private int _thrown;
        private int _size;

        public int Thrown
        {
            get => _thrown;
            set
            {
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (value < 0)
                    _thrown = 0;
                else
                    _thrown = value;
            }
        }

        public Ball(int size)
        {
            Size = size;
            Color = new Color(0, 0, 0);
            Thrown = 0;
        }

        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
            Thrown = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                Thrown++;
            }
        }
    }
}