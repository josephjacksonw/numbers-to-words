// Business


using System;
using System.Collections.Generic;


namespace Converter.Models
{
  public class Translator
  {
    public string changer (int num)
    {
      if (num == 0)
      {
        return "zero";
      }
      string output = "";
       if (num > 999999999)//num is at least 1 billion
      {
        int bilNums = num/1000000000;
        output += hundreds(bilNums);
        output += " billion";
        num = num%1000000000;
      }
      if (num > 999999)//num is at least 1 million
      {
        int milNums = num/1000000; 
        output += hundreds(milNums);
        output += " million";
        num = num%1000000;
      }
      if (num > 999)//num is at least 1 thousand
      {
        int thoNums = num/1000; 
        output += hundreds(thoNums);
        output += " thousand";
        num = num%1000;
      }
      if (num > 0)
      {
        output += hundreds(num);
      }
      output = output.Remove(0, 1);
      return output;
    }
    public string hundreds(int sectionedNum)
    {
      string output = "";
      string[] tens = new string[] {"nan", "nan", " twenty", " thirty", " forty", " fifty", " sixty", " seventy", " eighty", " ninety"};
      string[] lowNums = new string[] {" zero", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", " ten", " eleven", " twelve", " thirteen", " fourteen", " fifteen", " sixteen", " seventeen", " eighteen", " nineteen"};
      if (sectionedNum > 100)
      {
        int hunNum = sectionedNum/100;
        output += lowNums[hunNum];
        output += " hundred";
        sectionedNum = sectionedNum%100;
      }
      if (sectionedNum != 0)
      {
        if (sectionedNum < 20)
        {
          output += lowNums[sectionedNum];
        }
        else 
        {
          //num is between 99 and 20
          int tenNum = sectionedNum/10;
          output += tens[tenNum];
          sectionedNum -= tenNum * 10;
          if (sectionedNum > 0)
          {
            output += lowNums[sectionedNum];
          }
        }
      }
      return output;
    }
  }
}







//look here
// 986235597514
// 986 235 597 514
// if 986 > 99
// sees 9 in hundreds
// adds "nine" and "hundred"
// 86
// 86 > 20
// sees 8, adds "eighty"
// adds "six"
// adds "billion"
// moves on to 
// 235
