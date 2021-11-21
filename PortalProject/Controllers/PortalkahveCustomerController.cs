using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortalProject.Controllers
{
    public class PortalkahveCustomerController : Controller
    {
        PortalkahveCustomerManager pm = new PortalkahveCustomerManager(new EfPortalkahveCustomerRepository());

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(PortalkahveCustomer p)
        {
            pm.TAdd(p);
            return RedirectToAction("Index", "PortalkahveCustomer");
        }
    }
}
