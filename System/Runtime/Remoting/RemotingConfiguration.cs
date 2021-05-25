[ComVisibleAttribute] // RVA: 0xB0AA0 Offset: 0xB0BA1 VA: 0xB0AA0
public static class RemotingConfiguration // TypeDefIndex: 1110
{
	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static string _errorMode; // 0x20
	private static Hashtable wellKnownClientEntries; // 0x28
	private static Hashtable activatedClientEntries; // 0x30
	private static Hashtable wellKnownServiceEntries; // 0x38
	private static Hashtable activatedServiceEntries; // 0x40
	private static Hashtable channelTemplates; // 0x48
	private static Hashtable clientProviderTemplates; // 0x50
	private static Hashtable serverProviderTemplates; // 0x58

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x15F3790 Offset: 0x15F3891 VA: 0x15F3790
	public static string get_ApplicationName() { }

	// RVA: 0x15F3800 Offset: 0x15F3901 VA: 0x15F3800
	public static void set_ApplicationName(string value) { }

	// RVA: 0x15F3870 Offset: 0x15F3971 VA: 0x15F3870
	public static string get_ProcessId() { }

	// RVA: 0x15F3950 Offset: 0x15F3A51 VA: 0x15F3950
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x15F3CC0 Offset: 0x15F3DC1 VA: 0x15F3CC0
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x15F3E50 Offset: 0x15F3F51 VA: 0x15F3E50
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x15F3FE0 Offset: 0x15F40E1 VA: 0x15F3FE0
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x15F42B0 Offset: 0x15F43B1 VA: 0x15F42B0
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x15F43F0 Offset: 0x15F44F1 VA: 0x15F43F0
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x15F46C0 Offset: 0x15F47C1 VA: 0x15F46C0
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x15F4970 Offset: 0x15F4A71 VA: 0x15F4970
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x15F4A00 Offset: 0x15F4B01 VA: 0x15F4A00
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x15F4A90 Offset: 0x15F4B91 VA: 0x15F4A90
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x15F4B20 Offset: 0x15F4C21 VA: 0x15F4B20
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x15F57E0 Offset: 0x15F58E1 VA: 0x15F57E0
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x15F5CD0 Offset: 0x15F5DD1 VA: 0x15F5CD0
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x15F5DB0 Offset: 0x15F5EB1 VA: 0x15F5DB0
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x15F5F10 Offset: 0x15F6011 VA: 0x15F5F10
	private static void .cctor() { }
}

