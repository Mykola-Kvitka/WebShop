using Microsoft.AspNetCore.Http;
using System.IO;

namespace WebShop.BL.Helpers
{
    public static class ImageSaveHelper
    {
        public static string SaveImageAndGeneratePath(IFormFile image, string directory)
        {
            string path = directory + "/" + image.FileName;

            bool num = false;

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (File.Exists(path + "#1"))
            {
                int repeat = 0;
                int iter = 0;
                string numbers = "";
                for (int i = 0; i < path.Length; i++)
                {
                    var p = path.ToCharArray();
                    if (p[i] == '#' && !num)
                    {
                        num = true;
                        iter = i;
                    }
                    if (num)
                    {
                        numbers = p.ToString();
                    }
                }
                path.Remove(iter);
                int.TryParse(numbers, out repeat);

                path += "#" + (++repeat).ToString();
            }
            else
            {
                path += "#1";
            }

            using (var fileStream = new FileStream(directory + "/" + path, FileMode.Create))
            {
                image.CopyToAsync(fileStream);
            }

            return path;
        }
        public static string UpdateImageAndGeneratePath(IFormFile image, string directory, string currentImage)
        {
            File.Delete(currentImage);

            return SaveImageAndGeneratePath(image, directory);
        }

    }
}
