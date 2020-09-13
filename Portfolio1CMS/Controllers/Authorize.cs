using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio1CMS.Controllers
{
    public class Authorize : Controller
    {
        // GET: Authorize
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Auth()
        {
            return View();
        }

        // GET: Authorize/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Authorize/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authorize/Create
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

        // GET: Authorize/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Authorize/Edit/5
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

        // GET: Authorize/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authorize/Delete/5
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
