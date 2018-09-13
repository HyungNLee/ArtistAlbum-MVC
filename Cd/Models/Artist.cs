using System;
using System.Collections.Generic;

namespace Cd.Models
{
  public class Artist
  {

    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<Album> _albums;

    public Artist (string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _albums = new List<Album>{};
    }

    public string GetName ()
    {
      return _name;
    }

    public int GetId ()
    {
      return _id;
    }

    public static List<Artist> GetAll ()
    {
      return _instances;
    }

    public static void Clear ()
    {
      _instances.Clear();
    }

    public static Artist FindArtistById (int id)
    {
      return _instances[id - 1];
    }

    public List<Album> GetAlbums ()
    {
      return _albums;
    }

    public void AddAlbum (Album album)
    {
      _albums.Add(album);
    }

  }
}
