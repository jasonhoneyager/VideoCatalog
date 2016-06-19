using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCatalog
{
    class Catalog : IEnumerable
    {
        public List<Title> Library = new List<Title>();
        public List<Title> Movies = new List<Title>();
        public List<Title> Shows = new List<Title>();
        public List<Genre> genreList = new List<Genre>();
        Genre genre1 = new Genre("Comedy");
        Genre genre2 = new Genre("Action");
        Genre genre3 = new Genre("SciFi");
        Genre genre4 = new Genre("Romance");
        Genre genre5 = new Genre("Kids");
        Movie movie1 = new Movie { Name = "Avengers", Duration = 143, Rating = 8 };
        Movie movie2 = new Movie { Name = "Indiana Jones", Duration = 115, Rating = 8 };
        Movie movie3 = new Movie { Name = "Star Wars", Duration = 121, Rating = 9 };
        Movie movie4 = new Movie { Name = "Finding Nemo", Duration = 100, Rating = 8 };
        Movie movie5 = new Movie { Name = "Cinderella", Duration = 74, Rating = 7 };
        Movie movie6 = new Movie { Name = "Die Hard", Duration = 131, Rating = 8 };
        Movie movie7 = new Movie { Name = "Terminator", Duration = 107, Rating = 8 };
        Movie movie8 = new Movie { Name = "Army of Darkness", Duration = 81, Rating = 7 };
        Movie movie9 = new Movie { Name = "The Notebook", Duration = 123, Rating = 8 };
        Movie movie10 = new Movie { Name = "Titanic", Duration = 194, Rating = 7 };
        Show show1 = new Show { Name = "Doctor Who" };
        Episode s1ep1 = new Episode { Name = "Doctor Who Ep 1", Rating = 9 };
        Episode s1ep2 = new Episode { Name = "Doctor Who Ep 2", Rating = 8 };
        Episode s1ep3 = new Episode { Name = "Doctor Who Ep 3", Rating = 4 };
        Episode s1ep4 = new Episode { Name = "Doctor Who Ep 4", Rating = 7 };
        Episode s1ep5 = new Episode { Name = "Doctor Who Ep 5", Rating = 6 };
        Show show2 = new Show { Name = "Big Bang Theory" };
        Episode s2ep1 = new Episode { Name = "Big Bang Theory Ep 1", Rating = 6 };
        Episode s2ep2 = new Episode { Name = "Big Bang Theory Ep 2", Rating = 8 };
        Episode s2ep3 = new Episode { Name = "Big Bang Theory Ep 3", Rating = 5 };
        Episode s2ep4 = new Episode { Name = "Big Bang Theory Ep 4", Rating = 9 };
        Episode s2ep5 = new Episode { Name = "Big Bang Theory Ep 5", Rating = 7 };
        Show show3 = new Show { Name = "Adventure Time" };
        Episode s3ep1 = new Episode { Name = "Adventure Time Ep 1", Rating = 9 };
        Episode s3ep2 = new Episode { Name = "Adventure Time Ep 2", Rating = 8 };
        Episode s3ep3 = new Episode { Name = "Adventure Time Ep 3", Rating = 7 };
        Episode s3ep4 = new Episode { Name = "Adventure Time Ep 4", Rating = 8 };
        Episode s3ep5 = new Episode { Name = "Adventure Time Ep 5", Rating = 7 };
        Show show4 = new Show { Name = "Agents of SHIELD" };
        Episode s4ep1 = new Episode { Name = "Agents of SHIELD Ep 1", Rating = 9 };
        Episode s4ep2 = new Episode { Name = "Agents of SHIELD Ep 2", Rating = 7 };
        Episode s4ep3 = new Episode { Name = "Agents of SHIELD Ep 3", Rating = 7 };
        Episode s4ep4 = new Episode { Name = "Agents of SHIELD Ep 4", Rating = 5 };
        Episode s4ep5 = new Episode { Name = "Agents of SHIELD Ep 5", Rating = 9 };
        Show show5 = new Show { Name = "The Bachelor" };
        Episode s5ep1 = new Episode { Name = "The Bachelor Ep 1", Rating = 6 };
        Episode s5ep2 = new Episode { Name = "The Bachelor Ep 2", Rating = 5 };
        Episode s5ep3 = new Episode { Name = "The Bachelor Ep 3", Rating = 5 };
        Episode s5ep4 = new Episode { Name = "The Bachelor Ep 4", Rating = 4 };
        Episode s5ep5 = new Episode { Name = "The Bachelor Ep 5", Rating = 4 };


        public Catalog()
        {
            genreList.Add(genre1); genreList.Add(genre2); genreList.Add(genre3); genreList.Add(genre4); genreList.Add(genre5);
            Library.Add(movie1); Library.Add(movie2); Library.Add(movie3); Library.Add(movie4); Library.Add(movie5);
            Library.Add(movie6); Library.Add(movie7); Library.Add(movie8); Library.Add(movie9); Library.Add(movie10);
            Library.Add(show1); Library.Add(show2); Library.Add(show3); Library.Add(show4); Library.Add(show5);
            Movies.Add(movie1); Movies.Add(movie2); Movies.Add(movie3); Movies.Add(movie4); Movies.Add(movie5);
            Movies.Add(movie6); Movies.Add(movie7); Movies.Add(movie8); Movies.Add(movie9); Movies.Add(movie10);
            Shows.Add(show1); Shows.Add(show2); Shows.Add(show3); Shows.Add(show4); Shows.Add(show5);
            show1.episodes.Add(s1ep1); show1.episodes.Add(s1ep2); show1.episodes.Add(s1ep3); show1.episodes.Add(s1ep4); show1.episodes.Add(s1ep5);
            show2.episodes.Add(s2ep1); show2.episodes.Add(s2ep2); show2.episodes.Add(s2ep3); show2.episodes.Add(s2ep4); show2.episodes.Add(s2ep5);
            show3.episodes.Add(s3ep1); show3.episodes.Add(s3ep2); show3.episodes.Add(s3ep3); show3.episodes.Add(s3ep4); show3.episodes.Add(s3ep5);
            show4.episodes.Add(s4ep1); show4.episodes.Add(s4ep2); show4.episodes.Add(s4ep3); show4.episodes.Add(s4ep4); show4.episodes.Add(s4ep5);
            show5.episodes.Add(s5ep1); show5.episodes.Add(s5ep2); show5.episodes.Add(s5ep3); show5.episodes.Add(s5ep4); show5.episodes.Add(s5ep5);
            genre1.AddTitle(movie4); genre1.AddTitle(movie8); genre1.AddTitle(show2); genre1.AddTitle(show3);
            genre2.AddTitle(movie1); genre2.AddTitle(movie2); genre2.AddTitle(movie3); genre2.AddTitle(movie6); genre2.AddTitle(movie7); genre2.AddTitle(movie8); genre2.AddTitle(show4);
            genre3.AddTitle(movie3); genre3.AddTitle(movie7); genre3.AddTitle(show1); genre3.AddTitle(show4); genre3.AddTitle(movie1);
            genre4.AddTitle(movie5); genre4.AddTitle(movie9); genre4.AddTitle(movie10); genre4.AddTitle(show5);
            genre5.AddTitle(movie4); genre5.AddTitle(movie5); genre5.AddTitle(show3);

        }

        public IEnumerator GetEnumerator()
        {
            foreach (Genre genre in genreList)
            {
                yield return genre.Name;
            }
        }
        public void ChooseGenre()
        {
            Console.WriteLine("Which Genre do you want to display?\r\n");
            Console.WriteLine("1-{0}", genre1.Name);
            Console.WriteLine("2-{0}", genre2.Name);
            Console.WriteLine("3-{0}", genre3.Name);
            Console.WriteLine("4-{0}", genre4.Name);
            Console.WriteLine("5-{0}", genre5.Name);
            ConsoleKey key = Console.ReadKey(true).Key;
            DisplayGenre(key);
        }

        private void DisplayGenre(ConsoleKey key)
        {
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                foreach (Title title in genre1.Titles)
                {
                    Console.WriteLine(title);
                }
            }
            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                foreach (Title title in genre2.Titles)
                {
                    Console.WriteLine(title);
                }
            }
            else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
            {
                foreach (Title title in genre3.Titles)
                {
                    Console.WriteLine(title);
                }
            }
            else if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
            {
                foreach (Title title in genre4.Titles)
                {
                    Console.WriteLine(title);
                }
            }
            else if (key == ConsoleKey.D5 || key == ConsoleKey.NumPad5)
            {
                foreach (Title title in genre5.Titles)
                {
                    Console.WriteLine(title);
                }
            }
        }

        public void ChooseDisplayShow()
        {
            Console.WriteLine("Which Show do you want to display?\r\n");
            Console.WriteLine("1-{0}", show1);
            Console.WriteLine("2-{0}", show2);
            Console.WriteLine("3-{0}", show3);
            Console.WriteLine("4-{0}", show4);
            Console.WriteLine("5-{0}", show5);
            ConsoleKey key = Console.ReadKey().Key;
            DisplayShow(key);
        }

        private void DisplayShow(ConsoleKey key)
        {
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                foreach (Episode episode in show1.episodes)
                {
                    Console.WriteLine(episode);
                }
            }
            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                foreach (Episode episode in show2.episodes)
                {
                    Console.WriteLine(episode);
                }
            }
            else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
            {
                foreach (Episode episode in show3.episodes)
                {
                    Console.WriteLine(episode);
                }
            }
            else if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
            {
                foreach (Episode episode in show4.episodes)
                {
                    Console.WriteLine(episode);
                }
            }
            else if (key == ConsoleKey.D5 || key == ConsoleKey.NumPad5)
            {
                foreach (Episode episode in show5.episodes)
                {
                    Console.WriteLine(episode);
                }
            }
        }
        public void DisplayMovies()
        {
            foreach (Movie movie in Movies)
            {
                Console.WriteLine(movie);
            }
        }

        public void BeginSearch()
        {
            Console.WriteLine("Enter Your First Search Term:\r\n");
            string search1 = Console.ReadLine();
            Console.WriteLine("Enter Your Second Search Term:\r\n");
            string search2 = Console.ReadLine();
            CompileSearch(search1, search2);
        }

        private void CompileSearch(string search1, string search2)
        {
            if (search2 == "")
            {
                SingleSearch(search1);
            }
            else
            {
                DoubleSearch(search1, search2);
            }
        }

        private void SingleSearch(string search1)
        {
            foreach (Genre genre in genreList)
            {
                if (search1 == genre.Name)
                {
                   foreach (Title title in genre.Titles)
                    {
                        Console.WriteLine(title);
                    }
                }
            }
            foreach (Title title in Library)
            {
                if (search1 == title.Name)
                {
                    Console.WriteLine(title);
                }
            }
        }

        private void DoubleSearch(string search1, string search2)
        {
            foreach (Genre genre in genreList)
            {
                if (search1 == genre.Name)
                {
                    Genre1Search(genre, search2);
                }
            }
            foreach (Title title in Library)
            {
                if (search1 == title.Name)
                {
                    Title1Search(title, search2);
                }
            }
        }
        private void Genre1Search(Genre searchgenre1, string search2)
        {
            foreach (Genre genre in genreList)
            {
                if (search2 == genre.Name)
                {
                    Genre1Genre2Search(searchgenre1, genre);
                }
            }
            foreach (Title title in Library)
            {
                if (search2 == title.Name)
                {
                    Genre1Title2Search(searchgenre1, title);
                }
            }
        }

        private void Title1Search(Title searchtitle1, string search2)
        {
            foreach (Genre genre in genreList)
            {
                if (search2 == genre.Name)
                {
                    Title1Genre2Search(searchtitle1, genre);
                }
            }
            foreach (Title title in Library)
            {
                if (search2 == title.Name)
                {
                    Title1Title2Search(searchtitle1, title);
                }
            }
        }

        private void Genre1Genre2Search(Genre searchgenre1, Genre searchgenre2)
        {
            var combinedsearch = (searchgenre1 + searchgenre2);
            foreach (Title title in combinedsearch.Titles)
            {
                Console.WriteLine(title);
            }
        }

        private void Title1Genre2Search(Title searchtitle1, Genre searchgenre2)
        {
            var combinedsearch = (searchtitle1 + searchgenre2);
            foreach (Title title in combinedsearch.Titles)
            {
                Console.WriteLine(title);
            }
        }

        private void Genre1Title2Search(Genre searchgenre1, Title searchtitle2)
        {
            var combinedsearch = (searchgenre1 + searchtitle2);
            foreach (Title title in combinedsearch.Titles)
            {
                Console.WriteLine(title);
            }
        }

        private void Title1Title2Search(Title searchtitle1, Title searchtitle2)
        {
            Console.WriteLine(searchtitle1.Name);
            Console.WriteLine(searchtitle2.Name);
        }
    }
}
