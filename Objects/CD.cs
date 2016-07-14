using System.Collections.Generic;

namespace CDOrganizer.Objects
{
  // Class that defines a CD
  public class CompactDisk
  {
    // Properties
    private string _title;
    private string _artist;
    private int _id;
    private static List<CompactDisk> _instances = new List<CompactDisk>() {};

    // Constructors
    public CompactDisk(string title, string artist)
    {
        _title = title;
        _artist = artist;
        _instances.Add(this);
    }

    // Other Methods
    // Getters and Setters
    public string GetTitle()
    {
      return _title;
    }

    // Method to return a list of CD Objects
    public static List<CompactDisk> GetAll()
    {
      return _instances;
    }
  }
}
