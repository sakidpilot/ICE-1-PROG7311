using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.Controllers
{
    public class InventroyItemController : Controller
    {
        // GET: InventroyItemController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InventroyItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InventroyItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InventroyItemController/Create
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

        // GET: InventroyItemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InventroyItemController/Edit/5
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

        // GET: InventroyItemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InventroyItemController/Delete/5
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
