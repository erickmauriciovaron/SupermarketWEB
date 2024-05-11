using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Account
{
    public class DeleteModel : PageModel
    {
        private readonly SupermarketContext _context;
        public DeleteModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User Acounts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Acounts.FirstOrDefaultAsync(m => m.Id == id);


            if (user == null)
            {
                return NotFound();
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Acounts.FindAsync(id);

            if (user != null)
            {
                Acounts = user;
                _context.Acounts.Remove(Acounts);
                await _context.SaveChangesAsync();

            }

            return RedirectToPage("./Index");
        }
    }
}
