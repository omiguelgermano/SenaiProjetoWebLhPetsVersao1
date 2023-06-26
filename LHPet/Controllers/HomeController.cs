using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Nome 1", "CPF", "Email", "Nome do Paciente");
		Cliente cliente2 = new Cliente(02, "Nome 2", "CPF", "Email", "Nome do Paciente");
		
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);

        Fornecedor fornecedor1 = new Fornecedor(01, "Fornecedor 1", "CNPJ", "Email");
        Fornecedor fornecedor2 = new Fornecedor(02, "Fornecedor 2", "CNPJ", "Email");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
		listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);

        ViewBag.listaClientes = listaClientes;
        ViewBag.listaFornecedores = listaFornecedores;

		return View();
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
