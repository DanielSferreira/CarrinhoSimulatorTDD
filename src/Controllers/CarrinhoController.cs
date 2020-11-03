using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Models;
using src.Services;

namespace src.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly ILogger<CarrinhoController> _logger;
        private LojaService _loja;
        private CarrinhoService _carrinho;
        public CarrinhoController(ILogger<CarrinhoController> logger, LojaService loja)
        {
            _logger = logger;
            _loja = loja;
            _carrinho = loja._carrinho;
        }

        public IActionResult Index()
        {
            var pessoa = _loja.cliente;
            return View(pessoa);
        }
        public IActionResult Produtos()
        {
            var produtos = _loja.ListarProdutosNaLoja;
            return View(produtos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
