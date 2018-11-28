using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrailRanking.Models;

namespace TrailRanking.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            var model = new NoteListItem[0];
            return View(model);
        }
        //Add method here VVVV
        // GET
        public ActionResult Create()
        {
            return View();
        }
        //Add code here vvvv
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if (ModelState.IsValid)
            {
            }
            return View(model);
        }
    }
}