using Shared.Models;
using System.Net.Http.Json;

namespace Client.Services
{
    internal sealed class InMemoryDBC
    {
        private readonly HttpClient _httpClient;

        public InMemoryDBC(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
