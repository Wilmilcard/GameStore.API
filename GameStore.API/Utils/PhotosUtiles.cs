using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Utils
{
    public static class PhotosUtiles
    {
        public static Image<Rgba32> ResizeFixed(Stream image64, int MaxWidth, int MaxMaxHeight)
        {
            SixLabors.ImageSharp.Image<Rgba32> image = (Image<Rgba32>)SixLabors.ImageSharp.Image.Load(image64);
            image.Mutate(x => x
            .Resize(MaxWidth, MaxMaxHeight));
            return image;
        }

        public static Image<Rgba32> ResizePercent(Stream image64, float Percent)
        {
            SixLabors.ImageSharp.Image<Rgba32> image = (Image<Rgba32>)SixLabors.ImageSharp.Image.Load(image64);
            if (Percent > 0)
            {
                float num = Percent;
                int width1 = image.Width;
                int height1 = image.Height;
                int width2 = (int)((double)width1 * (double)num / 100);
                int height2 = (int)((double)height1 * (double)num / 100);
                //
                image.Mutate(x => x
                .Resize(width2, height2));
                return image;
            }
            else
            {
                return image;
            }
        }

        public static string SavePhoto(Archivo photo, string FileName, string Path, float CompressionPercent)
        {
            var imageDataByteArray = Convert.FromBase64String(photo.data);
            var imageDataStream = new MemoryStream(imageDataByteArray);
            imageDataStream.Position = 0;
            string path = Directory.GetCurrentDirectory() + Path;
            if (System.IO.File.Exists(path + FileName))
            {
                FileName = DateTime.Now.Ticks.ToString() + FileName;
            }
            //Resize New
            var NewImagesResized = ResizePercent(imageDataStream, CompressionPercent);
            if (System.IO.File.Exists(path + FileName))
            {
                FileName = DateTime.Now.Ticks.ToString() + FileName;
            }
            NewImagesResized.Save(path + FileName);
            return FileName;
        }

        public static string SavePhoto(string base64img, string FileName, string Path, float CompressionPercent)
        {
            var imageDataByteArray = Convert.FromBase64String(base64img);
            var imageDataStream = new MemoryStream(imageDataByteArray);
            imageDataStream.Position = 0;
            string path = Directory.GetCurrentDirectory() + Path;
            if (System.IO.File.Exists(path + FileName))
            {
                FileName = DateTime.Now.Ticks.ToString() + FileName;
            }
            //Resize New
            var NewImagesResized = ResizePercent(imageDataStream, CompressionPercent);
            if (System.IO.File.Exists(path + FileName))
            {
                FileName = DateTime.Now.Ticks.ToString() + FileName;
            }
            NewImagesResized.Save(path + FileName);
            return FileName;
        }
    }
}
