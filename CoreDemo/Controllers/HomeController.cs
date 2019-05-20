using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Database;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class HomeController:Controller
    {
        //private readonly ICinemaService _cinemaService;

        //public HomeController(ICinemaService cinemaService)
        //{
        //    _cinemaService = cinemaService;
        //}

        //public async Task<IActionResult> Index()
        //{
        //    ViewBag.Title = "CoreDemo";

        //    return View(await _cinemaService.GetllAllAsync());
        //}

        //public IActionResult Add()
        //{
        //    ViewBag.Title = "添加电影院";
        //    return View(new Cinema()); 
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add(Cinema model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _cinemaService.AddAsync(model);
        //    }

        //    return RedirectToAction("Index");
        //}
    }
}
