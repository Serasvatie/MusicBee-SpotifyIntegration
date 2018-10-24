using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBeePlugin
{
    public partial class Plugin
    {
        #region Déclaration
        private MusicBeeApiInterface _mbApiInterface;
        private PluginInfo _about;
        #endregion

        public PluginInfo Initialise(IntPtr apiInterfacePtr)
        {
            _mbApiInterface = new MusicBeeApiInterface();
            _mbApiInterface.Initialise(apiInterfacePtr);
            _about = new PluginInfo();
            _about.Author = "Serasvatie";
            _about.Description = "This plugin allows users to interact with their Spotify";
            _about.Name = "MusicBee-SpotifyIntegration";
            _about.PluginInfoVersion = PluginInfoVersion;
            _about.TargetApplication = "Spotify";
            _about.Type = PluginType.PanelView;
            _about.VersionMinor = 0;
            _about.VersionMajor = 1;
            _about.Revision = 0;
            _about.MinInterfaceVersion = MinInterfaceVersion;
            _about.MinApiRevision = MinApiRevision;
            _about.ReceiveNotifications = ReceiveNotificationFlags.PlayerEvents | ReceiveNotificationFlags.TagEvents | ReceiveNotificationFlags.DataStreamEvents;
            return _about;
        }

        public bool Configure(IntPtr panelHandle)
        {
            return true;
        }

        public void SaveSettings()
        {
        }

        public void Close(PluginCloseReason reason)
        {
        }

        public void Uninstall()
        {
        }

        public void ReceiveNotification(string sourceFileUrl, NotificationType type)
        {
        }
    }
}