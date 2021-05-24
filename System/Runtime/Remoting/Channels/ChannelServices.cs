[ComVisibleAttribute] // RVA: 0xB0E20 Offset: 0xB0F21 VA: 0xB0E20
public sealed class ChannelServices // TypeDefIndex: 1160
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x173CAF0 Offset: 0x173CBF1 VA: 0x173CAF0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x173CB60 Offset: 0x173CC61 VA: 0x173CB60
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x173D490 Offset: 0x173D591 VA: 0x173D490
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xB9470 Offset: 0xB9571 VA: 0xB9470
	// RVA: 0x173D700 Offset: 0x173D801 VA: 0x173D700
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x173D770 Offset: 0x173D871 VA: 0x173D770
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x173E0A0 Offset: 0x173E1A1 VA: 0x173E0A0
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x173EFC0 Offset: 0x173F0C1 VA: 0x173EFC0
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x173F300 Offset: 0x173F401 VA: 0x173F300
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x173F3E0 Offset: 0x173F4E1 VA: 0x173F3E0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x173F670 Offset: 0x173F771 VA: 0x173F670
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x173FDF0 Offset: 0x173FEF1 VA: 0x173FDF0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x173C210 Offset: 0x173C311 VA: 0x173C210
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x173FF50 Offset: 0x1740051 VA: 0x173FF50
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0E20 Offset: 0xB0F21 VA: 0xB0E20
public sealed class ChannelServices // TypeDefIndex: 1160
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x173CAF0 Offset: 0x173CBF1 VA: 0x173CAF0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x173CB60 Offset: 0x173CC61 VA: 0x173CB60
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x173D490 Offset: 0x173D591 VA: 0x173D490
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xB9470 Offset: 0xB9571 VA: 0xB9470
	// RVA: 0x173D700 Offset: 0x173D801 VA: 0x173D700
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x173D770 Offset: 0x173D871 VA: 0x173D770
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x173E0A0 Offset: 0x173E1A1 VA: 0x173E0A0
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x173EFC0 Offset: 0x173F0C1 VA: 0x173EFC0
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x173F300 Offset: 0x173F401 VA: 0x173F300
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x173F3E0 Offset: 0x173F4E1 VA: 0x173F3E0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x173F670 Offset: 0x173F771 VA: 0x173F670
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x173FDF0 Offset: 0x173FEF1 VA: 0x173FDF0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x173C210 Offset: 0x173C311 VA: 0x173C210
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x173FF50 Offset: 0x1740051 VA: 0x173FF50
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0E20 Offset: 0xB0F21 VA: 0xB0E20
public sealed class ChannelServices // TypeDefIndex: 1160
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x173CAF0 Offset: 0x173CBF1 VA: 0x173CAF0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x173CB60 Offset: 0x173CC61 VA: 0x173CB60
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x173D490 Offset: 0x173D591 VA: 0x173D490
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xB9470 Offset: 0xB9571 VA: 0xB9470
	// RVA: 0x173D700 Offset: 0x173D801 VA: 0x173D700
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x173D770 Offset: 0x173D871 VA: 0x173D770
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x173E0A0 Offset: 0x173E1A1 VA: 0x173E0A0
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x173EFC0 Offset: 0x173F0C1 VA: 0x173EFC0
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x173F300 Offset: 0x173F401 VA: 0x173F300
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x173F3E0 Offset: 0x173F4E1 VA: 0x173F3E0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x173F670 Offset: 0x173F771 VA: 0x173F670
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x173FDF0 Offset: 0x173FEF1 VA: 0x173FDF0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x173C210 Offset: 0x173C311 VA: 0x173C210
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x173FF50 Offset: 0x1740051 VA: 0x173FF50
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0E20 Offset: 0xB0F21 VA: 0xB0E20
public sealed class ChannelServices // TypeDefIndex: 1160
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x173CAF0 Offset: 0x173CBF1 VA: 0x173CAF0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x173CB60 Offset: 0x173CC61 VA: 0x173CB60
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x173D490 Offset: 0x173D591 VA: 0x173D490
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xB9470 Offset: 0xB9571 VA: 0xB9470
	// RVA: 0x173D700 Offset: 0x173D801 VA: 0x173D700
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x173D770 Offset: 0x173D871 VA: 0x173D770
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x173E0A0 Offset: 0x173E1A1 VA: 0x173E0A0
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x173EFC0 Offset: 0x173F0C1 VA: 0x173EFC0
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x173F300 Offset: 0x173F401 VA: 0x173F300
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x173F3E0 Offset: 0x173F4E1 VA: 0x173F3E0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x173F670 Offset: 0x173F771 VA: 0x173F670
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x173FDF0 Offset: 0x173FEF1 VA: 0x173FDF0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x173C210 Offset: 0x173C311 VA: 0x173C210
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x173FF50 Offset: 0x1740051 VA: 0x173FF50
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0E20 Offset: 0xB0F21 VA: 0xB0E20
public sealed class ChannelServices // TypeDefIndex: 1160
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x173CAF0 Offset: 0x173CBF1 VA: 0x173CAF0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x173CB60 Offset: 0x173CC61 VA: 0x173CB60
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x173D490 Offset: 0x173D591 VA: 0x173D490
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xB9470 Offset: 0xB9571 VA: 0xB9470
	// RVA: 0x173D700 Offset: 0x173D801 VA: 0x173D700
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x173D770 Offset: 0x173D871 VA: 0x173D770
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x173E0A0 Offset: 0x173E1A1 VA: 0x173E0A0
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x173EFC0 Offset: 0x173F0C1 VA: 0x173EFC0
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x173F300 Offset: 0x173F401 VA: 0x173F300
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x173F3E0 Offset: 0x173F4E1 VA: 0x173F3E0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x173F670 Offset: 0x173F771 VA: 0x173F670
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x173FDF0 Offset: 0x173FEF1 VA: 0x173FDF0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x173C210 Offset: 0x173C311 VA: 0x173C210
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x173FF50 Offset: 0x1740051 VA: 0x173FF50
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0E20 Offset: 0xB0F21 VA: 0xB0E20
public sealed class ChannelServices // TypeDefIndex: 1160
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x173CAF0 Offset: 0x173CBF1 VA: 0x173CAF0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x173CB60 Offset: 0x173CC61 VA: 0x173CB60
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x173D490 Offset: 0x173D591 VA: 0x173D490
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xB9470 Offset: 0xB9571 VA: 0xB9470
	// RVA: 0x173D700 Offset: 0x173D801 VA: 0x173D700
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x173D770 Offset: 0x173D871 VA: 0x173D770
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x173E0A0 Offset: 0x173E1A1 VA: 0x173E0A0
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x173EFC0 Offset: 0x173F0C1 VA: 0x173EFC0
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x173F300 Offset: 0x173F401 VA: 0x173F300
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x173F3E0 Offset: 0x173F4E1 VA: 0x173F3E0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x173F670 Offset: 0x173F771 VA: 0x173F670
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x173FDF0 Offset: 0x173FEF1 VA: 0x173FDF0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x173C210 Offset: 0x173C311 VA: 0x173C210
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x173FF50 Offset: 0x1740051 VA: 0x173FF50
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0E20 Offset: 0xB0F21 VA: 0xB0E20
public sealed class ChannelServices // TypeDefIndex: 1160
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x173CAF0 Offset: 0x173CBF1 VA: 0x173CAF0
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x173CB60 Offset: 0x173CC61 VA: 0x173CB60
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x173D490 Offset: 0x173D591 VA: 0x173D490
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute] // RVA: 0xB9470 Offset: 0xB9571 VA: 0xB9470
	// RVA: 0x173D700 Offset: 0x173D801 VA: 0x173D700
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x173D770 Offset: 0x173D871 VA: 0x173D770
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x173E0A0 Offset: 0x173E1A1 VA: 0x173E0A0
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x173EFC0 Offset: 0x173F0C1 VA: 0x173EFC0
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x173F300 Offset: 0x173F401 VA: 0x173F300
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x173F3E0 Offset: 0x173F4E1 VA: 0x173F3E0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x173F670 Offset: 0x173F771 VA: 0x173F670
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x173FDF0 Offset: 0x173FEF1 VA: 0x173FDF0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x173C210 Offset: 0x173C311 VA: 0x173C210
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x173FF50 Offset: 0x1740051 VA: 0x173FF50
	private static void .cctor() { }
}

