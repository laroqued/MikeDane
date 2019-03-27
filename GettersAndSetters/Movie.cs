using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class Movie
    {
        public string title;
        public string director;
        //private only the code with the Movie class can access this code.
        private string rating;

        public Movie(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            //The Rating method is assigned to the rating attribute
            Rating  = rating;
        }
        public string Rating
        {
            //Use the "get" to return/get the rating value.
            get{ return rating; }
            //You have the "set" the conditions for the value.
            set {
                if (value == "G" || value  == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    //the rating attribute is assigned to the value.
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}
