using System;
using System.IO;
using System.Linq;
using Acme.BookStore.Domain;

namespace Acme.BookStore.Web.Tests
{
    public static class WebContentDirectoryFinder
    {
        public static string CalculateContentRootFolder()
        {
            var domainAssemblyDirectoryPath = Path.GetDirectoryName(typeof(BookStoreDomainModule).Assembly.Location);

            if (domainAssemblyDirectoryPath == null)
            {
                throw new Exception($"Could not find location of {typeof(BookStoreDomainModule).Assembly.FullName} assembly!");
            }

            var directoryInfo = new DirectoryInfo(domainAssemblyDirectoryPath);

            while (!DirectoryContains(directoryInfo.FullName, "Acme.BookStore.sln"))
            {
                if (directoryInfo.Parent == null)
                {
                    throw new Exception("Could not find content root folder!");
                }

                directoryInfo = directoryInfo.Parent;
            }

            var webFolder = Path.Combine(directoryInfo.FullName, $"src{Path.DirectorySeparatorChar}Acme.BookStore.Web");

            if (Directory.Exists(webFolder))
            {
                return webFolder;
            }


            throw new Exception("Could not find root folder of the web project!");
        }

        private static bool DirectoryContains(string directory, string filename)
        {
            return Directory.GetFiles(directory).Any(filePath => string.Equals(Path.GetFileName(filePath), filename));
        }

    }
}
