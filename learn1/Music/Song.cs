using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    internal class Song
    {
        private string _title;
        private string _genre;
        private string _duration;
        private double _rating;

        public Song()
        {

        }
        public Song(string _title,string _genre,string _duration,double _rating)
        {
            this._rating = _rating;
            this._duration = _duration;
            this._title = _title;
            this._genre = _genre;
        }
        public string _Title { get { return _title; } set { _title = value; } }
        public string _Genre { get { return _genre;} set { _genre = value; } }
        public string _Duration { get { return _duration; } set { _duration = value; } }
        public double _Rating { get { return _rating;} set { _rating = value; } }



        
    }
}
