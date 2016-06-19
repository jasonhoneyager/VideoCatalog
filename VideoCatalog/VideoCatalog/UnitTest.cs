using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCatalog
{
    class UnitTest
    {

        [TestMethod]
        public void TestShowRating()
        {
            Show testshow = new Show { Name = "Test" };
            Episode testep1 = new Episode { Name = "Test Ep 1", Rating = 9 };
            Episode testep2 = new Episode { Name = "Test Ep 2", Rating = 8 };
            Episode testep3 = new Episode { Name = "Test Ep 3", Rating = 7 };
            Episode testep4 = new Episode { Name = "Test Ep 4", Rating = 6 };
            Episode testep5 = new Episode { Name = "Test Ep 5", Rating = 5 };
            testshow.episodes.Add(testep1); testshow.episodes.Add(testep2); testshow.episodes.Add(testep3); testshow.episodes.Add(testep4); testshow.episodes.Add(testep5);
            Console.Write(testshow.Rating);
            Assert.Equals(7, testshow.Rating);
        }
        [TestMethod]
        public void TestTitleNameCreate()
        {
            Title test = new Title("testname", 6);
            Assert.Equals("testname", test.Name);
        }
        [TestMethod]
        public void TestTitleRatingCreate()
        {
            Title test = new Title("testname", 6);
            Assert.Equals(6, test.Rating);
        }
        [TestMethod]
        public void TestGenreOverload()
        {
            Genre TestGenre1 = new Genre("Comedy");
            Genre TestGenre2 = new Genre("Action");
            var TestGenre3 = TestGenre1 + TestGenre2;
            Assert.IsInstanceOfType(TestGenre3, typeof(Genre));
        }
        [TestMethod]
        public void TestGenreTitleOverload()
        {
            Genre TestGenre = new Genre("Comedy");
            Show TestShow = new Show { Name = "Test" };
            var TestResult = TestGenre + TestShow;
            Assert.IsInstanceOfType(TestResult, typeof(Genre));
        }
    }
}
