using System;
using System.Windows.Forms;
using Mead.MusicBee.Enums;
using Mead.MusicBee.Services;

namespace Mead.MusicBee.Entities;

public abstract class PluginBase
{
    public PluginInfo Initialise(IntPtr apiInterfacePtr)
    {
        var musicBeeApi = new MusicBeeApiMemoryContainer();
        musicBeeApi.Initialise(apiInterfacePtr);
        OnMusicBeeApiProvided(musicBeeApi);

        return GetPluginInfo();
    }

    protected abstract void OnMusicBeeApiProvided(MusicBeeApiMemoryContainer musicBeeApi);

    protected abstract PluginInfo GetPluginInfo();

    /// <summary>
    /// If <see cref="PluginInfo.ConfigurationPanelHeight"/> is set to a non-zero value,
    /// then panelHandle will contain pointer to <see cref="Panel"/>, which you can configure to provide any settings to user.
    /// <br/>
    /// Otherwise you can use this method to display your own popup window.
    /// </summary>
    /// <param name="panelHandle">
    /// Pointer to Panel.
    /// </param>
    /// <returns></returns>
    /// <remarks>
    /// To get Panel from pointer you can use <code>(Panel)Panel.FromHandle(panelHandle);</code>
    /// <br/>
    /// Keep in mind the panel width is scaled according to the font the user has selected
    /// </remarks>
    public virtual bool Configure(IntPtr panelHandle)
    {
        return false;
    }

    /// <summary>
    /// Called by MusicBee when the user clicks Apply or Save in the MusicBee Preferences screen.
    /// Its up to you to figure out whether anything has changed and needs updating.
    /// </summary>
    public virtual void SaveSettings()
    {
    }

    /// <summary>
    /// MusicBee is closing the plugin (plugin is being disabled by user or MusicBee is shutting down).
    /// </summary>
    public virtual void Close(PluginCloseReason reason)
    {
    }

    /// <summary>
    /// Uninstall this plugin - clean up any persisted files.
    /// </summary>
    public virtual void Uninstall()
    {
    }

    /// <summary>
    /// Receive event notifications from MusicBee.
    /// <br/>
    /// You need to set <see cref="PluginInfo.ReceiveNotifications"/> to <see cref="ReceiveNotificationFlags.PlayerEvents"/> to receive all notifications, and not just the startup event.
    /// </summary>
    public virtual void ReceiveNotification(string sourceFileUrl, NotificationType type)
    {
    }
}