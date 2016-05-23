using System;
using System.Collections.Generic;
using System.IO;

namespace Jarvis.Domain.Contracts.Wrappers
{
    public interface IIoWrapper
    {
        Boolean DirectoryExists(String path);
        IList<String> ListFiles(String path);
        IList<String> ListDirectories(String path);
        FileInfo GetDetails(String path);
    }
}
