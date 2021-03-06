using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Growl.DisplayStyle;

namespace StickyNote
{
    public partial class StickyNoteSettingsPanel : SettingsPanelBase
    {
        private static Point TOP_LEFT = new Point(19, 14);
        private static Point TOP_RIGHT = new Point(82, 14);
        private static Point BOTTOM_LEFT = new Point(16, 69);
        private static Point BOTTOM_RIGHT = new Point(86, 69);

        private Point overlayPosition = TOP_RIGHT;
        private String excludewith;

        public StickyNoteSettingsPanel()
        {
            InitializeComponent();
        }

        private void StickyNoteSettingsPanel_Load(object sender, EventArgs e)
        {
            this.computerScreenPictureBox.Image = global::StickyNote.Properties.Resources.my_computer;
            this.overlayPosition = GetLocation();
            this.excludewith = GetExclusions();
            this.computerScreenPictureBox.Paint += new PaintEventHandler(computerScreenPictureBox_Paint);
        }

        private String GetExclusions()
        {   
            Dictionary<string, object> settings = this.GetSettings();
            String exclusions = "";
            if (settings != null && settings.ContainsKey(StickyNoteDisplay.SETTING_EXCLUSIONS))
            {
                try
                {
                    object val = settings[StickyNoteDisplay.SETTING_EXCLUSIONS];
                    exclusions = Convert.ToString(val);
                    this.txtExclusions.Text = exclusions;
                }
                catch
                {
                }
            }
            return exclusions;
        }

        void computerScreenPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(global::StickyNote.Properties.Resources.overlay, this.overlayPosition);
        }

        private Point GetLocation()
        {
            Point p = TOP_RIGHT;
            Dictionary<string, object> settings = this.GetSettings();
            if (settings != null && settings.ContainsKey(StickyNoteDisplay.SETTING_DISPLAYLOCATION))
            {
                try
                {
                    object val = settings[StickyNoteDisplay.SETTING_DISPLAYLOCATION];
                    int i = Convert.ToInt32(val);
                    switch (i)
                    {
                        case 2:
                            p = TOP_RIGHT;
                            break;
                        case 3:
                            p = BOTTOM_LEFT;
                            break;
                        case 4:
                            p = BOTTOM_RIGHT;
                            break;
                        default:
                            p = TOP_LEFT;
                            break;
                    }
                }
                catch
                {
                }
            }
            return p;
        }

        private void SaveLocation()
        {
            int i = 1;

            if (this.overlayPosition == TOP_RIGHT) i = 2;
            else if (this.overlayPosition == BOTTOM_LEFT) i = 3;
            else if (this.overlayPosition == BOTTOM_RIGHT) i = 4;
            else i = 1;

            this.SaveSetting(StickyNoteDisplay.SETTING_DISPLAYLOCATION, i);
        }
        private void SaveExclusions()
        {
            excludewith = this.txtExclusions.Text;
            this.SaveSetting(StickyNoteDisplay.SETTING_EXCLUSIONS, this.excludewith);
        }
        private void computerScreenPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            int leftRightLine = this.computerScreenPictureBox.Width / 2;
            int topBottomLine = (this.computerScreenPictureBox.Height - 40) / 2;

            this.overlayPosition = TOP_RIGHT;

            if (e.X > leftRightLine)
            {
                this.overlayPosition = (e.Y > topBottomLine ? BOTTOM_RIGHT : TOP_RIGHT);
            }
            else
            {
                this.overlayPosition = (e.Y > topBottomLine ? BOTTOM_LEFT : TOP_LEFT);
            }

            SaveLocation();

            this.computerScreenPictureBox.Invalidate();
        }


        private void txtExclusions_TextChanged(object sender, EventArgs e)
        {
            SaveExclusions();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
