using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using static Mernis.KPSPublicSoapClient;

namespace PortalProject.Controllers
{
    public class SturbucksCustomerController : Controller
    {
        SturbucksCustomerManager sm = new SturbucksCustomerManager(new EfSturbucksCustomerRepository());
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SturbucksCustomer p)
        {
            bool sonuc = false;
            try
            {
                var mernisClient = new Mernis.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
                var response = await mernisClient.TCKimlikNoDogrulaAsync(p.SturbucksCustomerIdentityNumber, p.SturbucksCustomerName, p.SturbucksCustomerSurname, p.SturbucksCustomerBirtdate.Year);
                sonuc = response.Body.TCKimlikNoDogrulaResult;

                if (sonuc)
                {
                    sm.TAdd(p);
                    return RedirectToAction("Index", "SturbucksCustomer");
                }
                
                else
                {

                    return Content("Kayıt Eklenemedi.Bilgiler Uyuşmuyor.");
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
     
    }
}
