namespace DesigningAndBuildingClasses
{
    public class Color
    {
        private int _red;
        public int Red
        {
            get => _red;
            set
            {
                if (value > 255)
                    _red = 255;
                else if (value < 0)
                    _red = 0;
                else
                    _red = value;
            }
        }
        
        private int _green;
        public int Green
        {
            get => _green;
            set
            {
                if (value > 255)
                    _green = 255;
                else if (value < 0)
                    _green = 0;
                else
                    _green = value;
            }
        }
        
        private int _blue;
        public int Blue
        {
            get => _blue;
            set
            {
                if (value > 255)
                    _blue = 255;
                else if (value < 0)
                    _blue = 0;
                else
                    _blue = value;
            }
        }
        
        private int _alpha;
        public int Alpha
        {
            get => _alpha;
            set
            {
                if (value > 255)
                    _alpha = 255;
                else if (value < 0)
                    _alpha = 0;
                else
                    _alpha = value;
            }
        }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public int Grayscale()
        {
            return (_red + _green + _blue) / 3;
        }
    }
}