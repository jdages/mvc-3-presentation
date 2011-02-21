using System;
using System.Web.Mvc;

namespace Mvc3.Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult WhatTimeIsIt()
        {
            return View(DateTime.Now);
        }

        
    }


}