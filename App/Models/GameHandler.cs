using System;
using System.Collections.Generic;

namespace golf_card.Models
{
  public class GameHandler
  {
    public List<Course> Courses { get; set; }
    public int[] Scores {get; set;}
    public void ViewCourses()
    {
      int courseCount = 1;
      Console.WriteLine("\nCourses:");
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
      int courseId = 0;
      Console.WriteLine("\nSelect Course [Enter Course Number]");
      Int32.TryParse(Console.ReadLine(), out courseId);
      while (courseId < 1 || courseId > Courses.Count)
      {
        Console.WriteLine("Please enter a valid course number");
        Int32.TryParse(Console.ReadLine(), out courseId);
      }
      List<Course> courses = Courses;
      Course info = courses[courseId - 1];
      Console.WriteLine($"You chose {info.Name} - {info.Description} - {info.Holes}");

      Console.WriteLine("\nHow many players? [1-4]");
      int numPlayers = 0;
      Int32.TryParse(Console.ReadLine(), out numPlayers);
      while (numPlayers < 1 || numPlayers > 4)
      {
        Console.WriteLine("Please enter a number 1-4");
        Int32.TryParse(Console.ReadLine(), out numPlayers);
      }
      Console.WriteLine($"ok, {numPlayers} players");
      int[] scores = new int[info.Holes * numPlayers];
      
      String[] players = new string[numPlayers];
      for (int i = 0; i < numPlayers; i++)
      {
        Console.WriteLine($"\nPlayer{i + 1} Name:");
        players[i] = Console.ReadLine();
      }
      // Console.WriteLine("\nPlayers: ");
      System.Console.WriteLine("\nInput Scores:");
      int score = 0;
      for (int i = 0; i < info.Holes; i++)
      {
        // Console.Write($"{players[i]} ");
        for (int j = 0; j < numPlayers; j++) 
        {
        Console.Write($"Enter hole {i+1} score for {players[j]}: ");
        Int32.TryParse(Console.ReadLine(), out score);
        System.Console.WriteLine(score);
        scores[i+j] = score;
        while (score < 1 || score > 10)
          {
            Console.WriteLine("Please enter a valid number (1-10)");
            Int32.TryParse(Console.ReadLine(), out score);
            scores[i+j] = score;
          } 
        }
      }
      // Print Scores:
      System.Console.Write("     ");
      for (int i = 0; i < info.Holes; i++)
      {
          Console.Write($"  {i+1}");
      }
      for (int j = 0; j < numPlayers; j++)
      {
          Console.Write($"\n{players[j]}: ");
          for (int i = 0; i < info.Holes; i++)
          {
              // System.Console.Write($"{i}");
              System.Console.Write($"  {scores[i+j]}");
          }
      }
      Console.WriteLine("\nend");
    }

    public void ViewScores()
    {
      Console.Clear();
      Console.WriteLine("Display games");
      Console.WriteLine("Select game");
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