﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nazox.Form
{
    public class FormWizardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
