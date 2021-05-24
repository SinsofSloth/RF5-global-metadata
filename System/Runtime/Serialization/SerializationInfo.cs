[ComVisibleAttribute] // RVA: 0xB07F0 Offset: 0xB08F1 VA: 0xB07F0
public sealed class SerializationInfo // TypeDefIndex: 1031
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xB9350 Offset: 0xB9451 VA: 0xB9350
	// RVA: 0x1509E50 Offset: 0x1509F51 VA: 0x1509E50
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0xB9370 Offset: 0xB9471 VA: 0xB9370
	// RVA: 0x150C740 Offset: 0x150C841 VA: 0x150C740
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x151F000 Offset: 0x151F101 VA: 0x151F000
	public string get_FullTypeName() { }

	// RVA: 0x151F010 Offset: 0x151F111 VA: 0x151F010
	public string get_AssemblyName() { }

	// RVA: 0x151D680 Offset: 0x151D781 VA: 0x151D680
	public void SetType(Type type) { }

	// RVA: 0x151F030 Offset: 0x151F131 VA: 0x151F030
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x151F020 Offset: 0x151F121 VA: 0x151F020
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x150D530 Offset: 0x150D631 VA: 0x150D530
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x151F0E0 Offset: 0x151F1E1 VA: 0x151F0E0
	public int get_MemberCount() { }

	// RVA: 0x151F0F0 Offset: 0x151F1F1 VA: 0x151F0F0
	public Type get_ObjectType() { }

	// RVA: 0x151F100 Offset: 0x151F201 VA: 0x151F100
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x151F110 Offset: 0x151F211 VA: 0x151F110
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x150D1C0 Offset: 0x150D2C1 VA: 0x150D1C0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x151F1B0 Offset: 0x151F2B1 VA: 0x151F1B0
	private void ExpandArrays() { }

	// RVA: 0x151D5B0 Offset: 0x151D6B1 VA: 0x151D5B0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x1509C80 Offset: 0x1509D81 VA: 0x1509C80
	public void AddValue(string name, object value) { }

	// RVA: 0x151F4D0 Offset: 0x151F5D1 VA: 0x151F4D0
	public void AddValue(string name, bool value) { }

	// RVA: 0x151F590 Offset: 0x151F691 VA: 0x151F590
	public void AddValue(string name, char value) { }

	// RVA: 0x151F650 Offset: 0x151F751 VA: 0x151F650
	public void AddValue(string name, byte value) { }

	// RVA: 0x151F710 Offset: 0x151F811 VA: 0x151F710
	public void AddValue(string name, short value) { }

	// RVA: 0x151F7D0 Offset: 0x151F8D1 VA: 0x151F7D0
	public void AddValue(string name, int value) { }

	// RVA: 0x151F890 Offset: 0x151F991 VA: 0x151F890
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0xB9390 Offset: 0xB9491 VA: 0xB9390
	// RVA: 0x151F950 Offset: 0x151FA51 VA: 0x151F950
	public void AddValue(string name, ulong value) { }

	// RVA: 0x151FA10 Offset: 0x151FB11 VA: 0x151FA10
	public void AddValue(string name, float value) { }

	// RVA: 0x151FAD0 Offset: 0x151FBD1 VA: 0x151FAD0
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x151F2E0 Offset: 0x151F3E1 VA: 0x151F2E0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x151A640 Offset: 0x151A741 VA: 0x151A640
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x151FB90 Offset: 0x151FC91 VA: 0x151FB90
	private int FindElement(string name) { }

	// RVA: 0x151FC50 Offset: 0x151FD51 VA: 0x151FC50
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0xB93B0 Offset: 0xB94B1 VA: 0xB93B0
	// RVA: 0x151FDA0 Offset: 0x151FEA1 VA: 0x151FDA0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x151D220 Offset: 0x151D321 VA: 0x151D220
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0xB93D0 Offset: 0xB94D1 VA: 0xB93D0
	// RVA: 0x151D0F0 Offset: 0x151D1F1 VA: 0x151D0F0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x151FE60 Offset: 0x151FF61 VA: 0x151FE60
	public bool GetBoolean(string name) { }

	// RVA: 0x151FFD0 Offset: 0x15200D1 VA: 0x151FFD0
	public int GetInt32(string name) { }

	// RVA: 0x1520140 Offset: 0x1520241 VA: 0x1520140
	public long GetInt64(string name) { }

	// RVA: 0x15202B0 Offset: 0x15203B1 VA: 0x15202B0
	public float GetSingle(string name) { }

	// RVA: 0x1520420 Offset: 0x1520521 VA: 0x1520420
	public string GetString(string name) { }
}

