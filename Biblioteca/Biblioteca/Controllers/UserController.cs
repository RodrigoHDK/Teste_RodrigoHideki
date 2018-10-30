using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(Registrar user)
        {        
            if (IsValid(user.Email, user.Senha))
            {
                FormsAuthentication.SetAuthCookie(user.Email, false);
                return RedirectToAction("Index", "Livro");
            }
            else
            {
                ModelState.AddModelError("", "Detalhes do Login não estão corretos.");
            }            
            return View(user);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Registrar user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new BibliotecaRHDKEntities())
                    {
                        var crypto = new SimpleCrypto.PBKDF2();
                        var encrypPass = crypto.Compute(user.Senha);
                        var newUser = db.Registrar.Create();
                        newUser.Email = user.Email;
                        newUser.Senha = encrypPass;
                        newUser.SenhaSalt = crypto.Salt;
                        newUser.PrimeiroNome = user.PrimeiroNome;
                        newUser.UltimoNome = user.UltimoNome;
                        newUser.UserType = "User";
                        newUser.CreatedDate = DateTime.Now;
                        newUser.IsActive = true;                       
                        db.Registrar.Add(newUser);
                        db.SaveChanges();
                        return RedirectToAction("LogIn", "User");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Dado não está correto.");
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" possuem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Propriedade: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn", "User");
        }

        private bool IsValid(string email, string senha)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            bool IsValid = false;

            using (var db = new BibliotecaRHDKEntities())
            {
                var user = db.Registrar.FirstOrDefault(u => u.Email == email);
                if (user != null)
                {
                    if (user.Senha == crypto.Compute(senha, user.SenhaSalt))
                    {
                        IsValid = true;
                    }
                }
            }
            return IsValid;
        }

    }
}
