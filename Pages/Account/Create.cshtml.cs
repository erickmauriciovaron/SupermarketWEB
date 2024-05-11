using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Account
{
    public class CreateModel : PageModel
    {
        private readonly SupermarketContext _context;
        public CreateModel(SupermarketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User Acounts { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid )
            {
                return Page();
            }

            _context.Acounts.Add(Acounts);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
