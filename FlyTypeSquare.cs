using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace FlyingDutchman
{
    public class FlyTypeSquare : IFlyType
    {
        public void DrawFly(Image<Rgba32> image, int left, int top)
        {
            image[left, top] = Rgba32.Red;
            image[left + 1, top] = Rgba32.Red;
            image[left + 2, top] = Rgba32.Red;
            image[left + 3, top] = Rgba32.Red;
            image[left + 4, top] = Rgba32.Red;

            image[left, top + 1] = Rgba32.Red;
            image[left + 4, top + 1] = Rgba32.Red;

            image[left, top + 2] = Rgba32.Red;
            image[left + 4, top + 2] = Rgba32.Red;

            image[left, top + 3] = Rgba32.Red;
            image[left + 4, top + 3] = Rgba32.Red;

            image[left, top + 4] = Rgba32.Red;
            image[left + 4, top + 4] = Rgba32.Red;

            image[left, top + 4] = Rgba32.Red;
            image[left + 1, top + 4] = Rgba32.Red;
            image[left + 2, top + 4] = Rgba32.Red;
            image[left + 3, top + 4] = Rgba32.Red;
            image[left + 4, top + 4] = Rgba32.Red;
        }
    }
}
