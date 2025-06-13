using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace mslearn_dotnet_files
{
    class Programa
    {
        private static void Main(string[] args)
        {
            // Puxa lista de arquivos 

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Directory.SetCurrentDirectory(docPath);
            var salesFiles = econtrarArquivos.FindFiles("Tecsat");

            foreach (var file in salesFiles)
            {
                Console.WriteLine(file);
            }

            char separator = Path.DirectorySeparatorChar;

            LocalVariableInfo teste = new LocalVariableInfo();

            string fileName = $"stores{separator}201{separator}sales{separator}sales.json";
            FileInfo info = new FileInfo(fileName);
            Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more
        }

    }
}