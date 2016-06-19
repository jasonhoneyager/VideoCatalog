using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCatalog
{
    class Episode
    {
        private string name;
        private decimal rating;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Rating
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
        public override string ToString()
        {
            return "Title: " + this.Name + " Rating: " + this.Rating;
        }
    }
}
