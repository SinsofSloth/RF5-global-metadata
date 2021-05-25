[Serializable]
public class ContentCatalogData // TypeDefIndex: 5725
{
	// Fields
	internal string localHash; // 0x10
	internal IResourceLocation location; // 0x18
	[SerializeField] // RVA: 0x13DE10 Offset: 0x13DF11 VA: 0x13DE10
	internal string m_LocatorId; // 0x20
	[SerializeField] // RVA: 0x13DE20 Offset: 0x13DF21 VA: 0x13DE20
	private ObjectInitializationData m_InstanceProviderData; // 0x28
	[SerializeField] // RVA: 0x13DE30 Offset: 0x13DF31 VA: 0x13DE30
	private ObjectInitializationData m_SceneProviderData; // 0x58
	[SerializeField] // RVA: 0x13DE40 Offset: 0x13DF41 VA: 0x13DE40
	internal List<ObjectInitializationData> m_ResourceProviderData; // 0x88
	[SerializeField] // RVA: 0x13DE50 Offset: 0x13DF51 VA: 0x13DE50
	[FormerlySerializedAsAttribute] // RVA: 0x13DE50 Offset: 0x13DF51 VA: 0x13DE50
	internal string[] m_ProviderIds; // 0x90
	[SerializeField] // RVA: 0x13DEA0 Offset: 0x13DFA1 VA: 0x13DEA0
	[FormerlySerializedAsAttribute] // RVA: 0x13DEA0 Offset: 0x13DFA1 VA: 0x13DEA0
	internal string[] m_InternalIds; // 0x98
	[FormerlySerializedAsAttribute] // RVA: 0x13DEF0 Offset: 0x13DFF1 VA: 0x13DEF0
	[SerializeField] // RVA: 0x13DEF0 Offset: 0x13DFF1 VA: 0x13DEF0
	internal string m_KeyDataString; // 0xA0
	[SerializeField] // RVA: 0x13DF40 Offset: 0x13E041 VA: 0x13DF40
	[FormerlySerializedAsAttribute] // RVA: 0x13DF40 Offset: 0x13E041 VA: 0x13DF40
	internal string m_BucketDataString; // 0xA8
	[SerializeField] // RVA: 0x13DF90 Offset: 0x13E091 VA: 0x13DF90
	[FormerlySerializedAsAttribute] // RVA: 0x13DF90 Offset: 0x13E091 VA: 0x13DF90
	internal string m_EntryDataString; // 0xB0
	private const int kBytesPerInt32 = 4;
	private const int k_EntryDataItemPerEntry = 7;
	[SerializeField] // RVA: 0x13DFE0 Offset: 0x13E0E1 VA: 0x13DFE0
	[FormerlySerializedAsAttribute] // RVA: 0x13DFE0 Offset: 0x13E0E1 VA: 0x13DFE0
	internal string m_ExtraDataString; // 0xB8
	[SerializeField] // RVA: 0x13E030 Offset: 0x13E131 VA: 0x13E030
	internal SerializedType[] m_resourceTypes; // 0xC0
	[SerializeField] // RVA: 0x13E040 Offset: 0x13E141 VA: 0x13E040
	private string[] m_InternalIdPrefixes; // 0xC8

	// Properties
	public string ProviderId { get; set; }
	public ObjectInitializationData InstanceProviderData { get; set; }
	public ObjectInitializationData SceneProviderData { get; set; }
	public List<ObjectInitializationData> ResourceProviderData { get; set; }
	public string[] ProviderIds { get; }
	public string[] InternalIds { get; }

	// Methods

	// RVA: 0x15EA1E0 Offset: 0x15EA2E1 VA: 0x15EA1E0
	public string get_ProviderId() { }

	// RVA: 0x15EA1F0 Offset: 0x15EA2F1 VA: 0x15EA1F0
	internal void set_ProviderId(string value) { }

	// RVA: 0x15EA200 Offset: 0x15EA301 VA: 0x15EA200
	public ObjectInitializationData get_InstanceProviderData() { }

	// RVA: 0x15EA220 Offset: 0x15EA321 VA: 0x15EA220
	public void set_InstanceProviderData(ObjectInitializationData value) { }

	// RVA: 0x15EA250 Offset: 0x15EA351 VA: 0x15EA250
	public ObjectInitializationData get_SceneProviderData() { }

	// RVA: 0x15EA270 Offset: 0x15EA371 VA: 0x15EA270
	public void set_SceneProviderData(ObjectInitializationData value) { }

	// RVA: 0x15EA2A0 Offset: 0x15EA3A1 VA: 0x15EA2A0
	public List<ObjectInitializationData> get_ResourceProviderData() { }

	// RVA: 0x15EA2B0 Offset: 0x15EA3B1 VA: 0x15EA2B0
	public void set_ResourceProviderData(List<ObjectInitializationData> value) { }

	// RVA: 0x15EA2C0 Offset: 0x15EA3C1 VA: 0x15EA2C0
	public string[] get_ProviderIds() { }

	// RVA: 0x15EA2D0 Offset: 0x15EA3D1 VA: 0x15EA2D0
	public string[] get_InternalIds() { }

	// RVA: 0x15EA2E0 Offset: 0x15EA3E1 VA: 0x15EA2E0
	internal void CleanData() { }

	// RVA: 0x15E9410 Offset: 0x15E9511 VA: 0x15E9410
	internal ResourceLocationMap CreateCustomLocator(string overrideId, string providerSuffix) { }

	// RVA: 0x15EA3C0 Offset: 0x15EA4C1 VA: 0x15EA3C0
	public ResourceLocationMap CreateLocator(string providerSuffix) { }

	// RVA: 0x15EB590 Offset: 0x15EB691 VA: 0x15EB590
	internal static string ExpandInternalId(string[] internalIdPrefixes, string v) { }

	// RVA: 0x15EB880 Offset: 0x15EB981 VA: 0x15EB880
	public void .ctor() { }
}

