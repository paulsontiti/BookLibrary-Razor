using BookLibrary_Razor.Data;
using BookLibrary_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary_Razor.Pages.Category
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        [BindProperty]
        public BookCategory category { get; set; }

        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
           
        }

        public IActionResult OnPost(BookCategory category)
        {
            if (_db.BookCategories.FirstOrDefault(cat => cat.Name.ToLower() == category.Name.ToLower()) != null)
            {
                ModelState.AddModelError("Name", "Name already exist");
                return Page();
            }
            if (ModelState.IsValid)
            {
                _db.BookCategories.Add(category);
                _db.SaveChanges();
            }
            return RedirectToPage("Index");
        }
    }
}
