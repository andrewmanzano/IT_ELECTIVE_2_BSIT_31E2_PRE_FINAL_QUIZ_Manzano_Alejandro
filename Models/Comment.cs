namespace Manzano_Portfolio_Quiz.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}