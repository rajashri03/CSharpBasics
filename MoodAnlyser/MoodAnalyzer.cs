using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnlyser
{
    class MoodAnalyzer
    {
        string HAPPY_MOOD = "Happy";
        string SAD_MOOD = "Sad";
        string NULL = "Mood can't be Null";
        string mood;
        public MoodAnalyzer(string mood)
        {
            this.mood = mood;
        }
        public string MoodAnalyze()
        {
            try//this block will test for exception
            {
                if (this.mood.Equals(string.Empty))
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.Empty_Message, "Mood should not Empty");
                }
                if (this.mood.ToLower().Contains("sad"))
                {
                    Console.WriteLine(SAD_MOOD);
                    return SAD_MOOD;
                }
                else
                {
                    Console.WriteLine(HAPPY_MOOD);
                    return HAPPY_MOOD;
                }
            }
            catch (NullReferenceException)//this block will catch exception if there
            {
                throw new MoodCustomException(MoodCustomException.ExpType.Null_Message, "Mood can't be Null");
                //Console.WriteLine(NULL);
                //return NULL;
            }
           
        }
    }
}
