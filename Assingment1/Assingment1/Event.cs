using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    interface IEvent
    {
        string EventID { get; set; }
    }

    class Tweet : IEvent
    {
        private string eventID;
        private string text;
        private int lat;
        private int longi;
        private string datetimestamp;

        public Tweet(string eventID, string text, int lat, int longi, string datetimestamp)
        {
            this.eventID = eventID;
            this.text = text;
            this.lat = lat;
            this.longi = longi;
            this.datetimestamp = datetimestamp;
        }

        public string EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public int Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public int Longi
        {
            get { return longi; }
            set { longi = value; }
        }
        public string Datetimestamp
        {
            get { return datetimestamp; }
            set { datetimestamp = value; }
        }

        public override string ToString()
        {
            return eventID + " " + text + " " + lat + " " + longi + " " + datetimestamp;
        }
    }

    class Facebook : IEvent
    {
        private string eventID;
        private string text;
        private int lat;
        private int longi;
        private string datetimestamp;

        public Facebook(string eventID, string text, int lat, int longi, string datetimestamp)
        {
            this.eventID = eventID;
            this.text = text;
            this.lat = lat;
            this.longi = longi;
            this.datetimestamp = datetimestamp;
        }

        public string EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public int Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public int Longi
        {
            get { return longi; }
            set { longi = value; }
        }
        public string Datetimestamp
        {
            get { return datetimestamp; }
            set { datetimestamp = value; }
        }

        public override string ToString()
        {
            return eventID + " " + text + " " + lat + " " + longi + " " + datetimestamp;
        }
    }

    class Photo : IEvent
    {
        private string eventID;
        private string filepath;
        private int lat;
        private int longi;

        public Photo(string eventID, string filepath, int lat, int longi)
        {
            this.eventID = eventID;
            this.filepath = filepath;
            this.lat = lat;
            this.longi = longi;
        }

        public string EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }
        public string Filepath
        {
            get { return filepath; }
            set { filepath = value; }
        }
        public int Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public int Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public override string ToString()
        {
            return eventID + " " + filepath + " " + lat + " " + longi;
        }
    }

    class Video : IEvent
    {
        private string eventID;
        private string filepath;
        private int lat;
        private int longi;
        private string starttime;
        private string endtime;

        public Video(string eventID, string filepath, int lat, int longi, string starttime, string endtime)
        {
            this.eventID = eventID;
            this.filepath = filepath;
            this.lat = lat;
            this.longi = longi;
            this.starttime = starttime;
            this.endtime = endtime;
        }

        public string EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }
        public string Filepath
        {
            get { return filepath; }
            set { filepath = value; }
        }
        public int Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public int Longi
        {
            get { return longi; }
            set { longi = value; }
        }
        public string Starttime
        {
            get { return starttime; }
            set { starttime = value; }
        }

        public string Endtime
        {
            get { return endtime; }
            set { endtime = value; }
        }

        public override string ToString()
        {
            return eventID + " " + filepath + " " + lat + " " + longi + " " + starttime + " " + endtime;
        }
    }

    class Tracklog : IEvent
    {
        private string eventID;
        private string filePath;
        private string data;
        private string starttime;
        private string endtime;
        private string[] dataPoints;
        
        public Tracklog(string eventID, string filePath, string data, string starttime, string endtime, string[] dataPoints)
        {
            this.eventID = eventID;
            this.filePath = filePath;
            this.data = data;
            this.starttime = starttime;
            this.endtime = endtime;
            this.dataPoints = dataPoints;
        }

        public string EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }
        public string Filepath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Starttime
        {
            get { return starttime; }
            set { starttime = value; }
        }

        public string Endtime
        {
            get { return endtime; }
            set { endtime = value; }
        }

        public string[] DataPoints
        {
            get { return dataPoints; }
            set { dataPoints = value; }
        }

        public override string ToString()
        {
            return eventID + " " + data + " " + starttime + " " + endtime;
        }
    }
}

