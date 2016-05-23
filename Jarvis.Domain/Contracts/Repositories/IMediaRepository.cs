using System.Collections.Generic;
using Jarvis.Domain.Entities.Media;

namespace Jarvis.Domain.Contracts.Repositories
{
    public interface IMediaRepository
    {
        void Discover();
        IList<MusicFileObject> GetMusic();
    }
}
