using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AspNetCore.Models;

namespace AspNetCore.Controllers {
    public class PublicController:Controller {

        [Route("/")]
        public IActionResult Index()
        {
            var features = Data.GetFeatures();
            ViewData["features"] = features;
            return View();
        }

        [Route("/api")]
        public IActionResult Api()
        {
            var data = Data.GetFeatures();
            return Ok(data);
        }

    }
}