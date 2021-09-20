﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace SentimentModel_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            SentimentModel.ModelInput sampleData = new SentimentModel.ModelInput()
            {
                Col1 = 1F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = SentimentModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Col0 with predicted Col0 from sample data...\n\n");


            Console.WriteLine($"Col0: {@"Wow... Loved this place."}");
            Console.WriteLine($"Col1: {1F}");


            Console.WriteLine($"\n\nPredicted Col0: {predictionResult.Prediction}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
