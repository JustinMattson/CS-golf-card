namespace golf_card.Models
{
  public class Course
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Holes { get; set; }

    public Course(string name, string description, int holes)
    {
      Name = name;
      Description = description;
      Holes = holes;
    }
  }
}