﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LionKingBankAccount.Models;
using LionKingBankAccount.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LionKingBankAccount.Controllers
{
    [Route("accounts")]
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [Route("simba")]
        public IActionResult Simba()
        {
            var simba = new BankAccount("Simba", 2000f, "Lion", true, false);
            
            return View(simba);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            return View(BankAccounts.Accounts);
        }

        [HttpPost]
        [Route("donate/{id}")]
        public IActionResult Donate(int id)
        {
            BankAccounts.Accounts[BankAccounts.Accounts.FindIndex(acc => acc.ID == id)].IncreaseByDonation();
            return RedirectToAction("All");
        }

        [HttpPost]
        [Route("add-account")]
        public IActionResult AddAccount (string Name, float Balance, string AnimalType, bool IsKing, bool IsBad)
        {
            BankAccounts.Accounts.Add(new BankAccount(Name, Balance, AnimalType, IsKing, IsBad));
            return RedirectToAction("All");
        }
    }
}
