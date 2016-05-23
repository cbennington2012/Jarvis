using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Jarvis.Domain.Contracts.Wrappers;

namespace Jarvis.Infrastructure.Wrappers
{
    public class IoWrapper : IIoWrapper
    {
        public bool DirectoryExists(String path)
        {
            return Directory.Exists(path);
        }

        public IList<String> ListFiles(String path)
        {
            return Directory.EnumerateFiles(path).ToList();
        }

        public IList<String> ListDirectories(String path)
        {
            return Directory.EnumerateDirectories(path).ToList();
        }

        public FileInfo GetDetails(String path)
        {
            return new FileInfo(path);
        }
    }
}
