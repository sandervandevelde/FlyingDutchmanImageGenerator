using Newtonsoft.Json;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Linq;
using System.IO;

namespace FlyingDutchman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fly test generator");
            Console.WriteLine("==================");
            Console.WriteLine("");
            if (args.Any(x => x.Contains("?")))
            {
                Console.WriteLine("FlyingDutchman.exe [parameters]");
                Console.WriteLine("? = This help");
                Console.WriteLine("p = pause at the end");
            }
            else
            {
                Console.WriteLine("Use 'FlyingDutchman.exe ?' for help");
            }

            Console.WriteLine("");

            try
            {
                System.IO.Directory.CreateDirectory("output");

                Random _random = new Random(DateTime.Now.Second);

                using (var image = new Image<Rgba32>(1000, 1000))
                {
                    var flyTypes = new FlyTypes();

                    var flyDrawer = new FlyDrawer(image, 5);

                    for (int i = 0; i < 100; i++)
                    {
                        var flyAdded = false;
                        while (!flyAdded)
                        {
                            int left = _random.Next(image.Width);
                            int top = _random.Next(image.Height);
                            int fly = _random.Next(0, flyTypes.Count);

                            if (!flyDrawer.DrawAreas.InAreas(left, top))
                            {
                                // point is in non of current areas or over the rim

                                var flyType = flyTypes[fly];

                                Console.Write($"{fly}");

                                flyDrawer.DrawFly(left, top, flyType);

                                flyAdded = true;
                                Console.Write(".");
                            }
                            else
                            {
                                Console.Write("X");
                            }
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine($"Flies drawn: {flyDrawer.DrawAreas.Count}");

                    var fileName = $"output/test{DateTime.Now.ToString("yyyyMMddhhmmssfff")}";

                    image.Save(fileName + ".png");

                    var json = JsonConvert.SerializeObject(flyDrawer.DrawAreas);

                    File.WriteAllText(fileName + ".json", json);

                    Console.WriteLine($"Files generated: {fileName}.png, {fileName}.json");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            if (args.Any(x => x.ToLower() == "p"))
            {
                Console.WriteLine("Press a key to exit");
                Console.ReadKey();
            }
        }
    }
}
