using System.Threading.Tasks;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication
{
    public class AuthorController : Controller
    {
        readonly ApplicationContext context;

        public AuthorController(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await context.Author.ToListAsync());
        }
    }
}