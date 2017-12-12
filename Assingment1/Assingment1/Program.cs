using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assingment1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ReadEvent readEvent = new ReadEvent();
            readEvent.ReadInXML();

            AddEvent addEvent = new AddEvent();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 Form1 = new Form1();

            foreach (var pair in readEvent.TweetDict)
            {
                PictureBox picture = new PictureBox
                {
                    Name = (pair.Key), Size = new System.Drawing.Size(30, 30), Location = new Point(readEvent.TweetDict[pair.Key].Longi, readEvent.TweetDict[pair.Key].Lat), Image = Image.FromFile("..\\..\\Resources\\twitter-icon.png"),
                };
                picture.MouseClick += ((sender, EventArgs) => { Picture_MouseClick(sender, EventArgs, pair.Key, "tweet", readEvent.TweetDict[pair.Key].Longi, readEvent.TweetDict[pair.Key].Lat); });
                Form1.Controls.Add(picture);
                picture.BringToFront();
            }

            foreach (var pair in readEvent.FacebookDict)
            {
                PictureBox picture = new PictureBox
                {
                    Name = (pair.Key), Size = new System.Drawing.Size(30, 30), Location = new Point(readEvent.FacebookDict[pair.Key].Longi, readEvent.FacebookDict[pair.Key].Lat), Image = Image.FromFile("..\\..\\Resources\\facebook-icon.png"),
                };
                picture.MouseClick += ((sender, EventArgs) => { Picture_MouseClick(sender, EventArgs, pair.Key, "facebook", readEvent.FacebookDict[pair.Key].Longi, readEvent.FacebookDict[pair.Key].Lat); });
                Form1.Controls.Add(picture);
                picture.BringToFront();
            }

            foreach (var pair in readEvent.PhotoDict)
            {
                PictureBox picture = new PictureBox
                {
                    Name = (pair.Key), Size = new System.Drawing.Size(30, 30), Location = new Point(readEvent.PhotoDict[pair.Key].Longi, readEvent.PhotoDict[pair.Key].Lat), Image = Image.FromFile("..\\..\\Resources\\photo-icon.png"),
                };
                picture.MouseClick += ((sender, EventArgs) => { Picture_MouseClick(sender, EventArgs, pair.Key, "photo", readEvent.PhotoDict[pair.Key].Longi, readEvent.PhotoDict[pair.Key].Lat); });
                Form1.Controls.Add(picture);
                picture.BringToFront();
            }

            foreach (var pair in readEvent.VideoDict)
            {
                PictureBox picture = new PictureBox
                {
                    Name = (pair.Key), Size = new System.Drawing.Size(30, 30), Location = new Point(readEvent.VideoDict[pair.Key].Longi, readEvent.VideoDict[pair.Key].Lat), Image = Image.FromFile("..\\..\\Resources\\video-icon.png"),
                };
                picture.MouseClick += ((sender, EventArgs) => { Picture_MouseClick(sender, EventArgs, pair.Key, "video", readEvent.VideoDict[pair.Key].Longi, readEvent.VideoDict[pair.Key].Lat); });
                Form1.Controls.Add(picture);
                picture.BringToFront();
            }

            foreach (var pair in readEvent.TracklogDict)
            {
                Form1.Paint += ((sender, EventArgs) => { Form1_Paint(sender, EventArgs, pair.Key); });
            }



            void Picture_MouseClick(object sender, MouseEventArgs e, string key, string eventType, int longi, int lat)
            {
                DialogResult result;
                PictureBox picture = new PictureBox
                {
                    Name = ("Radius"),
                    Size = new System.Drawing.Size(100, 100),
                    Location = new Point((longi - 35), (lat - 35)),
                    Image = Image.FromFile("..\\..\\resources\\radius.png"),
                    BackColor = Color.Transparent,
                };
                switch (eventType)
                {
                    case "tweet":
                        Form1.Controls.Add(picture);
                        picture.BringToFront();
                        result = MessageBox.Show(String.Format("Event type: Tweet\nText: {0}\nDate: {1}", readEvent.TweetDict[key].Text, readEvent.TweetDict[key].Datetimestamp));
                        if (result == DialogResult.OK)
                        {
                            Form1.Controls.Remove(picture);
                        }
                        break;
                    case "facebook":
                        Form1.Controls.Add(picture);
                        picture.BringToFront();
                        result = MessageBox.Show(String.Format("Event type: Facebook\nText: {0}\nDate: {1}", readEvent.FacebookDict[key].Text, readEvent.FacebookDict[key].Datetimestamp));
                        if (result == DialogResult.OK)
                        {
                            Form1.Controls.Remove(picture);
                        }
                        break;
                    case "photo":
                        Form1.Controls.Add(picture);
                        picture.BringToFront();
                        result = MessageBox.Show(String.Format("Event type: Photo\nFilepath: {0}\nLocation: {1}, {2}", readEvent.PhotoDict[key].Filepath, readEvent.PhotoDict[key].Lat, readEvent.PhotoDict[key].Longi));
                        if (result == DialogResult.OK)
                        {
                            Form1.Controls.Remove(picture);
                        }
                        break;
                    case "video":
                        Form1.Controls.Add(picture);
                        picture.BringToFront();
                        result = MessageBox.Show(String.Format("Event type: Video\nFilepath: {0}\nLocation: {1}, {2}", readEvent.VideoDict[key].Filepath, readEvent.VideoDict[key].Lat, readEvent.VideoDict[key].Longi));
                        if (result == DialogResult.OK)
                        {
                            Form1.Controls.Remove(picture);
                        }
                        break;
                    case "tracklog":
                        result = MessageBox.Show(String.Format("Event type: Tracklog\nFilepath: {0}\nStart Time: {1}\nEnd Time: {2}\nData Points: {3}, {4} - {5}, {6}", readEvent.TracklogDict[key].Filepath, readEvent.TracklogDict[key].Starttime, readEvent.TracklogDict[key].Endtime, readEvent.TracklogDict[key].DataPoints[0], readEvent.TracklogDict[key].DataPoints[1], readEvent.TracklogDict[key].DataPoints[2], readEvent.TracklogDict[key].DataPoints[3]));
                        break;
                }



            }

            void Form1_Paint(object sender, PaintEventArgs eventArgs, string key)
            {
                var p1 = Int16.Parse(readEvent.TracklogDict[key].DataPoints[0]);
                var p2 = Int16.Parse(readEvent.TracklogDict[key].DataPoints[1]);
                var p3 = Int16.Parse(readEvent.TracklogDict[key].DataPoints[2]);
                var p4 = Int16.Parse(readEvent.TracklogDict[key].DataPoints[3]);

                Pen blackPen = new Pen(Color.Black, 3);
                Point point1 = new Point(p1, p2);
                Point point2 = new Point(p3, p4);
                eventArgs.Graphics.DrawLine(blackPen, point1, point2);
            }

            Application.Run(Form1);
        }


    }
}
