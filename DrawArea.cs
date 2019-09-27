namespace FlyingDutchman
{
    public class DrawArea
    {
        public int Left { get; private set; }
        public int Right { get; private set; }
        public int Top { get; private set; }
        public int Bottom { get; private set; }
        public string Type { get; private set; }

        public DrawArea(int left, int right, int top, int bottom, string type)
        {
            Left = left;
            Right = right;
            Top = top;
            Bottom = bottom;
            Type = type;
        }

        /// <summary>
        /// Prevent overlap with extra offset
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="offSet"></param>
        /// <returns>Point is in area with consideration of the offset (to the right and to the bottom)</returns>
        public bool InArea(int left, int top, int offSet)
        {
            return (left >= Left)
                        && (left <= Right-offSet)
                        && (top >= Top)
                        && (top <= Bottom - offSet);
        }
    }
}
