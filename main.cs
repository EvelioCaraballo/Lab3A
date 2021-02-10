using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is the temperature in Celsius:");
    double c = Convert.ToDouble(Console.ReadLine());

    double f = (c*9/5) +32;

    Console.WriteLine("The equivalent for " +c + " degrees Celsius is " +f + " degrees fahrenheit");

    if(f<=32)
    {
      Console.WriteLine("This is freezing temperature");
    }
    
    else if(f>=212)
    {
      Console.WriteLine("This is a boiling temperature");
    }
    
  
    

  






  }
}