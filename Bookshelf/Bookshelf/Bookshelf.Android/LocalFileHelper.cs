using System.IO;
using Xamarin.Forms;
using System;
using Bookshelf.Droid;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace Bookshelf.Droid
{
    public class LocalFileHelper : ILocalFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}