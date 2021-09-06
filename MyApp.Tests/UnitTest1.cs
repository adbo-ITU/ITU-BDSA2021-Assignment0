using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear_2021IsNotLeapYear()
        {
            // Arrange
            var year = 2021;

            // Act
            var ans = Program.IsLeapYear(year);

            // Assert
            Assert.False(ans);
        }

        [Fact]
        public void IsLeapYear_2024IsLeapYear()
        {
            // Arrange
            var year = 2024;

            // Act
            var ans = Program.IsLeapYear(year);

            // Assert
            Assert.True(ans);
        }

        [Fact]
        public void IsLeapYear_2000IsNotLeapYear()
        {
            // Arrange
            var year = 2000;

            // Act
            var ans = Program.IsLeapYear(year);

            // Assert
            // Old: Assert.False(ans); to support 400th year:
            Assert.True(ans);
        }

        [Fact]
        public void IsLeapYear_1700IsNotLeapYear()
        {
            // Arrange
            var year = 1700;

            // Act
            var ans = Program.IsLeapYear(year);

            // Assert
            Assert.False(ans);
        }

        [Fact]
        public void IsLeapYear_1800IsNotLeapYear()
        {
            // Arrange
            var year = 1800;

            // Act
            var ans = Program.IsLeapYear(year);

            // Assert
            Assert.False(ans);
        }

        [Fact]
        public void IsLeapYear_ConsoleIO_AsksQuestion()
        {
            // Arrange
            var writer = new StringWriter();
            var reader = new StringReader("2021");
            Console.SetOut(writer);
            Console.SetIn(reader);

            // Act
            Program.UserAskAboutLeapYear();

            // Assert
            var output = writer.GetStringBuilder().ToString();
            Assert.Contains("Is it a leap year? Find out!", output);
            Assert.Contains("Please enter a year: ", output);
        }

        [Fact]
        public void IsLeapYear_ConsoleIO_Nay2021()
        {
            // Arrange
            var writer = new StringWriter();
            var reader = new StringReader("2021");
            Console.SetOut(writer);
            Console.SetIn(reader);

            // Act
            Program.UserAskAboutLeapYear();

            // Assert
            var output = writer.GetStringBuilder().ToString();
            Assert.Contains("nay", output);
        }

        [Fact]
        public void IsLeapYear_ConsoleIO_Yay2024()
        {
            // Arrange
            var writer = new StringWriter();
            var reader = new StringReader("2024");
            Console.SetOut(writer);
            Console.SetIn(reader);

            // Act
            Program.UserAskAboutLeapYear();

            // Assert
            var output = writer.GetStringBuilder().ToString();
            Assert.Contains("yay", output);
        }
    }
}
