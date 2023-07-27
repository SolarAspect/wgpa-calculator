using System;
using System.Collections.Generic;
using System.Linq;

public class Grade
{
  public string classGrade;
  public string classWeight;
  
  public Grade(string c1, string c2)
  {
    classGrade = c1;
    classWeight = c2;
  }

  public double GradeValue()
  {
    double unweightedGradeValue = 0;
    double addedGradeValue = 0;
    
    switch (classGrade)
      {
      case "A":
        unweightedGradeValue = 4.00d;
        break;

      case "B":
        unweightedGradeValue = 3.00d;
        break;

      case "C":
        unweightedGradeValue = 2.00d;
        break;

      case "D":
        unweightedGradeValue = 1.00d;
        break;

      case "F":
        unweightedGradeValue = 0d;
        break;

      default:
        Console.WriteLine("That is not a valid grade.");
        break;
      }

    if (classWeight == "NORMAL")
    {
      addedGradeValue = 0d;
    }
    else if (classWeight == "HONORS")
    {
      addedGradeValue = 0.50d;
    }
    else if (classWeight == "AP")
    {
      addedGradeValue = 1.00d;
    }
    else 
    {
      Console.WriteLine("That is not a valid class level.");
    }
    return unweightedGradeValue + addedGradeValue;
  }
  
}

public class Program
{ 
  public static void Main(string[] args)
  {
    Console.Write(@"
   ___   ___  _       ___      _            _       _                      ___   _ 
  / _ \ / _ \/_\     / __\__ _| | ___ _   _| | __ _| |_ ___  _ __  __   __/ _ \ / |
 / /_\// /_)//_\\   / /  / _` | |/ __| | | | |/ _` | __/ _ \| '__| \ \ / / | | || |
/ /_\\/ ___/  _  \ / /__| (_| | | (__| |_| | | (_| | || (_) | |     \ V /| |_| || |
\____/\/   \_/ \_/ \____/\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|      \_/  \___(_)_|                   ");
    bool addGrade = true;
    List<double> grades = new List<double>();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nWelcome to your one and only Weighted GPA calculator for high school!\nDepending on what classes you take in high school, you will have a different GPA.\nAdd all of your CORE AREA classes including foreign language and what type of class it is (Normal, Honors, College-Level).\n\nWhen the calculator prompts for your grade, enter your letter grade: \n(A, B, C, D, F)\nWhen it prompts you for the type of class enter one of these phrases and they must be spelled exactly the same: \n(Normal, Honors, AP)");
    Console.ForegroundColor = ConsoleColor.White;

    while (addGrade)
    {
      // ELA grade
      Console.WriteLine("Enter your letter ELA grade.");
      string elaGrade = Console.ReadLine().ToUpper();
      Console.WriteLine("Enter what type of class it is.");
      string elaWeight = Console.ReadLine().ToUpper();
      Grade ela = new Grade(elaGrade, elaWeight);
      grades.Add(ela.GradeValue());

      // Math grade
      Console.WriteLine("Enter your letter Math grade.");
      string mathGrade = Console.ReadLine().ToUpper();
      Console.WriteLine("Enter what type of class it is.");
      string mathWeight = Console.ReadLine().ToUpper();
      Grade math = new Grade(mathGrade, mathWeight);
      grades.Add(ela.GradeValue());

      // Science grade
      Console.WriteLine("Enter your letter Science grade.");
      string scienceGrade = Console.ReadLine().ToUpper();
      Console.WriteLine("Enter what type of class it is.");
      string scienceWeight = Console.ReadLine().ToUpper();
      Grade science = new Grade(scienceGrade, scienceWeight);
      grades.Add(ela.GradeValue());

      // Social Studies grade
      Console.WriteLine("Enter your letter Social Studies grade.");
      string ssGrade = Console.ReadLine().ToUpper();
      Console.WriteLine("Enter what type of class it is.");
      string ssWeight = Console.ReadLine().ToUpper();
      Grade ss = new Grade(ssGrade, ssWeight);
      grades.Add(ela.GradeValue());

      // Language grade
      Console.WriteLine("Enter your letter Foreign Language grade.");
      string languageGrade = Console.ReadLine().ToUpper();
      Console.WriteLine("Enter what type of class it is.");
      string languageWeight = Console.ReadLine().ToUpper();
      Grade language = new Grade(languageGrade, languageWeight);
      grades.Add(ela.GradeValue());

      Console.WriteLine($"\nYour weighted GPA right now is {grades.Sum()/grades.Count()}");
      Console.WriteLine("Do you want to calculate again? Y/N");
      string response = Console.ReadLine().ToUpper();
      if (response == "N")
        addGrade = false;
    }
  }
}
