using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assingment1
{
    class AddEvent
    {
        //Defining the namespace of the XML document
        XNamespace lle = "http://www.xyz.org/lifelogevents";
        XNamespace soapENV = "http://www.w3.org/2001/12/soap-envelope";

        string filepath = "..\\..\\resources\\lifelog-events.xml";
        string lastID = "";

        public void AddTweet(string text, string date, int mouseX, int mouseY)
        {
            //Retrieving the file and loading it 
            XElement lifelogxml = XElement.Load(filepath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length -2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "tweet",
                               new XElement(lle + "text", text),
                               new XElement(lle + "location",
                                   new XElement(lle + "lat", mouseY),
                                   new XElement(lle + "long", mouseX)),
                               new XElement(lle + "datetimestamp", date)));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);

            lifelogxml.Save(filepath);
        }

        public void AddFacebook(string text, string date, int mouseX, int mouseY)
        {
            //Retrieving the file and loading it 
            XElement lifelogxml = XElement.Load(filepath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "facebook-status-update",
                               new XElement(lle + "text", text),
                               new XElement(lle + "location",
                                   new XElement(lle + "lat", mouseY),
                                   new XElement(lle + "long", mouseX)),
                               new XElement(lle + "datetimestamp", date)));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);

            lifelogxml.Save(filepath);
        }

        public void AddPhoto(string fpath, int mouseX, int mouseY)
        {
            //Retrieving the file and loading it 
            XElement lifelogxml = XElement.Load(filepath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "photo",
                               new XElement(lle + "filepath", fpath),
                               new XElement(lle + "location",
                                   new XElement(lle + "lat", mouseY),
                                   new XElement(lle + "long", mouseX))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);

            lifelogxml.Save(filepath);
        }

        public void AddVideo(string fpath, string starttime, string endtime, int mouseX, int mouseY)
        {
            //Retrieving the file and loading it 
            XElement lifelogxml = XElement.Load(filepath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "video",
                               new XElement(lle + "filepath", fpath),
                               new XElement(lle + "location",
                                   new XElement(lle + "lat", mouseY),
                                   new XElement(lle + "long", mouseX)),
                                new XElement(lle + "start-time",
                                   new XElement(lle + "datetimestamp", starttime)),
                                new XElement(lle + "end-time",
                                   new XElement(lle + "datetimestamp", endtime))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);

            lifelogxml.Save(filepath);
        }

        public void AddTracklog(string fpath, string data, string starttime, string endtime, int mouseX, int mouseY)
        {
            //Retrieving the file and loading it 
            XElement lifelogxml = XElement.Load(filepath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "tracklog",
                               new XElement(lle + "filepath", fpath),
                               new XElement(lle + "data", data),
                                new XElement(lle + "start-time",
                                   new XElement(lle + "datetimestamp", starttime)),
                                new XElement(lle + "end-time",
                                   new XElement(lle + "datetimestamp", endtime))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);

            lifelogxml.Save(filepath);
        }
    }
}
