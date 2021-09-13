using System.Threading.Tasks;
using CineMania.Data;
using CineMania.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CineMania.Pages.contact
{
    #region one for config my context
    
    public class contacts : PageModel
    {
        private readonly CinemaniaContext _context;

        public contacts(CinemaniaContext context)
        {
            _context = context;
        }
        
        #endregion

        #region two for savings my data
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public ContactMe Contact { get; set; }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Contacts.Add(Contact);
            await _context.SaveChangesAsync();

            return RedirectToAction("./Index", "index", new { area = "pages/index" });
           
        }
        #endregion
    }
        

    }


