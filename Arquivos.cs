using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mslearn_dotnet_files
{
    class econtrarArquivos
    {
        internal static IEnumerable<string> FindFiles(string foldername)
        {

            List<string> salesFiles = new List<string>();

            var foundFiles = Directory.EnumerateFiles(foldername, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
            {
                salesFiles.Add(file);
            }
            return salesFiles; // Retorna uma lista
        }
    }
}