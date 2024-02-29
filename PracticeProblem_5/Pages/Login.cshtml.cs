using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeProblem_5.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            // Optional: Handle initial page load
        }

        public IActionResult OnPost(string username, string password)
        {
            // Validate username and password (not implemented in this example)
            if (username == "admin" && password == "password")
            {
                // Redirect to dashboard page upon successful login
                return RedirectToPage("/Dashboard");
            }
            else
            {
                // Optionally handle failed login attempt
                return Page();
            }
        }
    }
}
