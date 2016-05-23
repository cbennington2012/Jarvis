using System;
using System.Collections.Generic;
using Jarvis.Domain.Contracts.Configuration;
using Jarvis.Domain.Contracts.Repositories;
using Jarvis.Domain.Contracts.Wrappers;
using Jarvis.Domain.Entities.Media;
using Jarvis.Domain.Enumerations;

namespace Jarvis.Domain.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        private IList<MusicFileObject> _musicFileObjects;

        private readonly IAppSettingsProvider _appSettingsProvider;
        private readonly IEnumWrapper _enumWrapper;
        private readonly IIoWrapper _ioWrapper;

        public MediaRepository(IAppSettingsProvider appSettingsProvider, IEnumWrapper enumWrapper, IIoWrapper ioWrapper)
        {
            _appSettingsProvider = appSettingsProvider;
            _enumWrapper = enumWrapper;
            _ioWrapper = ioWrapper;
        }

        public void Discover()
        {
            _musicFileObjects = new List<MusicFileObject>();

            var mediaHomeFolder = _appSettingsProvider.GetValue(Constants.Settings.MediaHomeFolder);

            foreach (var item in _enumWrapper.GetNames(typeof (MediaCategory)))
            {
                var folderToInspect = String.Concat(mediaHomeFolder, item);
                if (_ioWrapper.DirectoryExists(folderToInspect))
                {
                    foreach (var file in _ioWrapper.ListFiles(folderToInspect))
                    {
                        var details = _ioWrapper.GetDetails(file);
                        if (item == MediaCategory.Music.ToString())
                        {
                            _musicFileObjects.Add(new MusicFileObject
                            {
                                Name = details.Name,
                                Album = "",
                                Artist = "",
                                Category = MediaCategory.Music,
                                Location = file,
                                Length = "",
                                Track = ""
                            });
                        }
                    }
                }
            }
        }

        public IList<MusicFileObject> GetMusic()
        {
            return _musicFileObjects;
        }
    }
}
