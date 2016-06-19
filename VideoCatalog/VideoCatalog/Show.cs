using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCatalog
{
    class Show : Title
    {
        public List<Episode> episodes = new List<Episode>();

        public new decimal Rating
        {
            get
            {
                decimal totalrating = 0;
                int ratingcount = 0;
                foreach (Episode show in episodes)
                {
                    totalrating += show.Rating;
                    ratingcount++;
                }
                decimal overallrating = totalrating / ratingcount;
                return overallrating;
            }

        }
        public override string ToString()
        {
            return "Title: " + this.Name + "  Episodes: " + episodes.Count + " Rating: " + this.Rating;
        }
    }
}
