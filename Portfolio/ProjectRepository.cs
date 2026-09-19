using System.Xml.Linq;

namespace Manzano_Portfolio_Quiz.Models
{
    public class ProjectRepository
    {
        private static readonly List<Project> _projects = new()
    {
        new Project
        {
            Id = 1,
            Title = "BSIT31E2_PRELIM_A1_MANZANO_ALEJANDRO",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_A1_MANZANO_ALEJANDRO.git",
            ThumbnailPath = "/image/A1.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 2,
            Title = "BSIT31E2_PRELIM_A2_Manzano_Alejandro",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_A2_Manzano_Alejandro.git",
            ThumbnailPath = "/image/A2.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 3,
            Title = "BSIT31E2_PRELIM_H1_MANZANO_ALEJANDRO",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_H1_MANZANO_ALEJANDRO.git",
            ThumbnailPath = "/image/H1.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 4,
            Title = "BSIT31E2_PRELIM_H2_MANZANO_ALEJANDRO",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_H2_MANZANO_ALEJANDRO.git",
            //ThumbnailPath = "/image/H2.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 5,
            Title = "BSIT_31E2_PRELIM_Q1_Manzano_Alejandro",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT_31E2_PRELIM_Q1_Manzano_Alejandro.git",
            ThumbnailPath = "/image/Q1.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 6,
            Title = "BSIT-31E2-PRELIM-A3-MANZANO-ALEJANDRO",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT-31E2-PRELIM-A3-MANZANO-ALEJANDRO.git",
            ThumbnailPath = "/image/A3.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 7,
            Title = "IT-ELECTIVE-2-PRELIM-EXAM-MANZANO-ALEJANDRO",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/IT-ELECTIVE-2-PRELIM-EXAM-MANZANO-ALEJANDRO.git",
            ThumbnailPath = "/image/Prelim-Exam.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 8,
            Title = "IT_ELECTIVE_2_Midterm_A1_Manzano_Alejandro",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_Midterm_A1_Manzano_Alejandro.git",
            ThumbnailPath = "/image/MA1.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 9,
            Title = "-IT_ELECTIVE_BSIT_31E2_-MANZANO_ALEJANDRO-",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/-IT_ELECTIVE_BSIT_31E2_-MANZANO_ALEJANDRO-.git",
            ThumbnailPath = "/image/Simple_login_page.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 10,
            Title = "IT_ELECTIVE_2_MIDTERM_Q2_MANZANO_ALEAJNDRO",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_Q2_MANZANO_ALEAJNDRO.git",
            ThumbnailPath = "/image/MQ2.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 11,
            Title = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3_MANZANO_ALEJANDRO",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_MANZANO_ALEJANDRO.git",
            ThumbnailPath = "/image/MH1_H2_H3.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 12,
            Title = "IT_ELECTIVE_2_MIDTERM_EXAM_8_Manzano_Alejandro",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_EXAM_8_Manzano_Alejandro.git",
            ThumbnailPath = "/image/M_E_8.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 13,
            Title = "IT_ELECTIVE_2_MIDTERM_Q3_Manzano_Alejandro",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_Q3_Manzano_Alejandro.git",
            ThumbnailPath = "/image/M_Q3.png",
            Comments = new List<Comment>()
        },

        new Project

        {
            Id = 14,
            Title = "Manzano-Prefinal-Activity",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/Manzano-Prefinal-Activity.git",
            ThumbnailPath = "/image/PreFinal_Act.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 15,
            Title = "IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro.git",
            ThumbnailPath = "/image/PreFina_Exam.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 15,
            Title = "IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro",
            ShortDescription = "Not done yet",
            DetailedDescription = "yes",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro.git",
            ThumbnailPath = "/image/PreFinal_Exam.png",
            Comments = new List<Comment>()
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
