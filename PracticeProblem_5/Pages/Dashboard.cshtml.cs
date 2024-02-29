using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeProblem_5.Pages
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
            // Optional: Handle initial page load
        }

        public IActionResult OnPost(string logout)
        {
            if (!string.IsNullOrEmpty(logout))
            {
                // Redirect to login page upon logout
                return RedirectToPage("/Login");
            }
            return Page();
        }
    }
}
