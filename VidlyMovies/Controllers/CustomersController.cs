using System.Linq;
using System.Web.Mvc;
using VidlyMovies.Models;
using System.Data.Entity;

namespace VidlyMovies.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
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
            var customer = _context.Customers.Include(i => i.MembershipType).ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(s => s.Id == id);

            if(customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}