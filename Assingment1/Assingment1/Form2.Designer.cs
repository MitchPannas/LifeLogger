namespace Assingment1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.tweetPan = new System.Windows.Forms.Panel();
            this.tweetDate = new System.Windows.Forms.TextBox();
            this.tweetText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTweet = new System.Windows.Forms.RadioButton();
            this.rbTracklog = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbPhoto = new System.Windows.Forms.RadioButton();
            this.rbFacebook = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.facebookPan = new System.Windows.Forms.Panel();
            this.facebookDate = new System.Windows.Forms.TextBox();
            this.facebookText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.photoPan = new System.Windows.Forms.Panel();
            this.photoFilepath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.videoPan = new System.Windows.Forms.Panel();
            this.videoEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.videoStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.videoPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tracklogPan = new System.Windows.Forms.Panel();
            this.tracklogData = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tracklogEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tracklogStart = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tracklogPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tweetPan.SuspendLayout();
            this.facebookPan.SuspendLayout();
            this.photoPan.SuspendLayout();
            this.videoPan.SuspendLayout();
            this.tracklogPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(477, 30);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Event";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // tweetPan
            // 
            this.tweetPan.Controls.Add(this.tweetDate);
            this.tweetPan.Controls.Add(this.tweetText);
            this.tweetPan.Controls.Add(this.label4);
            this.tweetPan.Controls.Add(this.label2);
            this.tweetPan.Location = new System.Drawing.Point(217, 13);
            this.tweetPan.Name = "tweetPan";
            this.tweetPan.Size = new System.Drawing.Size(186, 81);
            this.tweetPan.TabIndex = 3;
            // 
            // tweetDate
            // 
            this.tweetDate.Location = new System.Drawing.Point(42, 27);
            this.tweetDate.Name = "tweetDate";
            this.tweetDate.Size = new System.Drawing.Size(134, 20);
            this.tweetDate.TabIndex = 7;
            // 
            // tweetText
            // 
            this.tweetText.Location = new System.Drawing.Point(42, 1);
            this.tweetText.Name = "tweetText";
            this.tweetText.Size = new System.Drawing.Size(134, 20);
            this.tweetText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text:";
            // 
            // rbTweet
            // 
            this.rbTweet.AutoSize = true;
            this.rbTweet.Checked = true;
            this.rbTweet.Location = new System.Drawing.Point(92, 13);
            this.rbTweet.Name = "rbTweet";
            this.rbTweet.Size = new System.Drawing.Size(55, 17);
            this.rbTweet.TabIndex = 4;
            this.rbTweet.TabStop = true;
            this.rbTweet.Text = "Tweet";
            this.rbTweet.UseVisualStyleBackColor = true;
            this.rbTweet.CheckedChanged += new System.EventHandler(this.rbTweet_CheckedChanged);
            // 
            // rbTracklog
            // 
            this.rbTracklog.AutoSize = true;
            this.rbTracklog.Location = new System.Drawing.Point(92, 105);
            this.rbTracklog.Name = "rbTracklog";
            this.rbTracklog.Size = new System.Drawing.Size(67, 17);
            this.rbTracklog.TabIndex = 5;
            this.rbTracklog.Text = "Tracklog";
            this.rbTracklog.UseVisualStyleBackColor = true;
            this.rbTracklog.CheckedChanged += new System.EventHandler(this.rbTracklog_CheckedChanged);
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(92, 82);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(52, 17);
            this.rbVideo.TabIndex = 6;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.rbVideo_CheckedChanged);
            // 
            // rbPhoto
            // 
            this.rbPhoto.AutoSize = true;
            this.rbPhoto.Location = new System.Drawing.Point(92, 59);
            this.rbPhoto.Name = "rbPhoto";
            this.rbPhoto.Size = new System.Drawing.Size(53, 17);
            this.rbPhoto.TabIndex = 7;
            this.rbPhoto.Text = "Photo";
            this.rbPhoto.UseVisualStyleBackColor = true;
            this.rbPhoto.CheckedChanged += new System.EventHandler(this.rbPhoto_CheckedChanged);
            // 
            // rbFacebook
            // 
            this.rbFacebook.AutoSize = true;
            this.rbFacebook.Location = new System.Drawing.Point(92, 36);
            this.rbFacebook.Name = "rbFacebook";
            this.rbFacebook.Size = new System.Drawing.Size(73, 17);
            this.rbFacebook.TabIndex = 8;
            this.rbFacebook.Text = "Facebook";
            this.rbFacebook.UseVisualStyleBackColor = true;
            this.rbFacebook.CheckedChanged += new System.EventHandler(this.rbFacebook_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event Type:";
            // 
            // facebookPan
            // 
            this.facebookPan.Controls.Add(this.facebookDate);
            this.facebookPan.Controls.Add(this.facebookText);
            this.facebookPan.Controls.Add(this.label7);
            this.facebookPan.Controls.Add(this.label9);
            this.facebookPan.Location = new System.Drawing.Point(217, 13);
            this.facebookPan.Name = "facebookPan";
            this.facebookPan.Size = new System.Drawing.Size(244, 110);
            this.facebookPan.TabIndex = 8;
            this.facebookPan.Visible = false;
            // 
            // facebookDate
            // 
            this.facebookDate.Location = new System.Drawing.Point(43, 27);
            this.facebookDate.Name = "facebookDate";
            this.facebookDate.Size = new System.Drawing.Size(134, 20);
            this.facebookDate.TabIndex = 7;
            // 
            // facebookText
            // 
            this.facebookText.Location = new System.Drawing.Point(43, 1);
            this.facebookText.Name = "facebookText";
            this.facebookText.Size = new System.Drawing.Size(134, 20);
            this.facebookText.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Text:";
            // 
            // photoPan
            // 
            this.photoPan.Controls.Add(this.photoFilepath);
            this.photoPan.Controls.Add(this.label13);
            this.photoPan.Location = new System.Drawing.Point(217, 13);
            this.photoPan.Name = "photoPan";
            this.photoPan.Size = new System.Drawing.Size(244, 110);
            this.photoPan.TabIndex = 9;
            this.photoPan.Visible = false;
            // 
            // photoFilepath
            // 
            this.photoFilepath.Location = new System.Drawing.Point(56, 0);
            this.photoFilepath.Name = "photoFilepath";
            this.photoFilepath.Size = new System.Drawing.Size(134, 20);
            this.photoFilepath.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Filepath:";
            // 
            // videoPan
            // 
            this.videoPan.Controls.Add(this.videoEnd);
            this.videoPan.Controls.Add(this.label6);
            this.videoPan.Controls.Add(this.videoStart);
            this.videoPan.Controls.Add(this.label5);
            this.videoPan.Controls.Add(this.videoPath);
            this.videoPan.Controls.Add(this.label3);
            this.videoPan.Location = new System.Drawing.Point(217, 13);
            this.videoPan.Name = "videoPan";
            this.videoPan.Size = new System.Drawing.Size(244, 110);
            this.videoPan.TabIndex = 12;
            this.videoPan.Visible = false;
            // 
            // videoEnd
            // 
            this.videoEnd.Location = new System.Drawing.Point(56, 52);
            this.videoEnd.Name = "videoEnd";
            this.videoEnd.Size = new System.Drawing.Size(134, 20);
            this.videoEnd.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endtime:";
            // 
            // videoStart
            // 
            this.videoStart.Location = new System.Drawing.Point(56, 26);
            this.videoStart.Name = "videoStart";
            this.videoStart.Size = new System.Drawing.Size(134, 20);
            this.videoStart.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Starttime:";
            // 
            // videoPath
            // 
            this.videoPath.Location = new System.Drawing.Point(56, 0);
            this.videoPath.Name = "videoPath";
            this.videoPath.Size = new System.Drawing.Size(134, 20);
            this.videoPath.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filepath:";
            // 
            // tracklogPan
            // 
            this.tracklogPan.Controls.Add(this.tracklogData);
            this.tracklogPan.Controls.Add(this.label12);
            this.tracklogPan.Controls.Add(this.tracklogEnd);
            this.tracklogPan.Controls.Add(this.label8);
            this.tracklogPan.Controls.Add(this.tracklogStart);
            this.tracklogPan.Controls.Add(this.label10);
            this.tracklogPan.Controls.Add(this.tracklogPath);
            this.tracklogPan.Controls.Add(this.label11);
            this.tracklogPan.Location = new System.Drawing.Point(217, 13);
            this.tracklogPan.Name = "tracklogPan";
            this.tracklogPan.Size = new System.Drawing.Size(244, 110);
            this.tracklogPan.TabIndex = 13;
            this.tracklogPan.Visible = false;
            // 
            // tracklogData
            // 
            this.tracklogData.Location = new System.Drawing.Point(60, 26);
            this.tracklogData.Name = "tracklogData";
            this.tracklogData.Size = new System.Drawing.Size(134, 20);
            this.tracklogData.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Data:";
            // 
            // tracklogEnd
            // 
            this.tracklogEnd.Location = new System.Drawing.Point(60, 81);
            this.tracklogEnd.Name = "tracklogEnd";
            this.tracklogEnd.Size = new System.Drawing.Size(134, 20);
            this.tracklogEnd.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Endtime:";
            // 
            // tracklogStart
            // 
            this.tracklogStart.Location = new System.Drawing.Point(60, 55);
            this.tracklogStart.Name = "tracklogStart";
            this.tracklogStart.Size = new System.Drawing.Size(134, 20);
            this.tracklogStart.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Starttime:";
            // 
            // tracklogPath
            // 
            this.tracklogPath.Location = new System.Drawing.Point(60, 0);
            this.tracklogPath.Name = "tracklogPath";
            this.tracklogPath.Size = new System.Drawing.Size(134, 20);
            this.tracklogPath.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Filepath:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tracklogPan);
            this.Controls.Add(this.photoPan);
            this.Controls.Add(this.videoPan);
            this.Controls.Add(this.facebookPan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbFacebook);
            this.Controls.Add(this.rbPhoto);
            this.Controls.Add(this.rbVideo);
            this.Controls.Add(this.rbTracklog);
            this.Controls.Add(this.rbTweet);
            this.Controls.Add(this.tweetPan);
            this.Controls.Add(this.addBtn);
            this.MaximumSize = new System.Drawing.Size(580, 184);
            this.MinimumSize = new System.Drawing.Size(580, 184);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Adder";
            this.tweetPan.ResumeLayout(false);
            this.tweetPan.PerformLayout();
            this.facebookPan.ResumeLayout(false);
            this.facebookPan.PerformLayout();
            this.photoPan.ResumeLayout(false);
            this.photoPan.PerformLayout();
            this.videoPan.ResumeLayout(false);
            this.videoPan.PerformLayout();
            this.tracklogPan.ResumeLayout(false);
            this.tracklogPan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel tweetPan;
        private System.Windows.Forms.TextBox tweetDate;
        private System.Windows.Forms.TextBox tweetText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTweet;
        private System.Windows.Forms.RadioButton rbTracklog;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbPhoto;
        private System.Windows.Forms.RadioButton rbFacebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel facebookPan;
        private System.Windows.Forms.TextBox facebookDate;
        private System.Windows.Forms.TextBox facebookText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel photoPan;
        private System.Windows.Forms.TextBox photoFilepath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel videoPan;
        private System.Windows.Forms.TextBox videoEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox videoStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox videoPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel tracklogPan;
        private System.Windows.Forms.TextBox tracklogData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tracklogEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tracklogStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tracklogPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}