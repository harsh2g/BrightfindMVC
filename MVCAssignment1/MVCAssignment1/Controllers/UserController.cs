using MVCAssignment1.Models;
using System.Web.Mvc;
using Core.Calendar;

namespace MVCAssignment1.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        public ActionResult Index()
        {
            // yo peep this sweet comment !!
            var users = new UserModel();
            var list = users.GetList();
            return View(list);
        }
        public ActionResult Edit(int id)
        {
            var ctx = new UserModel();
            var user = ctx.GetUser(id);
            return View(user);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(User u)
        {
            var ctx = new UserModel();
            ctx.Update(u);
            return RedirectToAction("Index");
        }

        
        public ActionResult Delete(int id)
        {
            var ctx = new UserModel();
            ctx.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Add(User u)
        {
            var ctx = new UserModel();
            ctx.Add(u);
            return RedirectToAction("Index");
        }

        public ActionResult SessionTest()
        {
            HttpContext.Session["SessionName"] = "mySession";
            return View();
        }
    }
}