[ComVisibleAttribute] // RVA: 0xB07F0 Offset: 0xB08F1 VA: 0xB07F0
public sealed class SerializationInfo // TypeDefIndex: 1031
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xB9350 Offset: 0xB9451 VA: 0xB9350
	// RVA: 0x1509E50 Offset: 0x1509F51 VA: 0x1509E50
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0xB9370 Offset: 0xB9471 VA: 0xB9370
	// RVA: 0x150C740 Offset: 0x150C841 VA: 0x150C740
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x151F000 Offset: 0x151F101 VA: 0x151F000
	public string get_FullTypeName() { }

	// RVA: 0x151F010 Offset: 0x151F111 VA: 0x151F010
	public string get_AssemblyName() { }

	// RVA: 0x151D680 Offset: 0x151D781 VA: 0x151D680
	public void SetType(Type type) { }

	// RVA: 0x151F030 Offset: 0x151F131 VA: 0x151F030
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x151F020 Offset: 0x151F121 VA: 0x151F020
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x150D530 Offset: 0x150D631 VA: 0x150D530
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x151F0E0 Offset: 0x151F1E1 VA: 0x151F0E0
	public int get_MemberCount() { }

	// RVA: 0x151F0F0 Offset: 0x151F1F1 VA: 0x151F0F0
	public Type get_ObjectType() { }

	// RVA: 0x151F100 Offset: 0x151F201 VA: 0x151F100
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x151F110 Offset: 0x151F211 VA: 0x151F110
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x150D1C0 Offset: 0x150D2C1 VA: 0x150D1C0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x151F1B0 Offset: 0x151F2B1 VA: 0x151F1B0
	private void ExpandArrays() { }

	// RVA: 0x151D5B0 Offset: 0x151D6B1 VA: 0x151D5B0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x1509C80 Offset: 0x1509D81 VA: 0x1509C80
	public void AddValue(string name, object value) { }

	// RVA: 0x151F4D0 Offset: 0x151F5D1 VA: 0x151F4D0
	public void AddValue(string name, bool value) { }

	// RVA: 0x151F590 Offset: 0x151F691 VA: 0x151F590
	public void AddValue(string name, char value) { }

	// RVA: 0x151F650 Offset: 0x151F751 VA: 0x151F650
	public void AddValue(string name, byte value) { }

	// RVA: 0x151F710 Offset: 0x151F811 VA: 0x151F710
	public void AddValue(string name, short value) { }

	// RVA: 0x151F7D0 Offset: 0x151F8D1 VA: 0x151F7D0
	public void AddValue(string name, int value) { }

	// RVA: 0x151F890 Offset: 0x151F991 VA: 0x151F890
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0xB9390 Offset: 0xB9491 VA: 0xB9390
	// RVA: 0x151F950 Offset: 0x151FA51 VA: 0x151F950
	public void AddValue(string name, ulong value) { }

	// RVA: 0x151FA10 Offset: 0x151FB11 VA: 0x151FA10
	public void AddValue(string name, float value) { }

	// RVA: 0x151FAD0 Offset: 0x151FBD1 VA: 0x151FAD0
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x151F2E0 Offset: 0x151F3E1 VA: 0x151F2E0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x151A640 Offset: 0x151A741 VA: 0x151A640
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x151FB90 Offset: 0x151FC91 VA: 0x151FB90
	private int FindElement(string name) { }

	// RVA: 0x151FC50 Offset: 0x151FD51 VA: 0x151FC50
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0xB93B0 Offset: 0xB94B1 VA: 0xB93B0
	// RVA: 0x151FDA0 Offset: 0x151FEA1 VA: 0x151FDA0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x151D220 Offset: 0x151D321 VA: 0x151D220
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0xB93D0 Offset: 0xB94D1 VA: 0xB93D0
	// RVA: 0x151D0F0 Offset: 0x151D1F1 VA: 0x151D0F0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x151FE60 Offset: 0x151FF61 VA: 0x151FE60
	public bool GetBoolean(string name) { }

	// RVA: 0x151FFD0 Offset: 0x15200D1 VA: 0x151FFD0
	public int GetInt32(string name) { }

	// RVA: 0x1520140 Offset: 0x1520241 VA: 0x1520140
	public long GetInt64(string name) { }

	// RVA: 0x15202B0 Offset: 0x15203B1 VA: 0x15202B0
	public float GetSingle(string name) { }

	// RVA: 0x1520420 Offset: 0x1520521 VA: 0x1520420
	public string GetString(string name) { }
}

