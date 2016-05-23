using System;

namespace Jarvis.Presentation.Dtos.MediaTypes
{
    public class MusicTrackDto
    {
        public String File { get; set; }
        public int TrackNumber { get; set; }
        public String Title { get; set; }
        public String Artist { get; set; }
        public String Album { get; set; }
        public String Length { get; set; }
    }
}
