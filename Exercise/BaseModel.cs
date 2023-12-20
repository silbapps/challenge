using Exercise.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise
{
    public class BaseModel : PageModel
    {
        public readonly WebRMContext _context;
        public BaseModel(WebRMContext context)
        {
            _context = context;
        }
    }
}
