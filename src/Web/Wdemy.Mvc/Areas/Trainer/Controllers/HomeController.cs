﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Wdemy.Mvc.Areas.Trainer.Controllers
{
    public class HomeController : TrainerBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
