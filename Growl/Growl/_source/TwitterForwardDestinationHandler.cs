using System;
using System.Collections.Generic;
using System.Text;
using Growl.Destinations;

namespace Growl
{
    public class TwitterForwardDestinationHandler : IForwardDestinationHandler
    {
        #region IForwardDestinationHandler Members

        public string Name
        {
            get
            {
                return "Twitter";
            }
        }

        public List<Type> Register()
        {
            List<Type> list = new List<Type>();
            list.Add(typeof(TwitterForwardDestination));
            return list;
        }

        public Growl.Destinations.DestinationSettingsPanel GetSettingsPanel(DestinationBase db)
        {
            return new Growl.UI.TwitterForwardInputs();
        }

        public Growl.Destinations.DestinationSettingsPanel GetSettingsPanel(DestinationListItem fdli)
        {
            return new Growl.UI.TwitterForwardInputs();
        }

        public List<DestinationListItem> GetListItems()
        {
            /* REMOVED 08.06.2010 - no workable solution for Twitter oAuth and open source projects, so forwarding to Twitter has been removed
            ForwardDestinationListItem item = new ForwardDestinationListItem(Properties.Resources.AddComputer_AddTwitter, KnownDestinationPlatformType.Twitter.GetIcon(), this);
            List<DestinationListItem> list = new List<DestinationListItem>();
            list.Add(item);
            return list;
             * */
            return new List<DestinationListItem>();
        }

        #endregion
    }
}