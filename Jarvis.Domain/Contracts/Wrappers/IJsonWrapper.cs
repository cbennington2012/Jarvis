using System;

namespace Jarvis.Domain.Contracts.Wrappers
{
    public interface IJsonWrapper
    {
        String SerializeObject(Object data);
    }
}
