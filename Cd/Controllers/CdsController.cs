using Microsoft.AspNetCore.Mvc;
using Cd.Models;
using System;
using System.Collections.Generic;

namespace Cd.Controllers
{
    public class CdsController : Controller
    {
        [HttpGet("/Albums")]
        public ActionResult Index ()
        {
            return View();
        }

        [HttpGet("/Albums/CreateForm")]
        public ActionResult CreateForm ()
        {
          return View();
        }

        [HttpPost("/Albums")]
        public ActionResult CreateAlbum ()
        {
          Album newAlbum = new Album (Request.Form["name"]);
          List<Album> allAlbum = Album.GetAll();
          return View("Index", allAlbum);
        }
    }
}
