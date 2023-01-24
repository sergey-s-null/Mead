﻿using System.Runtime.InteropServices;
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
    public string TargetApplication = "";
    public short VersionMajor;
    public short VersionMinor;
    public short Revision;
    public short MinInterfaceVersion;
    public short MinApiRevision;
    public ReceiveNotificationFlags ReceiveNotifications;
    public int ConfigurationPanelHeight;
}