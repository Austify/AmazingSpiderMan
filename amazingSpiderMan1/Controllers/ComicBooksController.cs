using amazingSpiderMan1.Data;
using amazingSpiderMan1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace amazingSpiderMan1.Controllers
{
    public class ComicBooksController : Controller
    { 
        private static ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }
       
        public ActionResult Detail(int? id)
        {
            if( id == null)
            {
                return RedirectToAction("Index");
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            
            return View(comicBook);
        }
    }
}