[ComVisibleAttribute] // RVA: 0xB07F0 Offset: 0xB08F1 VA: 0xB07F0
public sealed class SerializationInfo // TypeDefIndex: 1031
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xB9350 Offset: 0xB9451 VA: 0xB9350
	// RVA: 0x1509E50 Offset: 0x1509F51 VA: 0x1509E50
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0xB9370 Offset: 0xB9471 VA: 0xB9370
	// RVA: 0x150C740 Offset: 0x150C841 VA: 0x150C740
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x151F000 Offset: 0x151F101 VA: 0x151F000
	public string get_FullTypeName() { }

	// RVA: 0x151F010 Offset: 0x151F111 VA: 0x151F010
	public string get_AssemblyName() { }

	// RVA: 0x151D680 Offset: 0x151D781 VA: 0x151D680
	public void SetType(Type type) { }

	// RVA: 0x151F030 Offset: 0x151F131 VA: 0x151F030
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x151F020 Offset: 0x151F121 VA: 0x151F020
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x150D530 Offset: 0x150D631 VA: 0x150D530
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x151F0E0 Offset: 0x151F1E1 VA: 0x151F0E0
	public int get_MemberCount() { }

	// RVA: 0x151F0F0 Offset: 0x151F1F1 VA: 0x151F0F0
	public Type get_ObjectType() { }

	// RVA: 0x151F100 Offset: 0x151F201 VA: 0x151F100
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x151F110 Offset: 0x151F211 VA: 0x151F110
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x150D1C0 Offset: 0x150D2C1 VA: 0x150D1C0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x151F1B0 Offset: 0x151F2B1 VA: 0x151F1B0
	private void ExpandArrays() { }

	// RVA: 0x151D5B0 Offset: 0x151D6B1 VA: 0x151D5B0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x1509C80 Offset: 0x1509D81 VA: 0x1509C80
	public void AddValue(string name, object value) { }

	// RVA: 0x151F4D0 Offset: 0x151F5D1 VA: 0x151F4D0
	public void AddValue(string name, bool value) { }

	// RVA: 0x151F590 Offset: 0x151F691 VA: 0x151F590
	public void AddValue(string name, char value) { }

	// RVA: 0x151F650 Offset: 0x151F751 VA: 0x151F650
	public void AddValue(string name, byte value) { }

	// RVA: 0x151F710 Offset: 0x151F811 VA: 0x151F710
	public void AddValue(string name, short value) { }

	// RVA: 0x151F7D0 Offset: 0x151F8D1 VA: 0x151F7D0
	public void AddValue(string name, int value) { }

	// RVA: 0x151F890 Offset: 0x151F991 VA: 0x151F890
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0xB9390 Offset: 0xB9491 VA: 0xB9390
	// RVA: 0x151F950 Offset: 0x151FA51 VA: 0x151F950
	public void AddValue(string name, ulong value) { }

	// RVA: 0x151FA10 Offset: 0x151FB11 VA: 0x151FA10
	public void AddValue(string name, float value) { }

	// RVA: 0x151FAD0 Offset: 0x151FBD1 VA: 0x151FAD0
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x151F2E0 Offset: 0x151F3E1 VA: 0x151F2E0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x151A640 Offset: 0x151A741 VA: 0x151A640
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x151FB90 Offset: 0x151FC91 VA: 0x151FB90
	private int FindElement(string name) { }

	// RVA: 0x151FC50 Offset: 0x151FD51 VA: 0x151FC50
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0xB93B0 Offset: 0xB94B1 VA: 0xB93B0
	// RVA: 0x151FDA0 Offset: 0x151FEA1 VA: 0x151FDA0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x151D220 Offset: 0x151D321 VA: 0x151D220
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0xB93D0 Offset: 0xB94D1 VA: 0xB93D0
	// RVA: 0x151D0F0 Offset: 0x151D1F1 VA: 0x151D0F0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x151FE60 Offset: 0x151FF61 VA: 0x151FE60
	public bool GetBoolean(string name) { }

	// RVA: 0x151FFD0 Offset: 0x15200D1 VA: 0x151FFD0
	public int GetInt32(string name) { }

	// RVA: 0x1520140 Offset: 0x1520241 VA: 0x1520140
	public long GetInt64(string name) { }

	// RVA: 0x15202B0 Offset: 0x15203B1 VA: 0x15202B0
	public float GetSingle(string name) { }

	// RVA: 0x1520420 Offset: 0x1520521 VA: 0x1520420
	public string GetString(string name) { }
}

