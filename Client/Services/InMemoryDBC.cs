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

        private string GitAPIUri = "https://api.github.com/users/NoNapz/repos";
        private List<GithubRepos> _githubRepos = null;

        internal List<GithubRepos> GitRepos
        {
            get
            {
                return _githubRepos;
            }
            set
            {
                _githubRepos = value;
                NotifyGitRepoDataChanged();
            }
        }

        internal async Task GetGithubReposFromCache()
        {
            _githubRepos = await _httpClient.GetFromJsonAsync<List<GithubRepos>>(GitAPIUri);
        }

        internal event Action OnGitRepoDataChange;
        private void NotifyGitRepoDataChanged() => OnGitRepoDataChange?.Invoke();
        
    }
}
