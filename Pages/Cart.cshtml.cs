using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheWaterProject2.Infrastructure;
using TheWaterProject2.Models;

namespace TheWaterProject2.Pages;

public class CartModel : PageModel
{
    private IWaterRepository _repo;
    public CartModel(IWaterRepository temp)
    {
        _repo = temp;
    }
    public Cart? Cart { get; set; }
    public string ReturnUrl { get; set; } = "/";
    public void OnGet(string returnUrl)
    {
        ReturnUrl = returnUrl ?? "/";
        Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
    }

    public IActionResult OnPost(int projectId, string returnUrl)
    {
        Project proj = _repo.Projects
            .FirstOrDefault(x => x.ProjectId == projectId);

        if (proj != null)
        {
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(proj, 1);
            HttpContext.Session.SetJson("cart", Cart);
        }

        return RedirectToPage(new { returnUrl = returnUrl });
    }
}