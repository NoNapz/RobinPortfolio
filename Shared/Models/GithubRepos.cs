namespace Shared.Models
{
    public class GithubRepos
    {
        public string Name { get; set; }
        public string Full_Name { get; set; }
        public Owner Owner { get; set; }
        public string Html_Url { get; set; }
        public object Description { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Language { get; set; }
        public string Visibility { get; set; }
    }
    public class Owner
    {
        public string Login { get; set; }
        public string Avatar_Url { get; set; }
    }
}
