using System;
class EnumProgram {

    // Creating an enum
    enum Level{High,Medium,Low}
    static void Main() {

    // Using enum
    Level complexity = Level.Medium;
    switch(complexity) 
    {
      case Level.Low:
      Console.WriteLine("Low level");
      break;
      case Level.Medium:
      Console.WriteLine("Medium level");
      break;
      case Level.High:
      Console.WriteLine("High level");
      break;
  }
  }
}

/*
OUTPUT:
Medium level
*/
