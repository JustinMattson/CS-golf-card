using System;
using System.Collections.Generic;

namespace golf_card.Models
{
  public class GameHandler
  {
    public List<Course> Courses { get; set; }
    public void ViewCourses()
    {
      int courseCount = 1;
      Console.WriteLine("Courses:");
      List<Course> courses = Courses;
      foreach (var course in courses)
      {
        Console.WriteLine($"{courseCount} - {course.Name} - {course.Description} - {course.Holes}");
        courseCount++;
      }
    }
    public void StartGame()
    {
      Console.Clear();
      ViewCourses();
      int choice = 0;
      Console.WriteLine("Select Course [Enter Course Number]");
      Int32.TryParse(Console.ReadLine(), out choice);
      while (choice < 1 || choice > Courses.Count)
      {
        Console.WriteLine("Please enter a valid course number");
        Int32.TryParse(Console.ReadLine(), out choice);
      }
      List<Course> courses = Courses;
      Course info = courses[choice - 1];
      Console.WriteLine($"You chose {info.Name} - {info.Description} - {info.Holes}");
      Console.WriteLine("How many players? [1-4]");
      Int32.TryParse(Console.ReadLine(), out choice);
      while (choice < 1 || choice > 4)
      {
        Console.WriteLine("Please enter a number 1-4");
        Int32.TryParse(Console.ReadLine(), out choice);
      }
      Console.WriteLine($"ok, {choice} players");
      String[] players = new string[choice];
      for (int i = 0; i < choice; i++)
      {
        Console.WriteLine($"Player{i + 1} Name:");
        players[i] = Console.ReadLine();
      }
      Console.WriteLine("Players: ");
      for (int i = 0; i < choice; i++)
      {
        Console.Write($"{players[i]} ");
      }
      Console.WriteLine("end");
    }

    public void ViewScores()
    {
      Console.Clear();
      Console.WriteLine("Find game");
      Console.WriteLine("Tally Scores by player");
      Console.WriteLine("Display Game Stats.");
      Console.ReadLine();
    }

    public GameHandler()
    {
      Courses = new List<Course>();
    }
  }
}