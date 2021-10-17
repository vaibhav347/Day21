﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day21MoodAnalyzerUseCasee3
{
    public class UseCase1
    {
        int num3, num1 = 5, num2 = 0;
        public string analyzeMood(string msg)
        {

            if (msg.Contains("happy"))
                return "Happy";
            else if (msg.Contains("sad"))
                return "Sad";
            else
                throw (new MoodAnalysisException("Invalid Mood"));
        }
    }
}
