using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCatalog
{
    class Movie : Title
    {
        private int duration;

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public override string ToString()
        {
            return "Title: " + this.Name + "  Duration: " + this.Duration + " min.  Rating: " + this.Rating;
        }
    }

}
