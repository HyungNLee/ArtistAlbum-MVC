using System;
using System.Collections.Generic;

namespace Cd.Models
{
  public class Album
  {

    private string _cdName;
    private int _id;
    private static List<Album> _instances = new List<Album> {};

    public Album (string cdName)
    {
      _cdName = cdName;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public void SetName (string newName)
    {
      _cdName = newName;
    }

    public string GetName ()
    {
      return _cdName;
    }

    public static List<Album> GetAll ()
    {
      return _instances;
    }

    public int GetId ()
    {
      return _id;
    }

    public static Album FindById (int id)
    {
      return _instances[id - 1];
    }
  }
}
