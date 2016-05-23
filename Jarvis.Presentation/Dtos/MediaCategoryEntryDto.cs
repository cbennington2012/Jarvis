using System;
using System.Collections.Generic;
using Jarvis.Domain.Enumerations;
using Jarvis.Presentation.Dtos.MediaTypes;

namespace Jarvis.Presentation.Dtos
{
    public class MediaCategoryEntryDto
    {
        public MediaCategory Category { get; set; }
        public String Name { get; set; }
        public String Folder { get; set; }
        public List<MediaTypeDto> Entries { get; set; } 
    }
}
