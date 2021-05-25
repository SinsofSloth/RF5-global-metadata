[ClassInterfaceAttribute] // RVA: 0xAE000 Offset: 0xAE101 VA: 0xAE000
[ComDefaultInterfaceAttribute] // RVA: 0xAE000 Offset: 0xAE101 VA: 0xAE000
[ComVisibleAttribute] // RVA: 0xAE000 Offset: 0xAE101 VA: 0xAE000
[Serializable]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 567
{
	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private Assembly.ResolveEventHolder resolve_event_holder; // 0x18
	private object _evidence; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	private bool fromByteArray; // 0x50
	private string assemblyName; // 0x58

	// Properties
	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	public virtual string Location { get; }
	[ComVisibleAttribute] // RVA: 0xBA100 Offset: 0xBA201 VA: 0xBA100
	public virtual bool ReflectionOnly { get; }
	[MonoTODOAttribute] // RVA: 0xBA120 Offset: 0xBA221 VA: 0xBA120
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x1958620 Offset: 0x1958721 VA: 0x1958620
	protected void .ctor() { }

	// RVA: 0x19586B0 Offset: 0x19587B1 VA: 0x19586B0
	private string get_code_base(bool escaped) { }

	// RVA: 0x19586C0 Offset: 0x19587C1 VA: 0x19586C0
	private string get_fullname() { }

	// RVA: 0x19586D0 Offset: 0x19587D1 VA: 0x19586D0
	private string get_location() { }

	// RVA: 0x19586E0 Offset: 0x19587E1 VA: 0x19586E0
	internal static string GetAotId() { }

	// RVA: 0x19586F0 Offset: 0x19587F1 VA: 0x19586F0
	private string GetCodeBase(bool escaped) { }

	// RVA: 0x1958700 Offset: 0x1958801 VA: 0x1958700 Slot: 7
	public virtual string get_CodeBase() { }

	// RVA: 0x1958710 Offset: 0x1958811 VA: 0x1958710 Slot: 8
	public virtual string get_FullName() { }

	// RVA: 0x1958720 Offset: 0x1958821 VA: 0x1958720 Slot: 9
	public virtual string get_Location() { }

	// RVA: 0x1958790 Offset: 0x1958891 VA: 0x1958790 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19587F0 Offset: 0x19588F1 VA: 0x19587F0 Slot: 11
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1958870 Offset: 0x1958971 VA: 0x1958870 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x19588F0 Offset: 0x19589F1 VA: 0x19588F0
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x1958900 Offset: 0x1958A01 VA: 0x1958900 Slot: 13
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x1958CF0 Offset: 0x1958DF1 VA: 0x1958CF0
	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	// RVA: 0x1958E90 Offset: 0x1958F91 VA: 0x1958E90
	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	// RVA: 0x1958EA0 Offset: 0x1958FA1 VA: 0x1958EA0
	internal string GetSimpleName() { }

	// RVA: 0x1958ED0 Offset: 0x1958FD1 VA: 0x1958ED0
	internal byte[] GetPublicKey() { }

	// RVA: 0x1958F00 Offset: 0x1959001 VA: 0x1958F00
	internal Version GetVersion() { }

	// RVA: 0x1958F30 Offset: 0x1959031 VA: 0x1958F30
	private AssemblyNameFlags GetFlags() { }

	// RVA: 0x1958F60 Offset: 0x1959061 VA: 0x1958F60 Slot: 14
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x1958F70 Offset: 0x1959071 VA: 0x1958F70 Slot: 15
	public virtual Type[] GetTypes() { }

	// RVA: 0x1958F90 Offset: 0x1959091 VA: 0x1958F90 Slot: 16
	public virtual Type[] GetExportedTypes() { }

	// RVA: 0x1958FB0 Offset: 0x19590B1 VA: 0x1958FB0 Slot: 17
	public virtual Type GetType(string name) { }

	// RVA: 0x1958FD0 Offset: 0x19590D1 VA: 0x1958FD0
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1958FE0 Offset: 0x19590E1 VA: 0x1958FE0 Slot: 18
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x1959040 Offset: 0x1959141 VA: 0x1959040 Slot: 19
	public virtual AssemblyName GetName() { }

	// RVA: 0x1959060 Offset: 0x1959161 VA: 0x1959060 Slot: 3
	public override string ToString() { }

	// RVA: 0x19590B0 Offset: 0x19591B1 VA: 0x19590B0
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x1959180 Offset: 0x1959281 VA: 0x1959180
	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	// RVA: 0x19596D0 Offset: 0x19597D1 VA: 0x19596D0
	private static Assembly LoadFrom(string assemblyFile, bool refonly) { }

	// RVA: 0x19596C0 Offset: 0x19597C1 VA: 0x19596C0
	public static Assembly LoadFrom(string assemblyFile) { }

	// RVA: 0x19596E0 Offset: 0x19597E1 VA: 0x19596E0
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x1959720 Offset: 0x1959821 VA: 0x1959720
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[ObsoleteAttribute] // RVA: 0xB8250 Offset: 0xB8351 VA: 0xB8250
	// RVA: 0x1959730 Offset: 0x1959831 VA: 0x1959730
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x19597C0 Offset: 0x19598C1 VA: 0x19597C0
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x1959870 Offset: 0x1959971 VA: 0x1959870 Slot: 20
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x1959880 Offset: 0x1959981 VA: 0x1959880 Slot: 21
	public virtual string[] GetManifestResourceNames() { }

	// RVA: 0x1959890 Offset: 0x1959991 VA: 0x1959890
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x19598E0 Offset: 0x19599E1 VA: 0x19598E0
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x19598F0 Offset: 0x19599F1 VA: 0x19598F0
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x1959900 Offset: 0x1959A01 VA: 0x1959900 Slot: 22
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0x1959A80 Offset: 0x1959B81 VA: 0x1959A80 Slot: 23
	public virtual bool get_ReflectionOnly() { }

	// RVA: 0x1959A90 Offset: 0x1959B91 VA: 0x1959A90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1959AA0 Offset: 0x1959BA1 VA: 0x1959AA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1959B70 Offset: 0x1959C71 VA: 0x1959B70
	private static Exception CreateNIE() { }

	// RVA: 0x1959BE0 Offset: 0x1959CE1 VA: 0x1959BE0
	public bool get_IsFullyTrusted() { }

	// RVA: 0x1959BF0 Offset: 0x1959CF1 VA: 0x1959BF0 Slot: 24
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1959C40 Offset: 0x1959D41 VA: 0x1959C40 Slot: 25
	public virtual Module GetModule(string name) { }

	// RVA: 0x1959C90 Offset: 0x1959D91 VA: 0x1959C90 Slot: 26
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x1959CE0 Offset: 0x1959DE1 VA: 0x1959CE0
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x1958C40 Offset: 0x1958D41 VA: 0x1958C40
	public static bool op_Inequality(Assembly left, Assembly right) { }
}

