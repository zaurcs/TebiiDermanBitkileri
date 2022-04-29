using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TebiiDermanBitkileri.DB;
using TebiiDermanBitkileri.Entity;
using TebiiDermanBitkileri.Models;

namespace TebiiDermanBitkileri.Controllers
{
    public class BitkiController : Controller
    {
        private readonly ApplicationDBContext context;

        public BitkiController(ApplicationDBContext  context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetDrugPage() 
        {
            return View(new EntityViewModel(context));
        }

        //[HttpPost]
        //public Task<IActionResult> GetDrugPage(Bitki bitki) {
        //    var kindOfFlower = context.BitkiNovleri.Find(bitki.BitkiNovu.Id);
        //    //var vitaminsOfFlower = context.BitkiVitamin.FindAsync(bitki.BitkiVitamin.id);
            
        //    return View();
        //}
        
    }
}