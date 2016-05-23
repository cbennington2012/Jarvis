using System;
using Jarvis.Domain.Contracts.Wrappers;
using Newtonsoft.Json;

namespace Jarvis.Infrastructure.Wrappers
{
    public class JsonWrapper : IJsonWrapper
    {
        public String SerializeObject(Object data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
