//Complete

using System;
using System.IO;

namespace Exercise26
{
    class Program26
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            Console.WriteLine(Environment.CurrentDirectory);

            var path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            FileStream txt = new FileStream($"{path}/CSharp.txt", FileMode.Create);
            txt.Close();
        }
    }
}
