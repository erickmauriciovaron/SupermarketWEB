using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Security.Principal;

namespace SupermarketWEB.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;
        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<User> Acounts { get; set; }
        public async Task OnGetAsync()
        {
            
            
            Acounts = await _context.Acounts.ToListAsync();
            
        }
    }
}
