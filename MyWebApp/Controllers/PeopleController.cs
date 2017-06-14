using MyWebApp.Models.ViewModels;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    [RoutePrefix("people")]
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        [Route("edit/{personId:int?}")]
        [Route("create")]
        public ActionResult Manage(int? personId = null)
        {
            ItemViewModel<int?> model = new ItemViewModel<int?>();
            model.Item = personId;
            return View(model);
        }
    }
}