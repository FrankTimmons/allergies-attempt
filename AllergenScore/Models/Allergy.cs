using System;
using System.Linq;
using System.Collections.Generic;

namespace AllergenScore.Models
{
  public class Allergy
  {
          // Create Dictionary of Alleries and their Int Values
      Dictionary<string, int> allergenScoreMatrix = new Dictionary<string, int>() {
          {"eggs", 1},
          {"peanuts", 2},
          {"shellfish", 4},
          {"strawberries", 8},
          {"tomatoes", 1},
          {"chocolate", 3},
          {"pollen", 6},
          {"cats", 1}
      };
    public int AllergyMatrixScore { get; set; }

    public Allergy(int allergyMatrixScore)
    {
      AllergyMatrixScore = allergyMatrixScore;
    }

    public void AllergyChecker(int userReportedScore)
    {
      AllergyMatrixScore = userReportedScore;
      // TEST FIRST: Get access to the first key-value pair in the allergenScoreMatrix dictionary and write it to the console.
      allergenScoreMatrix.ToList().ForEach(entry => Console.WriteLine(entry.Key));
    }
  }
}