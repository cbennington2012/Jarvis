using System;
using System.Collections.Generic;

namespace Jarvis.Presentation.Dtos.MediaTypes
{
    public class MusicMediaTypeDto : MediaTypeDto
    {
        public String Album { get; set; }
        public String Artist { get; set; }
        public String Folder { get; set; }
        public List<MusicTrackDto> Tracks { get; set; } 
    }
}
