using LogSeqSerilog.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Diagnostics;

namespace LogSeqSerilog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogError("Hello, world!");
            Log.Error("Agora são {Data}", DateTime.Now);

            var cor = Cores.Amarelo | Cores.Azul | Cores.Verde;
            var meuProduto = new Produto
            {
                ID = Guid.NewGuid(),
                Nome = "Notebook",
                Preco = 1299.99,
                DataDeFabricacao = DateTime.Parse("2023-09-20"),
                TempoDeGarantia = TimeSpan.FromDays(365),
                Cor = cor,
                Categoria = "Eletrônicos",
                EstoqueDisponivel = 100,
                EmEstoque = true,
                Nivel = 800,
                URLDaImagem = "https://exemplo.com/imagem/notebook.jpg"
            };
            _logger.LogError("Erro no Serilog index, model produto {@modelProduto}", meuProduto);

            //Log.Error("Erro no Serilog index, model produto {@modelProduto}", meuProduto);


            var position = new { Latitude = 25, Longitude = 134 };
            var elapsedMs = 34;

            Log.Information("Processed {@Position} in {Elapsed:000} ms.", position, elapsedMs);
            return View();
        }

        public IActionResult Privacy()
        {
            var t = 0;
            var x = 1 / t;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}