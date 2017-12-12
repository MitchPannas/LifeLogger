using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment1
{
    public partial class Form2 : Form
    {
        private int mouseX;
        private int mouseY;
        private string eventType = "tweet";

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int mouseY, int mouseX)
        {
            InitializeComponent();
            this.mouseX = mouseX;
            this.mouseY = mouseY;
        }

        public string EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }

        public int MouseX
        {
            get { return mouseX; }
            set { mouseX = value; }
        }

        public int MouseY
        {
            get { return mouseY; }
            set { mouseY = value; }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            switch (eventType)
            {
                case "tweet":
                    addEvent.AddTweet(tweetText.Text, tweetDate.Text, MouseX, MouseY);
                    Application.Restart();
                    break;
                case "facebook":
                    addEvent.AddFacebook(facebookText.Text, facebookDate.Text, MouseX, MouseY);
                    Application.Restart();
                    break;
                case "photo":
                    addEvent.AddPhoto(photoFilepath.Text, MouseX, MouseY);
                    Application.Restart();
                    break;
                case "video":
                    addEvent.AddVideo(videoPath.Text, videoStart.Text, videoEnd.Text, MouseX, MouseY);
                    Application.Restart();
                    break;
                case "tracklog":
                    addEvent.AddTracklog(tracklogPath.Text, tracklogData.Text, tracklogStart.Text, tracklogEnd.Text ,MouseX, MouseY);
                    Application.Restart();
                    break;
            }
            this.Close();
        }

        private void rbFacebook_CheckedChanged(object sender, EventArgs e)
        {
            tweetPan.Visible = false;
            videoPan.Visible = false;
            photoPan.Visible = false;
            tracklogPan.Visible = false;

            facebookPan.Visible = true;
            facebookPan.BringToFront();

            eventType = "facebook";
        }

        private void rbTweet_CheckedChanged(object sender, EventArgs e)
        {
            photoPan.Visible = false;
            videoPan.Visible = false;
            tracklogPan.Visible = false;
            facebookPan.Visible = false;

            tweetPan.Visible = true;
            tweetPan.BringToFront();

            eventType = "tweet";
        }

        private void rbPhoto_CheckedChanged(object sender, EventArgs e)
        {
            tweetPan.Visible = false;
            videoPan.Visible = false;
            tracklogPan.Visible = false;
            facebookPan.Visible = false;

            photoPan.Visible = true;
            photoPan.BringToFront();

            eventType = "photo";
        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e)
        {
            tweetPan.Visible = false;
            photoPan.Visible = false;
            tracklogPan.Visible = false;
            facebookPan.Visible = false;

            videoPan.BringToFront();
            videoPan.Visible = true;

            eventType = "video";
        }

        private void rbTracklog_CheckedChanged(object sender, EventArgs e)
        {
            tweetPan.Visible = false;
            videoPan.Visible = false;
            photoPan.Visible = false;
            facebookPan.Visible = false;
            
            tracklogPan.Visible = true;
            tracklogPan.BringToFront();

            eventType = "tracklog";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
