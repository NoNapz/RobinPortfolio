namespace Shared.Models
{
    public class GithubRepos
    {
        public string Name { get; set; } = String.Empty;
        public string Full_Name { get; set; } = String.Empty;
        public Owner? Owner { get; set; }
        public string Html_Url { get; set; } = String.Empty;
        public object Description { get; set; } = String.Empty;
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Language { get; set; } = String.Empty;
        public string Visibility { get; set; } = String.Empty;
    }
    public class Owner
    {
        public string Login { get; set; } = String.Empty;
        public string Avatar_Url { get; set; } = String.Empty;
    }
}