[ComVisibleAttribute] // RVA: 0xB07F0 Offset: 0xB08F1 VA: 0xB07F0
public sealed class SerializationInfo // TypeDefIndex: 1031
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xB9350 Offset: 0xB9451 VA: 0xB9350
	// RVA: 0x1509E50 Offset: 0x1509F51 VA: 0x1509E50
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0xB9370 Offset: 0xB9471 VA: 0xB9370
	// RVA: 0x150C740 Offset: 0x150C841 VA: 0x150C740
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x151F000 Offset: 0x151F101 VA: 0x151F000
	public string get_FullTypeName() { }

	// RVA: 0x151F010 Offset: 0x151F111 VA: 0x151F010
	public string get_AssemblyName() { }

	// RVA: 0x151D680 Offset: 0x151D781 VA: 0x151D680
	public void SetType(Type type) { }

	// RVA: 0x151F030 Offset: 0x151F131 VA: 0x151F030
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x151F020 Offset: 0x151F121 VA: 0x151F020
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x150D530 Offset: 0x150D631 VA: 0x150D530
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x151F0E0 Offset: 0x151F1E1 VA: 0x151F0E0
	public int get_MemberCount() { }

	// RVA: 0x151F0F0 Offset: 0x151F1F1 VA: 0x151F0F0
	public Type get_ObjectType() { }

	// RVA: 0x151F100 Offset: 0x151F201 VA: 0x151F100
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x151F110 Offset: 0x151F211 VA: 0x151F110
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x150D1C0 Offset: 0x150D2C1 VA: 0x150D1C0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x151F1B0 Offset: 0x151F2B1 VA: 0x151F1B0
	private void ExpandArrays() { }

	// RVA: 0x151D5B0 Offset: 0x151D6B1 VA: 0x151D5B0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x1509C80 Offset: 0x1509D81 VA: 0x1509C80
	public void AddValue(string name, object value) { }

	// RVA: 0x151F4D0 Offset: 0x151F5D1 VA: 0x151F4D0
	public void AddValue(string name, bool value) { }

	// RVA: 0x151F590 Offset: 0x151F691 VA: 0x151F590
	public void AddValue(string name, char value) { }

	// RVA: 0x151F650 Offset: 0x151F751 VA: 0x151F650
	public void AddValue(string name, byte value) { }

	// RVA: 0x151F710 Offset: 0x151F811 VA: 0x151F710
	public void AddValue(string name, short value) { }

	// RVA: 0x151F7D0 Offset: 0x151F8D1 VA: 0x151F7D0
	public void AddValue(string name, int value) { }

	// RVA: 0x151F890 Offset: 0x151F991 VA: 0x151F890
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0xB9390 Offset: 0xB9491 VA: 0xB9390
	// RVA: 0x151F950 Offset: 0x151FA51 VA: 0x151F950
	public void AddValue(string name, ulong value) { }

	// RVA: 0x151FA10 Offset: 0x151FB11 VA: 0x151FA10
	public void AddValue(string name, float value) { }

	// RVA: 0x151FAD0 Offset: 0x151FBD1 VA: 0x151FAD0
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x151F2E0 Offset: 0x151F3E1 VA: 0x151F2E0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x151A640 Offset: 0x151A741 VA: 0x151A640
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x151FB90 Offset: 0x151FC91 VA: 0x151FB90
	private int FindElement(string name) { }

	// RVA: 0x151FC50 Offset: 0x151FD51 VA: 0x151FC50
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0xB93B0 Offset: 0xB94B1 VA: 0xB93B0
	// RVA: 0x151FDA0 Offset: 0x151FEA1 VA: 0x151FDA0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x151D220 Offset: 0x151D321 VA: 0x151D220
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0xB93D0 Offset: 0xB94D1 VA: 0xB93D0
	// RVA: 0x151D0F0 Offset: 0x151D1F1 VA: 0x151D0F0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x151FE60 Offset: 0x151FF61 VA: 0x151FE60
	public bool GetBoolean(string name) { }

	// RVA: 0x151FFD0 Offset: 0x15200D1 VA: 0x151FFD0
	public int GetInt32(string name) { }

	// RVA: 0x1520140 Offset: 0x1520241 VA: 0x1520140
	public long GetInt64(string name) { }

	// RVA: 0x15202B0 Offset: 0x15203B1 VA: 0x15202B0
	public float GetSingle(string name) { }

	// RVA: 0x1520420 Offset: 0x1520521 VA: 0x1520420
	public string GetString(string name) { }
}

