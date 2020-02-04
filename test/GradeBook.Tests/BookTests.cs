using System.Security.AccessControl;
using System;
using Xunit;

namespace GradeBook.Tests
{    
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);            
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void CheckGradesInMargins()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(110.1);
            book.AddGrade(100.1);
            book.AddGrade(100);
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            book.AddGrade(0);
            book.AddGrade(-0.1);
            book.AddGrade(-5);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(71.4, result.Average, 1);            
            Assert.Equal(100, result.High, 1);
            Assert.Equal(0, result.Low, 1);
        }
    }
}    

