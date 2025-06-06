using System.IO;
using System.Collections.Generic;

var salesFiles = FindFiles("stores");

string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);

Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more
/*foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}
*/
IEnumerable<string> FindFiles(string foldername)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(foldername, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {

        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }

    }
    
    return salesFiles; // Retorna uma lista
}
