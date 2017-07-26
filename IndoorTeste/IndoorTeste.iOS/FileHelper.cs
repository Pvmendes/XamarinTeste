using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using IndoorTeste.iOS;
using Xamarin.Forms;
using IndoorTeste.Helpers;

[assembly: Dependency(typeof(FileHelper))]
namespace IndoorTeste.iOS
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}