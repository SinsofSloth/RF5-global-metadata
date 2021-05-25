[Serializable]
public class ResourceManagerRuntimeData // TypeDefIndex: 5741
{
	// Fields
	public const string kCatalogAddress = "AddressablesMainContentCatalog";
	[SerializeField] // RVA: 0x13E350 Offset: 0x13E451 VA: 0x13E350
	private string m_buildTarget; // 0x10
	[SerializeField] // RVA: 0x13E360 Offset: 0x13E461 VA: 0x13E360
	[FormerlySerializedAsAttribute] // RVA: 0x13E360 Offset: 0x13E461 VA: 0x13E360
	private string m_SettingsHash; // 0x18
	[SerializeField] // RVA: 0x13E3B0 Offset: 0x13E4B1 VA: 0x13E3B0
	[FormerlySerializedAsAttribute] // RVA: 0x13E3B0 Offset: 0x13E4B1 VA: 0x13E3B0
	private List<ResourceLocationData> m_CatalogLocations; // 0x20
	[SerializeField] // RVA: 0x13E400 Offset: 0x13E501 VA: 0x13E400
	[FormerlySerializedAsAttribute] // RVA: 0x13E400 Offset: 0x13E501 VA: 0x13E400
	private bool m_ProfileEvents; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x13E450 Offset: 0x13E551 VA: 0x13E450
	[SerializeField] // RVA: 0x13E450 Offset: 0x13E551 VA: 0x13E450
	private bool m_LogResourceManagerExceptions; // 0x29
	[SerializeField] // RVA: 0x13E4A0 Offset: 0x13E5A1 VA: 0x13E4A0
	[FormerlySerializedAsAttribute] // RVA: 0x13E4A0 Offset: 0x13E5A1 VA: 0x13E4A0
	private List<ObjectInitializationData> m_ExtraInitializationData; // 0x30
	[SerializeField] // RVA: 0x13E4F0 Offset: 0x13E5F1 VA: 0x13E4F0
	private bool m_DisableCatalogUpdateOnStart; // 0x38
	[SerializeField] // RVA: 0x13E500 Offset: 0x13E601 VA: 0x13E500
	private bool m_IsLocalCatalogInBundle; // 0x39
	[SerializeField] // RVA: 0x13E510 Offset: 0x13E611 VA: 0x13E510
	private SerializedType m_CertificateHandlerType; // 0x40
	[SerializeField] // RVA: 0x13E520 Offset: 0x13E621 VA: 0x13E520
	private string m_AddressablesVersion; // 0x60
	[SerializeField] // RVA: 0x13E530 Offset: 0x13E631 VA: 0x13E530
	private int m_maxConcurrentWebRequests; // 0x68

	// Properties
	public string BuildTarget { get; set; }
	public string SettingsHash { get; set; }
	public List<ResourceLocationData> CatalogLocations { get; }
	public bool ProfileEvents { get; set; }
	public bool LogResourceManagerExceptions { get; set; }
	public List<ObjectInitializationData> InitializationObjects { get; }
	public bool DisableCatalogUpdateOnStartup { get; set; }
	public bool IsLocalCatalogInBundle { get; set; }
	public Type CertificateHandlerType { get; set; }
	internal string AddressablesVersion { get; set; }
	public int MaxConcurrentWebRequests { get; set; }

	// Methods

	// RVA: 0x15E9900 Offset: 0x15E9A01 VA: 0x15E9900
	public string get_BuildTarget() { }

	// RVA: 0x15E9910 Offset: 0x15E9A11 VA: 0x15E9910
	public void set_BuildTarget(string value) { }

	// RVA: 0x15E9920 Offset: 0x15E9A21 VA: 0x15E9920
	public string get_SettingsHash() { }

	// RVA: 0x15E9930 Offset: 0x15E9A31 VA: 0x15E9930
	public void set_SettingsHash(string value) { }

	// RVA: 0x15E9940 Offset: 0x15E9A41 VA: 0x15E9940
	public List<ResourceLocationData> get_CatalogLocations() { }

	// RVA: 0x15E9950 Offset: 0x15E9A51 VA: 0x15E9950
	public bool get_ProfileEvents() { }

	// RVA: 0x15E9960 Offset: 0x15E9A61 VA: 0x15E9960
	public void set_ProfileEvents(bool value) { }

	// RVA: 0x15E9970 Offset: 0x15E9A71 VA: 0x15E9970
	public bool get_LogResourceManagerExceptions() { }

	// RVA: 0x15E9980 Offset: 0x15E9A81 VA: 0x15E9980
	public void set_LogResourceManagerExceptions(bool value) { }

	// RVA: 0x15E9990 Offset: 0x15E9A91 VA: 0x15E9990
	public List<ObjectInitializationData> get_InitializationObjects() { }

	// RVA: 0x15E99A0 Offset: 0x15E9AA1 VA: 0x15E99A0
	public bool get_DisableCatalogUpdateOnStartup() { }

	// RVA: 0x15E99B0 Offset: 0x15E9AB1 VA: 0x15E99B0
	public void set_DisableCatalogUpdateOnStartup(bool value) { }

	// RVA: 0x15E99C0 Offset: 0x15E9AC1 VA: 0x15E99C0
	public bool get_IsLocalCatalogInBundle() { }

	// RVA: 0x15E99D0 Offset: 0x15E9AD1 VA: 0x15E99D0
	public void set_IsLocalCatalogInBundle(bool value) { }

	// RVA: 0x15E7290 Offset: 0x15E7391 VA: 0x15E7290
	public Type get_CertificateHandlerType() { }

	// RVA: 0x15E99E0 Offset: 0x15E9AE1 VA: 0x15E99E0
	public void set_CertificateHandlerType(Type value) { }

	// RVA: 0x15E99F0 Offset: 0x15E9AF1 VA: 0x15E99F0
	internal string get_AddressablesVersion() { }

	// RVA: 0x15E9A00 Offset: 0x15E9B01 VA: 0x15E9A00
	internal void set_AddressablesVersion(string value) { }

	// RVA: 0x15E9A10 Offset: 0x15E9B11 VA: 0x15E9A10
	public int get_MaxConcurrentWebRequests() { }

	// RVA: 0x15E9A20 Offset: 0x15E9B21 VA: 0x15E9A20
	public void set_MaxConcurrentWebRequests(int value) { }

	// RVA: 0x15E9AB0 Offset: 0x15E9BB1 VA: 0x15E9AB0
	public void .ctor() { }
}

