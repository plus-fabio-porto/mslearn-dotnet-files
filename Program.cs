using System;
using System.Collections.Generic;
using System.IO;

// Puxa lista de arquivos 

string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Directory.SetCurrentDirectory(docPath);
var salesFiles = FindFiles("TECSAT");


foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}

/*
string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);

Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more

*/

IEnumerable<string> FindFiles(string foldername)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(foldername, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {

            salesFiles.Add(file);

    }
    
    return salesFiles; // Retorna uma lista
}
