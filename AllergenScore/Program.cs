using System;
using System.Collections.Generic;
using AllergenScore.Models;

namespace AllergenScore
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("ALLERGEN SCORE");
      Console.WriteLine("--------------");
      Console.WriteLine(
        "allergen     score\n" +
        "eggs         1\n" +
        "peanuts      2\n" +
        "shellfish    4\n" +
        "strawberries 8\n" +
        "tomatoes     16\n" +
        "chocolate    32\n" +
        "pollen       64\n" +
        "cats         128");
      Console.WriteLine("Add up and enter your allergy score!: ");
      string stringAllergyScore = Console.ReadLine();
      int userReportedScore = int.Parse(stringAllergyScore);
      Allergy mainAllergyProfile = new Allergy(userReportedScore);
      AllergyChecker(userReportedScore);
    }
  }
}