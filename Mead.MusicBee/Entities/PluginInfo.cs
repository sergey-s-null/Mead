using System.Runtime.InteropServices;
using Mead.MusicBee.Enums;

namespace Mead.MusicBee.Entities;

[StructLayout(LayoutKind.Sequential)]
public sealed class PluginInfo
{
    public short PluginInfoVersion;
    public PluginType Type;
    public string Name = "";
    public string Description = "";
    public string Author = "";

    /// <summary>
    /// The name of a Plugin Storage device or panel header for a dockable panel.
    /// </summary>
    public string TargetApplication = "";

    public short VersionMajor;
    public short VersionMinor;
    public short Revision;
    public short MinInterfaceVersion;
    public short MinApiRevision;
    public ReceiveNotificationFlags ReceiveNotifications;

    /// <summary>
    /// Height in pixels that MusicBee should reserve in a panel for config settings.
    /// When set, a handle to an empty panel will be passed to the Configure function of a Plugin class.
    /// </summary>
    public int ConfigurationPanelHeight;
}