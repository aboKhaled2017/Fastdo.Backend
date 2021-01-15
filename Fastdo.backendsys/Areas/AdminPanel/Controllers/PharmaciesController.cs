﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fastdo.backendsys.Repositories;
using Fastdo.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Fastdo.backendsys.Areas.AdminPanel.Controllers
{
    [Authorize(Policy = "ControlOnPharmaciesPagePolicy")]
    public class PharmaciesController : MainController
    {
        public PharmaciesController(IAdminRepository adminRepository, UserManager<AppUser> userManager) : base(adminRepository, userManager)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}