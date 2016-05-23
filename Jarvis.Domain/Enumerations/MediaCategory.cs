using System.ComponentModel;

namespace Jarvis.Domain.Enumerations
{
    public enum MediaCategory
    {
        [Description("Music")]
        Music,

        [Description("TV Shows")]
        Tv,

        [Description("Films")]
        Films,

        [Description("Photos")]
        Photos,

        [Description("Videos")]
        Videos
    }
}
