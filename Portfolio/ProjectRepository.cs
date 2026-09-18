namespace Manzano_Portfolio_Quiz.Models
{
    public class ProjectRepository
    {
        private static readonly List<Project> _projects = new()
    {
        new Project
        {
            Id = 1,
            Title = "IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro",
            ShortDescription = "We do our multiple choice Pre final exam with codes to run an application to see our answer",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro.git"
            //ThumbnailPath =
        }
    };

        public IEnumerable<Project> GetAll() => _projects;

        public Project? GetById(int id) => _projects.FirstOrDefault(p => p.Id == id);

        public void AddComment(int projectId, Comment comment)
        {
            var project = GetById(projectId);
            if (project != null)
            {
                comment.Id = project.Comments.Count + 1;
                project.Comments.Add(comment);
            }
        }
    }
}
