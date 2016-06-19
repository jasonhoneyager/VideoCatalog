using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCatalog
{
    class Title
    {
        private string name;
        private decimal? rating;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal? Rating
        {
            get { return this.rating; }
            set
            {
                if ((value >= 0) && (value <= 10))
                {
                    this.rating = value;
                }
            }
        }

        public Title()
        {
            this.Name = null;
            this.Rating = null;
        }

        public Title(string value1, decimal? value2)
        {
            this.Name = value1;
            this.Rating = value2;
        }
        public override string ToString()
        {
            return "Title: " + this.Name + " Rating: " + this.Rating;
        }

        public static Title operator +(Title title1, Title title2)
        {
            string newname = title1.Name + " + " + title2.Name;
            decimal? newrating = title1.Rating + title2.Rating / 2;
            Title combinedsearch = new Title(newname, newrating);
            return combinedsearch;
        }

    }
}
