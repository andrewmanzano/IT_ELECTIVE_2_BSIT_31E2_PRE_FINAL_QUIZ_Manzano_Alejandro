namespace Manzano_Portfolio_Quiz.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string DetailedDescription { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string ThumbnailPath { get; set; } = string.Empty;
        public List<string> Technologies { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
    }
}
