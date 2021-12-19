using Client.Static;
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

        private List<BlogPost> _blogPosts = null;
        internal List<BlogPost> BlogPost
        {
            get
            {
               return _blogPosts;
            }
            set
            {
                _blogPosts = value;
                NotifyDataChange();
            }
        }

        private bool _getBlogFromDatabase = false;
        internal async Task GetBlogFromDatabase()
        {
            // Only allow one Get request to run at a time.
            if (_getBlogFromDatabase == false)
            {
                _getBlogFromDatabase = true;
                _blogPosts = await _httpClient.GetFromJsonAsync<List<BlogPost>>(APIEndpoints.s_blogposts);
                _getBlogFromDatabase = false;
            }
        }

        internal event Action OnDataChanged;
        private void NotifyDataChange() => OnDataChanged?.Invoke();

    }
}
