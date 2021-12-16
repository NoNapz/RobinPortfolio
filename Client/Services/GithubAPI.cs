using Shared.Models;
using System.Net.Http.Json;

namespace Client.Services
{
    internal sealed class GithubAPI
    {
        private readonly HttpClient _httpClient;
        internal List<GithubRepos> GitRepos { get; set; }

        public GithubAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private string GitAPIUri = "https://api.github.com/users/NoNapz/repos";
        string errorMessage;
        internal async Task GetGitHubData()
        {
            try
            {
                GitRepos = await _httpClient.GetFromJsonAsync<List<GithubRepos>>(GitAPIUri);
                errorMessage = null;
            }
            catch (Exception ex)
            {
                errorMessage = $"Error getting github data at this time: {ex}";
            }
        }
    }
}