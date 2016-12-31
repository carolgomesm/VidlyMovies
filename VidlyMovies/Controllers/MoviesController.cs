using System.Linq;
using System.Web.Mvc;
using VidlyMovies.Models;
using System.Data.Entity;

namespace VidlyMovies.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customer = _context.Movies.ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(s => s.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
    }
}