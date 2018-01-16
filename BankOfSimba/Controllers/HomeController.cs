using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        //private Client client;

        public static List<Client> BankAccounts = new List<Client>()
        {
            new Client("Pumbaa", 100, "Warthog"),
            new Client("Timon", 250, "Meerkat"),
            new Client("Rafiki", 1500, "Baboon"),
            new Client("Zazu", 456, "Red-billed Hornbill")
        };

        //public HomeController(Client client)
        //{
        //    this.client = client;
        //}

        [HttpGet("")]
        public IActionResult Index()
        {
            var bankAcc = new Client("Simba", 2000, "Lion")
            {
                King = true
            };
            BankAccounts.Add(bankAcc);

            return View(bankAcc);
        }

        [HttpGet("bank")]
        public IActionResult Accounts()
        {
            return View(BankAccounts);
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddAccount(string name, double balance, string animal, bool king)
        {
            Client newclient = new Client(name, balance, animal, king);
            if (king == true)
                newclient.King = true;

            BankAccounts.Add(newclient);

            return RedirectToAction("Accounts");
        }

        [HttpPost("bank")]
        public IActionResult DeleteAccount(string name)
        {
            BankAccounts.Remove(BankAccounts.First(x => x.Name.Equals(name)));

            return RedirectToAction("Accounts");
        }
    }
}
