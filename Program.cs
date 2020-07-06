using System;

namespace golf_card
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      App app = new App();
      app.Setup();
      app.Run();
      Console.Clear();
      Console.WriteLine("Thanks for using my golf-card app!");
    }
  }
}
