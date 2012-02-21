using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Growl.DisplayStyle;

namespace Growl.Displays.Visor
{
    public class VisorDisplay : MultiMonitorVisualDisplay
    {
        public const string SETTING_BGCOLOR = "BackgroundColor";
        public const string SETTING_BG_EMERGENCY = "BG_Emergency";
        public const string SETTING_BG_HIGH = "BG_High";
        public const string SETTING_BG_NORMAL = "BG_Normal";
        public const string SETTING_BG_LOW = "BG_Low";
        public const string SETTING_BG_VERYLOW = "BG_VeryLow";

        public static Color BG_COLOR = Color.FromArgb(69, 69, 69);

        private Queue<VisorWindow> queuedNotifications = new Queue<VisorWindow>();
        private bool isVisible;

        public VisorDisplay()
        {
            this.SettingsPanel = new VisorSettingsPanel();
        }

        public override string Name
        {
            get
            {
                return "Visor";
            }
        }

        public override string Description
        {
            get
            {
                return "Displays notifications in a slide-down window across the top of the screen.";
            }
        }

        public override string Author
        {
            get
            {
                return "Growl for Windows";
            }
        }

        public override string Website
        {
            get
            {
                return "http://www.growlforwindows.com";
            }
        }

        public override string Version
        {
            get
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
                System.Diagnostics.FileVersionInfo f = System.Diagnostics.FileVersionInfo.GetVersionInfo(a.Location);
                return f.FileVersion;
            }
        }

        public override void Load()
        {
            base.Load();
        }

        protected override void HandleNotification(Notification notification, string displayName)
        {
            VisorWindow win = new VisorWindow();
            win.Tag = this;
            win.BackColor = GetBackgroundColorFromPriority(notification.Priority);
            win.SetNotification(notification);

            win.FormClosed += new FormClosedEventHandler(win_FormClosed);

            this.queuedNotifications.Enqueue(win);
            WorkQueue();
        }

        private Color GetBackgroundColorFromPriority(int priority)
        {
            Color bgColor = GetColorFromSetting(SETTING_BG_NORMAL, BG_COLOR);
            switch (priority)
            {
                case 2:
                    bgColor = GetColorFromSetting(SETTING_BG_EMERGENCY, BG_COLOR);
                    break;
                case 1:
                    bgColor = GetColorFromSetting(SETTING_BG_HIGH, BG_COLOR);
                    break;
                case -1:
                    bgColor = GetColorFromSetting(SETTING_BG_LOW, BG_COLOR);
                    break;
                case -2:
                    bgColor = GetColorFromSetting(SETTING_BG_VERYLOW, BG_COLOR);
                    break;
            }
            return bgColor;
        }

        private Color GetColorFromSetting(string settingName, Color defaultColor)
        {
            Color color = defaultColor;
            if (this.SettingsCollection != null && this.SettingsCollection.ContainsKey(settingName))
            {
                try
                {
                    object val = this.SettingsCollection[settingName];
                    if (val is Color)
                    {
                        color = (Color)val;
                    }
                }
                catch
                {
                }
            }
            return color;
        }

        void WorkQueue()
        {
            if (!isVisible && this.queuedNotifications.Count > 0)
            {
                VisorWindow win = this.queuedNotifications.Dequeue();
                this.Show(win);
                isVisible = true;
            }
        }

        void win_FormClosed(object sender, FormClosedEventArgs e)
        {
            isVisible = false;
            WorkQueue();
        }

        public override void CloseAllOpenNotifications()
        {
            lock (this.queuedNotifications)
            {
                this.queuedNotifications.Clear();
            }
            base.CloseAllOpenNotifications();
        }
    }
}
