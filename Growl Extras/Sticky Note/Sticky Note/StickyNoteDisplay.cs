using System;
using System.Collections.Generic;
using System.Text;
using Growl.DisplayStyle;

namespace StickyNote
{
    public class StickyNoteDisplay : MultiMonitorVisualDisplay
    {
        public const string SETTING_DISPLAYLOCATION = "DisplayLocation";
        public const string SETTING_EXCLUSIONS = "Exclusions";
        LayoutManager tllm = new LayoutManager(LayoutManager.AutoPositionDirection.DownRight, 6, 6);
        LayoutManager bllm = new LayoutManager(LayoutManager.AutoPositionDirection.UpRight, 6, 6);
        LayoutManager trlm = new LayoutManager(LayoutManager.AutoPositionDirection.DownLeft, 6, 6);
        LayoutManager brlm = new LayoutManager(LayoutManager.AutoPositionDirection.UpLeft, 6, 6);

        public StickyNoteDisplay()
            : base()
        {
            this.SettingsPanel = new StickyNoteSettingsPanel();
        }

        public override string Name
        {
            get
            {
                return "Sticky Note";
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

        public override string Website
        {
            get
            {
                return "http://www.growlforwindows.com";
            }
        }

        public override string Author
        {
            get
            {
                return "Rory O'Kelly";
            }
        }

        public override string Description
        {
            get
            {
                return "Posts notifications on familiar yellow sticky notes.";
            }
        }

        protected override void HandleNotification(Notification notification, string displayName)
        {
            StickyNoteWindow win = new StickyNoteWindow();
            win.Tag = this;
            //if (NotificationMeetsRules(notification,GetExclusionsFromSetting()))
            //{
            //    notification.Description = "true";
            //}
            win.SetNotification(notification);
            win.SetDisplayLocation(GetLocationFromSetting());

            this.Show(win);
        }


        private bool NotificationMeetsRules(Notification notification, string exclusions){
            String[] excludelist = exclusions.Split(',');
            
            foreach(String e in excludelist){
                if (notification.Description.Contains(e)) return true;
            }
            return false;
        }
        protected override LayoutManager GetLayoutManager(NotificationWindow nw)
        {
            StickyNoteWindow win = (StickyNoteWindow)nw;
            switch (win.DisplayLocation)
            {
                case Location.TopLeft:
                    return tllm;
                case Location.BottomLeft:
                    return bllm;
                case Location.TopRight:
                    return trlm;
                default:
                    return brlm;
            }
        }
        private String GetExclusionsFromSetting()
        {
            String exclusions = "";
            if (this.SettingsCollection != null && this.SettingsCollection.ContainsKey(SETTING_EXCLUSIONS))
            {
                try
                {
                    object val = this.SettingsCollection[SETTING_EXCLUSIONS];
                    if (val != null)
                    {
                        exclusions = (String)val;
                    }
                }
                catch
                {
                }
            }
            return exclusions;
        }
        private Location GetLocationFromSetting()
        {
            Location location = Location.TopRight;
            if (this.SettingsCollection != null && this.SettingsCollection.ContainsKey(SETTING_DISPLAYLOCATION))
            {
                try
                {
                    object val = this.SettingsCollection[SETTING_DISPLAYLOCATION];
                    if (val != null)
                    {
                        location = (Location)val;
                    }
                }
                catch
                {
                }
            }
            return location;
        }

        public enum Location
        {
            TopLeft = 1,
            TopRight = 2,
            BottomLeft = 3,
            BottomRight = 4
        }
    }
}
