using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTservice.Controllers
{
    public class SumController : Controller
    {
        // GET: SumController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SumController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SumController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SumController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
