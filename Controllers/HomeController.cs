﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using login_n_reg.Models;

namespace login_n_reg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(IndexViewModel modelData)
        {
            RegUser submittedUser = modelData.NewUser;
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View ("Index");
            
        }
        public IActionResult Login(IndexViewModel modelData)
        {
            LogUser submittedLog = modelData.LoggedUser;
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
            
        }
        public IActionResult Success()
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
