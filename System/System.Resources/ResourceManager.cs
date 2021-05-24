[ComVisibleAttribute] // RVA: 0xAD330 Offset: 0xAD431 VA: 0xAD330
[Serializable]
public class ResourceManager // TypeDefIndex: 501
{
	// Fields
	protected string BaseNameField; // 0x10
	[ObsoleteAttribute] // RVA: 0xB4670 Offset: 0xB4771 VA: 0xB4670
	protected Hashtable ResourceSets; // 0x18
	private Dictionary<string, ResourceSet> _resourceSets; // 0x20
	private string moduleDir; // 0x28
	protected Assembly MainAssembly; // 0x30
	private Type _locationInfo; // 0x38
	private Type _userResourceSet; // 0x40
	private CultureInfo _neutralResourcesCulture; // 0x48
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; // 0x50
	private bool _ignoreCase; // 0x58
	private bool UseManifest; // 0x59
	[OptionalFieldAttribute] // RVA: 0xB46B0 Offset: 0xB47B1 VA: 0xB46B0
	private bool UseSatelliteAssem; // 0x5A
	[OptionalFieldAttribute] // RVA: 0xB46F0 Offset: 0xB47F1 VA: 0xB46F0
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x5C
	[OptionalFieldAttribute] // RVA: 0xB4700 Offset: 0xB4801 VA: 0xB4700
	private Version _satelliteContractVersion; // 0x60
	[OptionalFieldAttribute] // RVA: 0xB4710 Offset: 0xB4811 VA: 0xB4710
	private bool _lookedForSatelliteContractVersion; // 0x68
	[OptionalFieldAttribute] // RVA: 0xB4720 Offset: 0xB4821 VA: 0xB4720
	private Assembly _callingAssembly; // 0x70
	[OptionalFieldAttribute] // RVA: 0xB4760 Offset: 0xB4861 VA: 0xB4760
	private RuntimeAssembly m_callingAssembly; // 0x78
	private IResourceGroveler resourceGroveler; // 0x80
	public static readonly int MagicNumber; // 0x0
	public static readonly int HeaderVersionNumber; // 0x4
	private static readonly Type _minResourceSet; // 0x8
	internal static readonly string ResReaderTypeName; // 0x10
	internal static readonly string ResSetTypeName; // 0x18
	internal static readonly string MscorlibName; // 0x20
	internal static readonly int DEBUG; // 0x28

	// Properties
	public virtual string BaseName { get; }
	protected UltimateResourceFallbackLocation FallbackLocation { get; }

	// Methods

	// RVA: 0x17F8120 Offset: 0x17F8221 VA: 0x17F8120
	private void Init() { }

	// RVA: 0x17F81C0 Offset: 0x17F82C1 VA: 0x17F81C0
	protected void .ctor() { }

	// RVA: 0x17F83A0 Offset: 0x17F84A1 VA: 0x17F83A0
	public void .ctor(Type resourceSource) { }

	[OnDeserializingAttribute] // RVA: 0xB7F80 Offset: 0xB8081 VA: 0xB7F80
	// RVA: 0x17F87F0 Offset: 0x17F88F1 VA: 0x17F87F0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7F90 Offset: 0xB8091 VA: 0xB7F90
	// RVA: 0x17F8840 Offset: 0x17F8941 VA: 0x17F8840
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB7FA0 Offset: 0xB80A1 VA: 0xB7FA0
	// RVA: 0x17F8A40 Offset: 0x17F8B41 VA: 0x17F8A40
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x17F8660 Offset: 0x17F8761 VA: 0x17F8660
	private void CommonAssemblyInit() { }

	// RVA: 0x17F8AC0 Offset: 0x17F8BC1 VA: 0x17F8AC0 Slot: 4
	public virtual string get_BaseName() { }

	// RVA: 0x17F8AD0 Offset: 0x17F8BD1 VA: 0x17F8AD0
	protected UltimateResourceFallbackLocation get_FallbackLocation() { }

	// RVA: 0x17F8AE0 Offset: 0x17F8BE1 VA: 0x17F8AE0 Slot: 5
	protected virtual string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0x17F8C10 Offset: 0x17F8D11 VA: 0x17F8C10
	internal ResourceSet GetFirstResourceSet(CultureInfo culture) { }

	// RVA: 0x17F9030 Offset: 0x17F9131 VA: 0x17F9030 Slot: 6
	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0x17F9060 Offset: 0x17F9161 VA: 0x17F9060
	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark) { }

	// RVA: 0x17F98D0 Offset: 0x17F99D1 VA: 0x17F98D0
	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs) { }

	// RVA: 0x17F9A80 Offset: 0x17F9B81 VA: 0x17F9A80
	protected static Version GetSatelliteContractVersion(Assembly a) { }

	// RVA: 0x17F76D0 Offset: 0x17F77D1 VA: 0x17F76D0
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x17F8650 Offset: 0x17F8751 VA: 0x17F8650
	private void SetAppXConfiguration() { }

	// RVA: 0x17FA220 Offset: 0x17FA321 VA: 0x17FA220 Slot: 7
	public virtual string GetString(string name) { }

	// RVA: 0x17FA230 Offset: 0x17FA331 VA: 0x17FA230 Slot: 8
	public virtual string GetString(string name, CultureInfo culture) { }

	// RVA: 0x17FA730 Offset: 0x17FA831 VA: 0x17FA730
	private static void .cctor() { }
}