[ComVisibleAttribute] // RVA: 0xB07F0 Offset: 0xB08F1 VA: 0xB07F0
public sealed class SerializationInfo // TypeDefIndex: 1031
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xB9350 Offset: 0xB9451 VA: 0xB9350
	// RVA: 0x1509E50 Offset: 0x1509F51 VA: 0x1509E50
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0xB9370 Offset: 0xB9471 VA: 0xB9370
	// RVA: 0x150C740 Offset: 0x150C841 VA: 0x150C740
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x151F000 Offset: 0x151F101 VA: 0x151F000
	public string get_FullTypeName() { }

	// RVA: 0x151F010 Offset: 0x151F111 VA: 0x151F010
	public string get_AssemblyName() { }

	// RVA: 0x151D680 Offset: 0x151D781 VA: 0x151D680
	public void SetType(Type type) { }

	// RVA: 0x151F030 Offset: 0x151F131 VA: 0x151F030
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x151F020 Offset: 0x151F121 VA: 0x151F020
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x150D530 Offset: 0x150D631 VA: 0x150D530
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x151F0E0 Offset: 0x151F1E1 VA: 0x151F0E0
	public int get_MemberCount() { }

	// RVA: 0x151F0F0 Offset: 0x151F1F1 VA: 0x151F0F0
	public Type get_ObjectType() { }

	// RVA: 0x151F100 Offset: 0x151F201 VA: 0x151F100
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x151F110 Offset: 0x151F211 VA: 0x151F110
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x150D1C0 Offset: 0x150D2C1 VA: 0x150D1C0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x151F1B0 Offset: 0x151F2B1 VA: 0x151F1B0
	private void ExpandArrays() { }

	// RVA: 0x151D5B0 Offset: 0x151D6B1 VA: 0x151D5B0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x1509C80 Offset: 0x1509D81 VA: 0x1509C80
	public void AddValue(string name, object value) { }

	// RVA: 0x151F4D0 Offset: 0x151F5D1 VA: 0x151F4D0
	public void AddValue(string name, bool value) { }

	// RVA: 0x151F590 Offset: 0x151F691 VA: 0x151F590
	public void AddValue(string name, char value) { }

	// RVA: 0x151F650 Offset: 0x151F751 VA: 0x151F650
	public void AddValue(string name, byte value) { }

	// RVA: 0x151F710 Offset: 0x151F811 VA: 0x151F710
	public void AddValue(string name, short value) { }

	// RVA: 0x151F7D0 Offset: 0x151F8D1 VA: 0x151F7D0
	public void AddValue(string name, int value) { }

	// RVA: 0x151F890 Offset: 0x151F991 VA: 0x151F890
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0xB9390 Offset: 0xB9491 VA: 0xB9390
	// RVA: 0x151F950 Offset: 0x151FA51 VA: 0x151F950
	public void AddValue(string name, ulong value) { }

	// RVA: 0x151FA10 Offset: 0x151FB11 VA: 0x151FA10
	public void AddValue(string name, float value) { }

	// RVA: 0x151FAD0 Offset: 0x151FBD1 VA: 0x151FAD0
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x151F2E0 Offset: 0x151F3E1 VA: 0x151F2E0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x151A640 Offset: 0x151A741 VA: 0x151A640
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x151FB90 Offset: 0x151FC91 VA: 0x151FB90
	private int FindElement(string name) { }

	// RVA: 0x151FC50 Offset: 0x151FD51 VA: 0x151FC50
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0xB93B0 Offset: 0xB94B1 VA: 0xB93B0
	// RVA: 0x151FDA0 Offset: 0x151FEA1 VA: 0x151FDA0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x151D220 Offset: 0x151D321 VA: 0x151D220
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0xB93D0 Offset: 0xB94D1 VA: 0xB93D0
	// RVA: 0x151D0F0 Offset: 0x151D1F1 VA: 0x151D0F0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x151FE60 Offset: 0x151FF61 VA: 0x151FE60
	public bool GetBoolean(string name) { }

	// RVA: 0x151FFD0 Offset: 0x15200D1 VA: 0x151FFD0
	public int GetInt32(string name) { }

	// RVA: 0x1520140 Offset: 0x1520241 VA: 0x1520140
	public long GetInt64(string name) { }

	// RVA: 0x15202B0 Offset: 0x15203B1 VA: 0x15202B0
	public float GetSingle(string name) { }

	// RVA: 0x1520420 Offset: 0x1520521 VA: 0x1520420
	public string GetString(string name) { }
}

