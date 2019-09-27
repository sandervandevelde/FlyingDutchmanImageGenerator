using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace FlyingDutchman
{
    public class FlyTypePointToTop : IFlyType
    {
        public void DrawFly(Image<Rgba32> image, int left, int top)
        {
            image[left + 2, top] = Rgba32.Red;

            image[left + 2, top + 1] = Rgba32.Red;
            
            image[left + 1, top + 2] = Rgba32.Red;
            image[left + 2, top + 2] = Rgba32.Red;
            image[left + 3, top + 2] = Rgba32.Red;

            image[left + 1, top + 3] = Rgba32.Red;
            image[left + 2, top + 3] = Rgba32.Red;
            image[left + 3, top + 3] = Rgba32.Red;

            image[left + 0, top + 4] = Rgba32.Red;
            image[left + 1, top + 4] = Rgba32.Red;
            image[left + 3, top + 4] = Rgba32.Red;
            image[left + 4, top + 4] = Rgba32.Red;
        }

        public override string ToString()
        {
            return ("Top");
        }
    }
}
