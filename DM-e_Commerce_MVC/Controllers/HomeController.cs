﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DM_e_Commerce_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        //Test Bug-fix Branch..
        public ActionResult Index()
        {
            return View();
        }
    }
}