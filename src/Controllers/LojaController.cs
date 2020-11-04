using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Models;
using src.Services;

namespace src.Controllers
{
    public class LojaController : Controller
    {
        private readonly ILogger<LojaController> _logger;
        private LojaService _loja;
        public LojaController(ILogger<LojaController> logger, LojaService loja)
        {
            _logger = logger;
            _loja = loja;
        }

        public IActionResult Index()
        {
            var pessoa = _loja.cliente;
            var produtos = _loja.produtos;
            pessoa.NomeCliente = "Daniel da Silva Ferreira";
            ViewData["produtos"] = produtos;
            return View(pessoa);
        }
        public IActionResult Produtos()
        {
            //var produtos = _loja.ListarProdutosNaLoja;
            return View(_loja.produtos.listPordutos());
        }

        public IActionResult AddToCarrinho(string prd)
        {
            
            _loja.LojaAddProdutoToCarrinho(prd);
            return Redirect("Produtos");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
