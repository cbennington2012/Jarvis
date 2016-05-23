using System;
using Jarvis.Domain.Enumerations;

namespace Jarvis.Presentation.Dtos
{
    public class MediaCategoryDto
    {
        public String Name { get; set; }
        public String FolderName { get; set; }
        public MediaCategory Category { get; set; } 
    }
}
