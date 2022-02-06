using HomeApp.Data.InterFaces;
using Microsoft.AspNetCore.Mvc;

namespace HomeApp.Controllers
{
    [Route("Appl/{id}")]
    public class ApplController : Controller
    {
        


        private readonly IAllAppls _allAppls;
        private readonly IApplsCategory _allCategories;

        public ApplController(IAllAppls iAllAppl, IApplsCategory iApplCat)
        {
            _allAppls = iAllAppl;
            _allCategories = iApplCat;
        }

        public IAllAppls AllAppls => _allAppls;
       
        
        public ViewResult List()
        {
            ViewBag.Category = "Some New";
            var appls = _allAppls.Appls;
            return View(appls);
        }
    }
}
