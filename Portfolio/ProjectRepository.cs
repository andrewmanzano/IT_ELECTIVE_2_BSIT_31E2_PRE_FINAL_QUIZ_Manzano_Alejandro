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
            ShortDescription = "We do the FizzBuzz algorithm by outputting numbers and conditional text based on divisibility rules.",
            DetailedDescription = "It uses loop iterations and modulo arithmetic to print Fizz for multiples of 3, Buzz for multiples of 5, FizzBuzz for multiples of both, and standard integer values for all other numbers.",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_A1_MANZANO_ALEJANDRO.git",
            ThumbnailPath = "/image/A1.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 2,
            Title = "BSIT31E2_PRELIM_A2_Manzano_Alejandro",
            ShortDescription = "A simple project that performs basic math operations like addition, subtraction, multiplication, and division.",
            DetailedDescription = "It prompts the user to enter two numbers and select an operator (+, -, *, /) to compute and display the mathematical result. The program runs in a continuous loop until the user types 'exit' to quit.",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_A2_Manzano_Alejandro.git",
            ThumbnailPath = "/image/A2.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 3,
            Title = "BSIT31E2_PRELIM_H1_MANZANO_ALEJANDRO",
            ShortDescription = "A menu-driven terminal tool built to track student profiles, record academic marks, and analyze performance metrics.",
            DetailedDescription = "This application allows users to register student entries, log multiple grade values, and view calculated performance summaries. It structures stored records into structured outputs to quickly identify class averages and peak achievements.",
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
            ShortDescription = "An object-oriented unit testing suite that verifies vehicle inheritance, interface implementations, and polymorphic factory behaviors.",
            DetailedDescription = "This console application executes a suite of automated unit checks to validate core Object-Oriented Programming concepts. It asserts that distinct transport entities (Car, Airplane, Boat) properly inherit from a base Vehicle class, implement dedicated capability interfaces (IDriveable, IFlyable, ISailable), and resolve dynamically through polymorphic factory logic.",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT_31E2_PRELIM_Q1_Manzano_Alejandro.git",
            ThumbnailPath = "/image/Q1.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 6,
            Title = "BSIT-31E2-PRELIM-A3-MANZANO-ALEJANDRO",
            ShortDescription = "A client that sends HTTP requests to REST APIs and formats fetched JSON payload responses.",
            DetailedDescription = "Using .NET’s HttpClient, this utility establishes a connection to an external web service to pull structured endpoint data.",
            GitHubUrl = "https://github.com/andrewmanzano/BSIT-31E2-PRELIM-A3-MANZANO-ALEJANDRO.git",
            ThumbnailPath = "/image/A3.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 7,
            Title = "IT-ELECTIVE-2-PRELIM-EXAM-MANZANO-ALEJANDRO",
            ShortDescription = "A hands-on coding examination designed to test C# mastery by writing code solutions to fulfill automated test specifications and score points.",
            DetailedDescription = "This practical exam application contains 10 structured coding challenges designed to measure core C# proficiency. To earn a passing score, precise logic had to be authored across topics like private field encapsulation, custom constructors, method overloading, class inheritance, method overriding, and interfaces.",
            GitHubUrl = "https://github.com/andrewmanzano/IT-ELECTIVE-2-PRELIM-EXAM-MANZANO-ALEJANDRO.git",
            ThumbnailPath = "/image/Prelim-Exam.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 8,
            Title = "IT_ELECTIVE_2_Midterm_A1_Manzano_Alejandro",
            ShortDescription = "A clean, responsive web application presenting personal software development achievements, background information, and skills.",
            DetailedDescription = "Built using ASP.NET Core MVC and Bootstrap, this landing page features a hero header section with profile information, interactive navigational tabs, and detailed \"About Me\" biography panels.",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_Midterm_A1_Manzano_Alejandro.git",
            ThumbnailPath = "/image/MA1.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 9,
            Title = "-IT_ELECTIVE_BSIT_31E2_-MANZANO_ALEJANDRO-",
            ShortDescription = "A web application implementing secure user authentication and landing page redirection.",
            DetailedDescription = "manages account access control, routing verified users to a dedicated dashboard upon successful credential submission.",
            GitHubUrl = "https://github.com/andrewmanzano/-IT_ELECTIVE_BSIT_31E2_-MANZANO_ALEJANDRO-.git",
            ThumbnailPath = "/image/Simple_login_page.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 10,
            Title = "IT_ELECTIVE_2_MIDTERM_Q2_MANZANO_ALEAJNDRO",
            ShortDescription = "A web application designed to manage, organize, and play music playlists, protected by a user authentication.",
            DetailedDescription = "This web application allows users to create, view, and organize custom music playlists and song collections. Access to the playlist dashboard is secured behind a login authentication portal that validates user credentials before granting access to playlist features.",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_Q2_MANZANO_ALEAJNDRO.git",
            ThumbnailPath = "/image/MQ2.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 11,
            Title = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3_MANZANO_ALEJANDRO",
            ShortDescription = "A product catalog and POS system featuring item listings, shopping cart updates, and price calculations.",
            DetailedDescription = "It implements a digital store catalog layout. Users can browse software and peripheral items, adjust item quantities directly in the grid view, add products to an active cart, and process checkout summaries dynamically.",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_MANZANO_ALEJANDRO.git",
            ThumbnailPath = "/image/MH1_H2_H3.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 12,
            Title = "IT_ELECTIVE_2_MIDTERM_EXAM_8_Manzano_Alejandro",
            ShortDescription = "A conference management dashboard built to register attendees, track check-in status, and monitor event participant details.",
            DetailedDescription = "Developed for event administration, this platform provides real-time attendee tracking and status logging. Administrators can record check-in timestamps, search registered participants, and perform full CRUD operations on conference attendee records through a clean administrative table view.",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_EXAM_8_Manzano_Alejandro.git",
            ThumbnailPath = "/image/M_E_8.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 13,
            Title = "IT_ELECTIVE_2_MIDTERM_Q3_Manzano_Alejandro",
            ShortDescription = "A secure login authentication system featuring attempt tracking up to 3 attempts, remaining try alerts, and account lockout protections.",
            DetailedDescription = "To implements authentication security by monitoring failed login attempts. When incorrect credentials are submitted, the system alerts the user with dynamic error feedback showing remaining login tries before temporary lockout.",
            GitHubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_Q3_Manzano_Alejandro.git",
            ThumbnailPath = "/image/M_Q3.png",
            Comments = new List<Comment>()
        },

        new Project

        {
            Id = 14,
            Title = "Manzano-Prefinal-Activity",
            ShortDescription = "An ASP.NET Core Identity authentication portal supporting local user accounts, registration, password recovery, and external login integrations.",
            DetailedDescription = "Built using ASP.NET Core Identity, this pre-final activity features a user management workflow. It includes local email/password login forms, user account registration, password reset utilities, email confirmation links, and architecture for third-party external authentication providers.",
            GitHubUrl = "https://github.com/andrewmanzano/Manzano-Prefinal-Activity.git",
            ThumbnailPath = "/image/PreFinal_Act.png",
            Comments = new List<Comment>()
        },

        new Project
        {
            Id = 15,
            Title = "IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro",
            ShortDescription = "A web application built as a practical exam where multiple-choice questions, options, and selected answers are dynamically rendered on-screen.",
            DetailedDescription = "Instead of taking a traditional paper or online form test, this project required constructing a full ASP.NET Core web application to serve as the exam engine. The platform dynamically loads web development questions, choices, and submitted answers directly within the UI layout.",
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
