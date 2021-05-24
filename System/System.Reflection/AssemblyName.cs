[ClassInterfaceAttribute] // RVA: 0xAE090 Offset: 0xAE191 VA: 0xAE090
[ComVisibleAttribute] // RVA: 0xAE090 Offset: 0xAE191 VA: 0xAE090
[ComDefaultInterfaceAttribute] // RVA: 0xAE090 Offset: 0xAE191 VA: 0xAE090
[Serializable]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 570
{
	// Fields
	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

	// Properties
	public string Name { get; set; }
	public CultureInfo CultureInfo { get; set; }
	public AssemblyNameFlags Flags { get; set; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }

	// Methods

	// RVA: 0x19595A0 Offset: 0x19596A1 VA: 0x19595A0
	public void .ctor() { }

	// RVA: 0x195A070 Offset: 0x195A171 VA: 0x195A070
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x195A080 Offset: 0x195A181 VA: 0x195A080
	public void .ctor(string assemblyName) { }

	// RVA: 0x195A710 Offset: 0x195A811 VA: 0x195A710
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x195AB30 Offset: 0x195AC31 VA: 0x195AB30
	public string get_Name() { }

	// RVA: 0x195AB40 Offset: 0x195AC41 VA: 0x195AB40
	public void set_Name(string value) { }

	// RVA: 0x195AB50 Offset: 0x195AC51 VA: 0x195AB50
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x195AB60 Offset: 0x195AC61 VA: 0x195AB60
	public void set_CultureInfo(CultureInfo value) { }

	// RVA: 0x195AB70 Offset: 0x195AC71 VA: 0x195AB70
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0x195AB80 Offset: 0x195AC81 VA: 0x195AB80
	public void set_Flags(AssemblyNameFlags value) { }

	// RVA: 0x195AB90 Offset: 0x195AC91 VA: 0x195AB90
	public string get_FullName() { }

	// RVA: 0x195B100 Offset: 0x195B201 VA: 0x195B100
	public Version get_Version() { }

	// RVA: 0x19595F0 Offset: 0x19596F1 VA: 0x19595F0
	public void set_Version(Version value) { }

	// RVA: 0x195B110 Offset: 0x195B211 VA: 0x195B110 Slot: 3
	public override string ToString() { }

	// RVA: 0x195B150 Offset: 0x195B251 VA: 0x195B150
	public byte[] GetPublicKey() { }

	// RVA: 0x195B160 Offset: 0x195B261 VA: 0x195B160
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x195B3C0 Offset: 0x195B4C1 VA: 0x195B3C0
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x195AEC0 Offset: 0x195AFC1 VA: 0x195AEC0
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0x195B570 Offset: 0x195B671 VA: 0x195B570
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x195B4D0 Offset: 0x195B5D1 VA: 0x195B4D0
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x19595D0 Offset: 0x19596D1 VA: 0x19595D0
	public void SetPublicKey(byte[] publicKey) { }

	// RVA: 0x195B580 Offset: 0x195B681 VA: 0x195B580 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x195B7F0 Offset: 0x195B8F1 VA: 0x195B7F0 Slot: 4
	public object Clone() { }

	// RVA: 0x195B910 Offset: 0x195BA11 VA: 0x195B910 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x195B920 Offset: 0x195BA21 VA: 0x195B920
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x195A2C0 Offset: 0x195A3C1 VA: 0x195A2C0
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x195B930 Offset: 0x195BA31 VA: 0x195B930
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }
}

