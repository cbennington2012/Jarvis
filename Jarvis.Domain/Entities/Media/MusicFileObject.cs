using System;

namespace Jarvis.Domain.Entities.Media
{
    public class MusicFileObject : FileObject
    {
        public String Track { get; set; }
        public String Album { get; set; }
        public String Artist { get; set; }
        public String Length { get; set; }
    }
}
