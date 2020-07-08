using System;
using golf_card.Models;

namespace golf_card
{
  public class App
  {
    private GameHandler GameHandler { get; set; }
    // private Game Game { get; set; }
    public bool GameRunning { get; set; }

    public void Setup()
    {
      Course Course1 = new Course("Mini Putt Putt", "Quick 3", 3);
      Course Course2 = new Course("Meadow Lake", "Front", 9);
      Course Course3 = new Course("Meadow Lake", "Back", 9);
      Course Course4 = new Course("Meadow Lake", "Full Meal Deal", 18);

      GameHandler.Courses.Add(Course1);
      GameHandler.Courses.Add(Course2);
      GameHandler.Courses.Add(Course3);
      GameHandler.Courses.Add(Course4);

      // throw new NotImplementedException();
    }

    public void Run()
    {
      Console.WriteLine("Welcome to golf-card scoring!");
      while (GameRunning)
      {
        DisplayMainMenu();
      }
      // throw new NotImplementedException();
    }
    public void DisplayMainMenu()
    {
      GameHandler.ViewCourses();
      Console.WriteLine("\nWhat would you like to do? ");
      System.Console.WriteLine("[N]ew Game or [Q]uit"); //[V]iew Scores, 
      ProcessInput();
    }

    public void ProcessInput()
    {
      char choice = Console.ReadKey().KeyChar;
      switch (choice)
      {
        case 'n':
          GameHandler.StartGame();
          break;
        case 'v':
          GameHandler.ViewScores();
          break;
        case 'q':
          GameRunning = false;
          break;
        default:
          Console.WriteLine("Please enter [n]ew or [q]uit"); // [v]iew Scores, 
          ProcessInput();
          break;
      }
    }
    public App()
    {
      GameHandler = new GameHandler();
      GameRunning = true;
    }
  }
}