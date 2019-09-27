using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace FlyingDutchman
{
    public interface IFlyType
    {
        void DrawFly(Image<Rgba32> image, int left, int top);

    }
}
