using BookLibrary_Razor.Data;
using BookLibrary_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary_Razor.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public List<BookCategory> categories { get; set; }

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            categories = _db.BookCategories.ToList();
        }
    }
}
