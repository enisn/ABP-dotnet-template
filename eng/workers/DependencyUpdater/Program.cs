using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DependencyUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("/Users/enisnecipoglu/Projects/ABP-dotnet-template/templates/app", "*.csproj", SearchOption.AllDirectories);
            Console.WriteLine("************* Found files:");
            foreach (var file in files)
            {
                Console.WriteLine(file);

                var lines = File.ReadAllText(file).Split('\n').ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    if (IsLocalReference(lines[i]))
                    {
                        lines[i] = ReplaceWithPackage(lines[i]);
                    }
                }

                File.WriteAllLines(file, lines);
            }
        }

        private static bool IsLocalReference(string line)
        {
            return line.Contains("<ProjectReference") && line.Contains("..\\..\\..\\..");
        }

        private static string ReplaceWithPackage(string line, string version = "4.4.0")
        {
            var result = line;

            result = line.Replace("<ProjectReference", "<PackageReference");

            var startingIndex = result.IndexOf('.');
            var voloStartIndex = result.IndexOf("Volo");
            result = result.Remove(startingIndex, voloStartIndex - startingIndex);

            var voloWithSlashIndex = result.IndexOf("\\Volo");
            var csprojIndex = result.IndexOf(".csproj");
            result = result.Remove(voloWithSlashIndex, csprojIndex - voloStartIndex);

            var lastQuoteIndex = result.LastIndexOf('\"');
            result = result.Insert(lastQuoteIndex + 1, $" Version=\"{version}\"");

            return result;
        }
    }
}
