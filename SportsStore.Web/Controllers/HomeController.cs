using System.Web.Mvc;

namespace SportsStore.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Public Methods

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        #endregion Public Methods
    }
}