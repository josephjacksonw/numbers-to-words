// Business
//we are building a function that takes in a number (int) and outputs that number as a string with proper grammar
// 479384 -> four hundred seventy nine thousand three hundred eighty four

using System;
using System.Collections.Generic;


namespace Converter.Models
{
  public class Translator
  {
    public string changer (int num)
    {
      string output = "";
      string[] lowNums = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
      if (num < 20)
      {
        output = lowNums[num];
      }
      return output;
    }
  }
}
