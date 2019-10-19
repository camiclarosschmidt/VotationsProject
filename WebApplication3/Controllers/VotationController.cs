using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ConnectionDB;

namespace WebApplication3.Controllers
{
    public class VotationController : Controller
    {
        
        
        public ActionResult AddVote(int value)
        {
            
            return View();
        }
        public ActionResult Chart()
        {
            
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
    }
}
