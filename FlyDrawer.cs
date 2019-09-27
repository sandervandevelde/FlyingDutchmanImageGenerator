using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace FlyingDutchman
{
    public class FlyDrawer
    {
        Image<Rgba32> _image;

        public DrawAreas DrawAreas { get; private set; }

        /// <summary>
        /// Remember the draw areas on the canvas. Prevent overlap.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="offset"></param>
        public FlyDrawer(Image<Rgba32> image, int offset)
        {
            _image = image;
            DrawAreas = new DrawAreas(image.Width, image.Height, offset);
        }

        public void DrawFly(int left, int top, IFlyType flyType)
        {
            flyType.DrawFly(_image, left, top);

            DrawAreas.Add(new DrawArea(left, left+4, top, top+4, flyType.ToString()));
        }
    }
}
