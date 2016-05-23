using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Jarvis.Domain.Contracts.Repositories;
using Jarvis.Domain.Contracts.Wrappers;
using Jarvis.Domain.Enumerations;
using Jarvis.Presentation.Dtos;
using Jarvis.Presentation.Dtos.MediaTypes;

namespace Jarvis.Api.Controllers
{
    [RoutePrefix("api/media")]
    public class MediaController : ApiController
    {
        private readonly IJsonWrapper _jsonWrapper;
        private readonly IEnumWrapper _enumWrapper;
        private readonly IMediaRepository _mediaRepository;

        public MediaController(IJsonWrapper jsonWrapper, IEnumWrapper enumWrapper, IMediaRepository mediaRepository)
        {
            _jsonWrapper = jsonWrapper;
            _enumWrapper = enumWrapper;
            _mediaRepository = mediaRepository;
        }

        [Route("listcategories")]
        [HttpGet]
        public String ListCategories()
        {
            var results = _enumWrapper.GetNames(typeof (MediaCategory)).Select(item => new MediaCategoryDto
            {
                Name = item, FolderName = String.Format("{0}\\", item), Category = (MediaCategory) _enumWrapper.GetEnumFromValue(item, typeof (MediaCategory))
            }).ToList();

            return _jsonWrapper.SerializeObject(results);
        }

        [Route("listcategoryentries")]
        [HttpGet]
        public String ListCategoryEntries(MediaCategoryDto mediaCategory)
        {
            var results = new List<MediaCategoryEntryDto>
            {
                new MediaCategoryEntryDto
                {
                    Name = "Various Artists",
                    Folder = "Various Artists\\",
                    Category = MediaCategory.Music,
                    Entries = new List<MediaTypeDto>
                    {
                        new MusicMediaTypeDto
                        {
                            Album = "Guardians of the Galaxy- Awesome Mix, Vol. 1",
                            Artist = "Various Artists",
                            Folder = "Guardians of the Galaxy- Awesome Mix, Vol. 1\\",
                            Tracks = new List<MusicTrackDto>
                            {
                                new MusicTrackDto
                                {
                                    File = "01 Hooked on a Feeling.mp3",
                                    TrackNumber = 1,
                                    Title = "Hooked on a Feeling",
                                    Artist = "Blue Swede",
                                    Album = "Guardians of the Galaxy- Awesome Mix, Vol. 1",
                                    Length = "00:02:54"
                                },
                                new MusicTrackDto
                                {
                                    File = "02 Go All the Way.mp3",
                                    TrackNumber = 2,
                                    Title = "Go All the Way",
                                    Artist = "The Raspberries",
                                    Album = "Guardians of the Galaxy- Awesome Mix, Vol. 1",
                                    Length = "00:03:22"
                                }
                            }
                        }
                    }
                }
            };

            return _jsonWrapper.SerializeObject(results);
        }
    }
}