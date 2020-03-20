﻿using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // First the variable rating is declared and set to 7.
            var rating = 7;

            // if the user rated the restaurant 5-stars, print "This food is the best! I could eat this every day."
            if(rating == 5)
            {
                Console.WriteLine("This food is the best! I could eat this every day.");
            }
            // if the user rated the restaurant 4-stars, print "Good meal."
            else if(rating == 4)
            {
                Console.WriteLine("Good meal.");
            }
            // if the user rated the restaurant 3-stars, print "It was OK."
            else if(rating == 3)
            {
                Console.WriteLine("It was OK.");
            }
            // if the user rated the restaurant 2-stars, print "I did not like this, but it's cheap."
            else if(rating == 2)
            {
                Console.WriteLine("I did not like this, but it's cheap.");
            }
            // if the user rated the restaurant 1-star,  print "I will never eat here again."
            else if(rating == 1)
            {
                Console.WriteLine("I will never eat here again.");
            }
            // Validation for number entered outside of rating.
            else
            {
                Console.WriteLine("Please enter a valid rating of 1-5.");
            }
        }
    }
}