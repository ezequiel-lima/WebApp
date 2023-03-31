using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	public class ProdutoController : Controller
	{
		public IActionResult CadastrarProduto()
		{
			return View();
		}

        public IActionResult ListarProduto()
        {
            return View();
        }
    }
}
