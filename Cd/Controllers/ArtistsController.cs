using Microsoft.AspNetCore.Mvc;
using Cd.Models;
using System;
using System.Collections.Generic;

namespace Cd.Controllers
{
  public class ArtistsController : Controller
  {
    [HttpGet("/Artists")]
    public ActionResult Index ()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("/Artists/Create")]
    public ActionResult CreateForm ()
    {
      return View();
    }

    [HttpPost("/Artists")]
    public ActionResult CreateArtist ()
    {
      Artist newArtist = new Artist(Request.Form["name"]);
      List<Artist> allArtists = Artist.GetAll();
      return View("Index" ,allArtists);
    }

    [HttpGet("/Artists/{id}")]
    public ActionResult Details (int id)
    {
      // List<Artist> allArtists = Artist.GetAll();
      Artist newArtist = Artist.FindArtistById(id);
      return View(newArtist);
    }

    [HttpGet("/Artists/{id}/Album/Create")]
    public ActionResult AddAlbum (int id)
    {
      Artist newArtist = Artist.FindArtistById(id);
      return View(newArtist);
    }

    [HttpPost("/Artists/{id}")]
    public ActionResult DetailsAfterAdd (int id)
    {
      // List<Artist> allArtists = Artist.GetAll();
      Artist newArtist = Artist.FindArtistById(id);
      Album newAlbum = new Album(Request.Form["name"]);
      newArtist.AddAlbum(newAlbum);
      return View("Details", newArtist);
    }
  }
}
