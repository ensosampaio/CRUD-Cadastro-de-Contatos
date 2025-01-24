using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(loginModel.Login == "adm" && loginModel.Senha == "123")
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    TempData["MensagemErro"] = "Usuário e/ou senha inválido(s). Por Favor, tente novamente";

                }

                return View("Index");
            }
            catch (Exception ex)
            {

              TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, detalhes do erro: {ex.Message}";
               return RedirectToAction("Index");


            }
        
        
        
        
        
        
        
        
        
        
        }
    
    
    
    
    
    
    }
}
