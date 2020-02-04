using System.Runtime;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {               
            var book = new Book("Scott's Grade Book");
            while(true)
                {   
                    Console.WriteLine ("Enter a Grade or 'q' to quit");

                    string input = Console.ReadLine();
                    if (input == "q" )
                    {
                       break;
                    }
                                     
                     //var grade = double.TryParse(input, out double w);
                     var grade = double.Parse(input);
                     book.AddGrade(grade); 
                }
            
            var stats = book.GetStatistics(); 

            

     

            
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");    
            Console.WriteLine($"The letter grade is {stats.Letter}");    
                    
        }        
    }
}
