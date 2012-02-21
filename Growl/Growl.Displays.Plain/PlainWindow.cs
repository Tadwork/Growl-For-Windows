using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Growl.DisplayStyle;

namespace Growl.Displays.Plain
{
    public partial class PlainWindow : NotificationWindow
    {
        private PlainDisplay.Location location = PlainDisplay.Location.TopRight;

        private int leftXLocation = 0;
        private int rightXLocation = 0;
        private int topYLocation = 0;
        private int bottomYLocation = 0;

        public PlainWindow()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(51, 51, 51);

            this.PauseWhenMouseOver = true;

            this.AfterLoad += new EventHandler(PlainWindow_AfterLoad);

            this.Animator = new FadeAnimator(this);

            HookUpClickEvents(this);

            this.SetAutoCloseInterval(4000);
        }

        void PlainWindow_AfterLoad(object sender, EventArgs e)
        {
            DoBeforeShow();
        }

        public PlainDisplay.Location DisplayLocation
        {
            get
            {
                return this.location;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Rectangle rect = new Rectangle(this.Bounds.X, this.Bounds.Y, this.Bounds.Width, this.Bounds.Height);
            //Rectangle rect = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            //Rectangle rect = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height);
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            e.Graphics.Clear(this.ForeColor);

            rect.Inflate(-1, -1);
            Brush b2 = new SolidBrush(this.BackColor);
            using (b2)
            {
                e.Graphics.FillRectangle(b2, rect);
            }
        }

        public override void SetNotification(Notification n)
        {
            base.SetNotification(n);

            if (n.Duration > 0) this.SetAutoCloseInterval(n.Duration * 1000);

            // handle the image. if the image is not set, move the other controls over to compensate
            Image image = n.Image;
            if (image != null)
            {
                this.pictureBox1.Image = image;
                this.pictureBox1.Visible = true;

                int offset = this.pictureBox1.Width + 6;
                this.applicationNameLabel.Left = this.titleLabel.Left + offset;
                this.applicationNameLabel.Width = this.titleLabel.Width - offset;
                this.titleLabel.Left = this.titleLabel.Left + offset;
                this.titleLabel.Width = this.titleLabel.Width - offset;
                this.descriptionLabel.Left = this.descriptionLabel.Left + offset;
                this.descriptionLabel.Width = this.descriptionLabel.Width - offset;
            }
            else
            {
                this.pictureBox1.Visible = false;
            }

            this.applicationNameLabel.Text = n.ApplicationName;
            this.titleLabel.Text = n.Title;
            this.descriptionLabel.Text = n.Description.Replace("\n", "\r\n");
            this.Sticky = n.Sticky;
        }

        public void SetDisplayLocation(PlainDisplay.Location location)
        {
            this.location = location;
        }

        /// <summary>
        /// By handling the LabelHeightChanged events, you can make sure you notification window
        /// will expand properly to fit all of the text. In order to take advantage of this event,
        /// you must use ExpandingLabel class in place of normal Labels.
        /// </summary>
        private void titleLabel_LabelHeightChanged(ExpandingLabel.LabelHeightChangedEventArgs args)
        {
            this.pictureBox1.Top += args.HeightChange;
            this.descriptionLabel.Top += args.HeightChange;
            descriptionLabel_LabelHeightChanged(args);
        }

        /// <summary>
        /// By handling the LabelHeightChanged events, you can make sure you notification window
        /// will expand properly to fit all of the text. In order to take advantage of this event,
        /// you must use ExpandingLabel class in place of normal Labels.
        /// </summary>
        private void descriptionLabel_LabelHeightChanged(ExpandingLabel.LabelHeightChangedEventArgs args)
        {
            this.applicationNameLabel.Top += args.HeightChange;
            applicationNameLabel_LabelHeightChanged(args);
        }

        /// <summary>
        /// By handling the LabelHeightChanged events, you can make sure you notification window
        /// will expand properly to fit all of the text. In order to take advantage of this event,
        /// you must use ExpandingLabel class in place of normal Labels.
        /// </summary>
        private void applicationNameLabel_LabelHeightChanged(ExpandingLabel.LabelHeightChangedEventArgs args)
        {
            if (args.HeightChange != 0)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height + args.HeightChange);
                this.Location = new Point(this.Location.X, this.Location.Y - args.HeightChange);
            }
        }

        private void DoBeforeShow()
        {
            // multiple monitor support
            MultiMonitorVisualDisplay d = (MultiMonitorVisualDisplay)this.Tag;
            Screen screen = d.GetPreferredDisplay();

            // set initial location
            this.leftXLocation = screen.WorkingArea.Left;
            this.rightXLocation = screen.WorkingArea.Right - this.Width;
            this.topYLocation = screen.WorkingArea.Top;
            this.bottomYLocation = screen.WorkingArea.Bottom - this.Height;

            switch (location)
            {
                case PlainDisplay.Location.TopLeft:
                    this.Location = new Point(this.leftXLocation, this.topYLocation);
                    break;
                case PlainDisplay.Location.BottomLeft:
                    this.Location = new Point(this.leftXLocation, this.bottomYLocation);
                    break;
                case PlainDisplay.Location.BottomRight:
                    this.Location = new Point(this.rightXLocation, this.bottomYLocation);
                    break;
                default: // TopRight
                    this.Location = new Point(this.rightXLocation, this.topYLocation);
                    break;
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.pictureBox1 != null) this.pictureBox1.Dispose();
                if(components != null) components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}