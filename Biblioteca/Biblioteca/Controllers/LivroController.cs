using Biblioteca.Models;
using System.Linq.Dynamic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        private LivrosDbContext db = new LivrosDbContext();

        // GET: Livro
        public ActionResult Index(string filter = null, int page = 1,
         int pageSize = 10, string sort = "Id", string sortdir = "DESC")
        {
            var records = new PagedList<Livros>();
            ViewBag.filter = filter;
            records.Content = db.Livros
                        .Where(x => filter == null ||
                                (x.Nome.Contains(filter))
                                   || x.Autor.Contains(filter)
                              )
                        .OrderBy(sort + " " + sortdir)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

            // Count
            records.TotalRecords = db.Livros
                         .Where(x => filter == null ||
                               (x.Nome.Contains(filter)) || x.Autor.Contains(filter)).Count();

            records.CurrentPage = page;
            records.PageSize = pageSize;

            return View(records);
        }


        // GET: /Livro/Details/
        public ActionResult Details(int id = 0)
        {
            Livros livro = db.Livros.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return PartialView("Details", livro);
        }

        // GET: /Livro/Create
        [HttpGet]
        public ActionResult Create()
        {
            var livro = new Livros();
            return PartialView("Create", livro);
        }


        // POST: /Livro/Create
        [HttpPost]
        public JsonResult Create(Livros livro)
        {
            if (ModelState.IsValid)
            {
                db.Livros.Add(livro);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(livro, JsonRequestBehavior.AllowGet);
        }

        // GET: /Livro/Edit/
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            var livro = db.Livros.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }

            return PartialView("Edit", livro);
        }


        // POST: /Livro/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Livros livro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livro).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true });
            }
            return PartialView("Edit", livro);
        }


        // GET: /Livro/Delete/
        public ActionResult Delete(int id = 0)
        {
            Livros livro = db.Livros.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return PartialView("Delete", livro);
        }

                
        // POST: /Livro/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var livro = db.Livros.Find(id);
            db.Livros.Remove(livro);
            db.SaveChanges();
            return Json(new { success = true });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


    }
}