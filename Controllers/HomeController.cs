using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheWaterProject2.Models;
using TheWaterProject2.Models.ViewModels;

namespace TheWaterProject2.Controllers
{
    public class HomeController : Controller
    {
        private IWaterRepository _repo;

        public HomeController(IWaterRepository temp)
        {
            _repo = temp;
        }

        //dont name it page. name var pageNum
        // this is used for pagination. doing 5 records per page
        public IActionResult Index(int pageNum,string? projectType)
        {

            int pageSize = 2;

            var blah = new ProjectsListViewModel
            {
                Projects = _repo.Projects
                    .Where(x => x.ProjectType == projectType || projectType == null)
                    .OrderBy(x => x.ProjectName)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = projectType == null ? _repo.Projects.Count() : _repo.Projects.Where(x => x.ProjectType == projectType).Count()
                },
                
                CurrentProjectType = projectType
            };

            return View(blah);
        }

    }
}
