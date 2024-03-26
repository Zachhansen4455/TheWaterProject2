using Microsoft.AspNetCore.Mvc;
using TheWaterProject2.Models;

namespace TheWaterProject2.Components;

// this is used to get the filter feature
public class ProjectsTypesViewComponent : ViewComponent
{
    private IWaterRepository _waterRepo;
    
    //access the database through repository. Constructor
    public ProjectsTypesViewComponent(IWaterRepository temp)
    {
        _waterRepo = temp;
    }
    public IViewComponentResult Invoke()
    {
        ViewBag.SelectedProjectType = RouteData?.Values["projectType"];
        
        var projectTypes = _waterRepo.Projects
            .Select(x => x.ProjectType)
            .Distinct()
            .OrderBy(x => x);
        
        return View(projectTypes);
    }
}