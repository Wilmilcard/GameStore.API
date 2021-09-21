using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Utils
{
    public class Archivo
    {
        public int height { set; get; }
        public DateTime timestamp { set; get; }
        public string uri { set; get; }
        public string fileName { set; get; }
        public string data { set; get; }

        public static string SaveFile(string Path, string FileName, string dataFile)
        {
            if (System.IO.File.Exists(Path + FileName))
            {
                FileName = Globals.GetFechaActual().Ticks.ToString() + FileName;
            }
            Byte[] bytes = Convert.FromBase64String(dataFile);
            File.WriteAllBytes(Path + FileName, bytes);
            return FileName;
        }
    }
}