[ComVisibleAttribute] // RVA: 0xB07F0 Offset: 0xB08F1 VA: 0xB07F0
public sealed class SerializationInfo // TypeDefIndex: 1031
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xB9350 Offset: 0xB9451 VA: 0xB9350
	// RVA: 0x1509E50 Offset: 0x1509F51 VA: 0x1509E50
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0xB9370 Offset: 0xB9471 VA: 0xB9370
	// RVA: 0x150C740 Offset: 0x150C841 VA: 0x150C740
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x151F000 Offset: 0x151F101 VA: 0x151F000
	public string get_FullTypeName() { }

	// RVA: 0x151F010 Offset: 0x151F111 VA: 0x151F010
	public string get_AssemblyName() { }

	// RVA: 0x151D680 Offset: 0x151D781 VA: 0x151D680
	public void SetType(Type type) { }

	// RVA: 0x151F030 Offset: 0x151F131 VA: 0x151F030
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x151F020 Offset: 0x151F121 VA: 0x151F020
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x150D530 Offset: 0x150D631 VA: 0x150D530
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x151F0E0 Offset: 0x151F1E1 VA: 0x151F0E0
	public int get_MemberCount() { }

	// RVA: 0x151F0F0 Offset: 0x151F1F1 VA: 0x151F0F0
	public Type get_ObjectType() { }

	// RVA: 0x151F100 Offset: 0x151F201 VA: 0x151F100
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x151F110 Offset: 0x151F211 VA: 0x151F110
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x150D1C0 Offset: 0x150D2C1 VA: 0x150D1C0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x151F1B0 Offset: 0x151F2B1 VA: 0x151F1B0
	private void ExpandArrays() { }

	// RVA: 0x151D5B0 Offset: 0x151D6B1 VA: 0x151D5B0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x1509C80 Offset: 0x1509D81 VA: 0x1509C80
	public void AddValue(string name, object value) { }

	// RVA: 0x151F4D0 Offset: 0x151F5D1 VA: 0x151F4D0
	public void AddValue(string name, bool value) { }

	// RVA: 0x151F590 Offset: 0x151F691 VA: 0x151F590
	public void AddValue(string name, char value) { }

	// RVA: 0x151F650 Offset: 0x151F751 VA: 0x151F650
	public void AddValue(string name, byte value) { }

	// RVA: 0x151F710 Offset: 0x151F811 VA: 0x151F710
	public void AddValue(string name, short value) { }

	// RVA: 0x151F7D0 Offset: 0x151F8D1 VA: 0x151F7D0
	public void AddValue(string name, int value) { }

	// RVA: 0x151F890 Offset: 0x151F991 VA: 0x151F890
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0xB9390 Offset: 0xB9491 VA: 0xB9390
	// RVA: 0x151F950 Offset: 0x151FA51 VA: 0x151F950
	public void AddValue(string name, ulong value) { }

	// RVA: 0x151FA10 Offset: 0x151FB11 VA: 0x151FA10
	public void AddValue(string name, float value) { }

	// RVA: 0x151FAD0 Offset: 0x151FBD1 VA: 0x151FAD0
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x151F2E0 Offset: 0x151F3E1 VA: 0x151F2E0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x151A640 Offset: 0x151A741 VA: 0x151A640
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x151FB90 Offset: 0x151FC91 VA: 0x151FB90
	private int FindElement(string name) { }

	// RVA: 0x151FC50 Offset: 0x151FD51 VA: 0x151FC50
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0xB93B0 Offset: 0xB94B1 VA: 0xB93B0
	// RVA: 0x151FDA0 Offset: 0x151FEA1 VA: 0x151FDA0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x151D220 Offset: 0x151D321 VA: 0x151D220
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0xB93D0 Offset: 0xB94D1 VA: 0xB93D0
	// RVA: 0x151D0F0 Offset: 0x151D1F1 VA: 0x151D0F0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x151FE60 Offset: 0x151FF61 VA: 0x151FE60
	public bool GetBoolean(string name) { }

	// RVA: 0x151FFD0 Offset: 0x15200D1 VA: 0x151FFD0
	public int GetInt32(string name) { }

	// RVA: 0x1520140 Offset: 0x1520241 VA: 0x1520140
	public long GetInt64(string name) { }

	// RVA: 0x15202B0 Offset: 0x15203B1 VA: 0x15202B0
	public float GetSingle(string name) { }

	// RVA: 0x1520420 Offset: 0x1520521 VA: 0x1520420
	public string GetString(string name) { }
}

