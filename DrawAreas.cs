using System.Collections.Generic;

namespace FlyingDutchman
{
    public class DrawAreas : List<DrawArea>
    {
        public int Width { get; private set; }

        public int Height { get; private set; }

        public int Offset { get; private set; }

        public DrawAreas(int width, int height, int offset)
        {
            Width = width;
            Height = height;
            Offset = offset;
        }

        /// <summary>
        /// Check if any area is overlapping
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="offSet"></param>
        /// <returns>True if point is at least in one area or of the rim</returns>
        public bool InAreas(int left, int top)
        {
            var result = (left <= 0)
                            || (left >= Width - Offset)
                            || (top <= 0)
                            || (top >= Height-Offset);

            foreach (var item in this)
            {
                result = result 
                            || item.InArea(left, top, Offset);
            }

            return result;
        }
    }
}
