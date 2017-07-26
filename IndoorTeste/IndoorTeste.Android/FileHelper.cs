using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IndoorTeste.Helpers;
using Xamarin.Forms;
using IndoorTeste.Droid;

[assembly: Dependency(typeof(FileHelper))]
namespace IndoorTeste.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}