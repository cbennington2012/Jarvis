using System;
using Jarvis.Domain.Enumerations;

namespace Jarvis.Domain.Entities.Media
{
    public class FileObject
    {
        public String Name { get; set; }
        public String Location { get; set; }
        public MediaCategory Category { get; set; }
    }
}
