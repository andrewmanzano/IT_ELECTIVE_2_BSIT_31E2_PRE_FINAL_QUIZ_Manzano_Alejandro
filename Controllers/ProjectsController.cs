namespace Manzano_Portfolio_Quiz.Controllers
{
    using Manzano_Portfolio_Quiz.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly ProjectRepository _repo = new();

        public IActionResult Detail(int id)
        {
            var project = _repo.GetById(id);
            if (project == null) return NotFound();
            return View("~/Views/Projects/Detail.cshtml", project);
        }

        [HttpPost]
        public IActionResult AddComment(int projectId, string author, string text)
        {
            if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(author))
            {
                _repo.AddComment(projectId, new Comment { Author = author, Text = text });
            }
            return RedirectToAction("Detail", new { id = projectId });
        }
    }
}
