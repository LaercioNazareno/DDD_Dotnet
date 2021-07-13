using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DDD_Dotnet.MVC.Models;
using DDD_Dotnet.Application.DTO;
using DDD_Dotnet.Application.Interfaces;

namespace DDD_Dotnet.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        private readonly ILogger<ClienteController> _logger;
        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteApp = clienteAppService;
        }

        public IActionResult Index()
        {
            var client = new ClienteDTO();
            return View(client);
        }
        public IActionResult Edit(ClienteDTO cliente)
        {
            if (cliente.Id == 0)
            {
                _clienteApp.ClienteAdd(cliente);
            }
            return Redirect("Home");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
