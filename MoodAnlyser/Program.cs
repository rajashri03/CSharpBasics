using System;

namespace MoodAnlyser
{
    class Program
    {
        /*1 Enum is value type with a set of related name constants
          often reffered to as an enumerator list
      2 enum keyword is used to declare on enumerator.
      it is primitive data type.means user defined
        //string enum is not supported in c#
        the value of enum constant start from 0
      */
   

        //store in variable a week day
        static void Main(string[] args)
        {
            MoodAnalyzer moodAnalyze = new MoodAnalyzer(null);//null
            moodAnalyze.MoodAnalyze();
        }
    }
}
