using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCatalog
{
    class Genre : IEnumerable
    {
        private string name;
        public List<Title> Titles = new List<Title>();

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Genre(string genreName)
        {
            this.Name = genreName;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Title title in Titles)
            {
                yield return title.Name;
            }
        }
        public void AddTitle(Title title)
        {
            Titles.Add(title);
        }

        public static Genre operator +(Genre genre, Title title)
        {
            string searchname = genre.Name + " + " + title.Name;
            Genre combinedsearch = new Genre(searchname); 
            combinedsearch.Titles.AddRange(genre.Titles);
            combinedsearch.Titles.Add(title);
            return combinedsearch;
        }

        public static Genre operator +(Genre genre1, Genre genre2)
        {
            string searchname = genre1.Name + " + " + genre2.Name;
            Genre combinedsearch = new Genre(searchname);
            combinedsearch.Titles.AddRange(genre1.Titles);
            combinedsearch.Titles.AddRange(genre2.Titles);
            return combinedsearch;
        }

        public static Genre operator +(Title title, Genre genre)
        {
            string searchname = title.Name + " + " + genre.Name;
            Genre combinedsearch = new Genre(searchname);
            combinedsearch.Titles.Add(title);
            combinedsearch.Titles.AddRange(genre.Titles);
            return combinedsearch;
        }
    }
}
