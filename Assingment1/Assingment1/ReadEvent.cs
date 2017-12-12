using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assingment1


{
    class ReadEvent
    {
        //Defining the dictionary
        Dictionary<string, Tweet> tweetDict = new Dictionary<string, Tweet>();
        Dictionary<string, Facebook> facebookDict = new Dictionary<string, Facebook>();
        Dictionary<string, Photo> photoDict = new Dictionary<string, Photo>();
        Dictionary<string, Video> videoDict = new Dictionary<string, Video>();
        Dictionary<string, Tracklog> tracklogDict = new Dictionary<string, Tracklog>();

        public Dictionary<string, Tweet> TweetDict { get => tweetDict; set => tweetDict = value; }
        public Dictionary<string, Facebook> FacebookDict { get => facebookDict; set => facebookDict = value; }
        public Dictionary<string, Photo> PhotoDict { get => photoDict; set => photoDict = value; }
        public Dictionary<string, Video> VideoDict { get => videoDict; set => videoDict = value; }
        public Dictionary<string, Tracklog> TracklogDict { get => tracklogDict; set => tracklogDict = value; }

        public void ReadInXML()
        {
            //Defining the namespace of the XML document
            XNamespace lle = "http://www.xyz.org/lifelogevents";

            var filepath = "..\\..\\resources\\lifelog-events.xml";

            //Retrieving the file and loading it 
            XElement lifelogxml = XElement.Load(filepath);
            IEnumerable<XElement> levents = lifelogxml.Elements();

            //Adding each element to correpsonding object
            foreach (var events1 in levents.Descendants(lle + "Event"))
            {
                //If event type is that of tweet
                foreach (var events2 in events1.Descendants(lle + "tweet"))
                {
                    var lat = 000;
                    var longi = 000;
                    foreach (var events3 in events1.Descendants(lle + "location"))
                    {
                        lat = Int16.Parse(events3.Element(lle + "lat").Value);
                        longi = Int16.Parse(events3.Element(lle + "long").Value);
                    }
                    Tweet tweetEv = new Tweet(events1.Element(lle + "eventid").Value, events2.Element(lle + "text").Value, lat, longi, events2.Element(lle + "datetimestamp").Value);

                    TweetDict.Add(events1.Element(lle + "eventid").Value, tweetEv);
                }

                //If event type is that of facebook-status-update
                foreach (var events2 in events1.Descendants(lle + "facebook-status-update"))
                {
                    var lat = 000;
                    var longi = 000;
                    foreach (var events3 in events1.Descendants(lle + "location"))
                    {
                        lat = Int16.Parse(events3.Element(lle + "lat").Value);
                        longi = Int16.Parse(events3.Element(lle + "long").Value);
                    }
                    Facebook facebookEv = new Facebook(events1.Element(lle + "eventid").Value, events2.Element(lle + "text").Value, lat, longi, events2.Element(lle + "datetimestamp").Value);

                    facebookDict.Add(events1.Element(lle + "eventid").Value, facebookEv);
                }

                //If event type is that of photo
                foreach (var events2 in events1.Descendants(lle + "photo"))
                {
                    var lat = 000;
                    var longi = 000;
                    foreach (var events3 in events1.Descendants(lle + "location"))
                    {
                        lat = Int16.Parse(events3.Element(lle + "lat").Value);
                        longi = Int16.Parse(events3.Element(lle + "long").Value);
                    }
                    Photo photoEv = new Photo(events1.Element(lle + "eventid").Value, events2.Element(lle + "filepath").Value, lat, longi);

                    photoDict.Add(events1.Element(lle + "eventid").Value, photoEv);
                }

                //If event type is that of video
                foreach (var events2 in events1.Descendants(lle + "video"))
                {
                    var lat = 000;
                    var longi = 000;
                    var starttime = "000";
                    var endtime = "000";

                    foreach (var events3 in events1.Descendants(lle + "location"))
                    {
                        lat = Int16.Parse(events3.Element(lle + "lat").Value);
                        longi = Int16.Parse(events3.Element(lle + "long").Value);
                    }

                    foreach (var events4 in events1.Descendants(lle + "start-time"))
                    {
                        starttime = (events4.Element(lle + "datetimestamp").Value);
                    }
                    foreach (var events5 in events1.Descendants(lle + "end-time"))
                    {
                        endtime = (events5.Element(lle + "datetimestamp").Value);
                    }
                    Video videoEv = new Video(events1.Element(lle + "eventid").Value, events2.Element(lle + "filepath").Value, lat, longi, starttime, endtime);

                    videoDict.Add(events1.Element(lle + "eventid").Value, videoEv);
                }

                //If event type is that of tracklog
                foreach (var events2 in events1.Descendants(lle + "tracklog"))
                {
                    var starttime = "000";
                    var endtime = "000";
                    var data = "000,000,000,000";
                    string[] dataPoints = new string[4];

                    foreach (var events3 in events1.Descendants(lle + "tracklog"))
                    {
                        data = (events3.Element(lle + "data").Value);
                        dataPoints = data.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var events4 in events1.Descendants(lle + "start-time"))
                        {
                            starttime = (events4.Element(lle + "datetimestamp").Value);
                        }
                        foreach (var events5 in events1.Descendants(lle + "end-time"))
                        {
                            endtime = (events5.Element(lle + "datetimestamp").Value);
                        }
                    }

                    Tracklog tracklogEv = new Tracklog(events1.Element(lle + "eventid").Value, events2.Element(lle + "filepath").Value, data, starttime, endtime, dataPoints);

                    tracklogDict.Add(events1.Element(lle + "eventid").Value, tracklogEv);
                }
            }

        }

    }
}
