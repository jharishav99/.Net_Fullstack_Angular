using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiddlewareAssignment.Pages
{
    public class ItemsModel : PageModel
    {
        [BindProperty] // Links the form input to this property [cite: 235]
        public string NewItemName { get; set; }

        // Static list to keep data alive while the app runs [cite: 240]
        public static List<string> ItemList { get; set; } = new List<string> { "Visual Studio", ".NET Core" };

        public void OnGet() { }

        public IActionResult OnPost() // Handles form submission [cite: 228, 241]
        {
            if (!string.IsNullOrEmpty(NewItemName))
            {
                ItemList.Add(NewItemName);
            }
            return RedirectToPage(); // Updates the display dynamically [cite: 240]
        }
    }
}