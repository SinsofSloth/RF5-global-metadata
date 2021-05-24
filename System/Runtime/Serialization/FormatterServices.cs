[ComVisibleAttribute] // RVA: 0xB04D0 Offset: 0xB05D1 VA: 0xB04D0
public static class FormatterServices // TypeDefIndex: 999
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x15FE320 Offset: 0x15FE421 VA: 0x15FE320
	private static void .cctor() { }

	// RVA: 0x15FE490 Offset: 0x15FE591 VA: 0x15FE490
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FE690 Offset: 0x15FE791 VA: 0x15FE690
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x15FE6B0 Offset: 0x15FE7B1 VA: 0x15FE6B0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FEDD0 Offset: 0x15FEED1 VA: 0x15FEDD0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x15FF160 Offset: 0x15FF261 VA: 0x15FF160
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x15FF3D0 Offset: 0x15FF4D1 VA: 0x15FF3D0
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x15FF590 Offset: 0x15FF691 VA: 0x15FF590
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x15FF5A0 Offset: 0x15FF6A1 VA: 0x15FF5A0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x15FF5B0 Offset: 0x15FF6B1 VA: 0x15FF5B0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x15FF690 Offset: 0x15FF791 VA: 0x15FF690
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x15FF870 Offset: 0x15FF971 VA: 0x15FF870
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x15FFB60 Offset: 0x15FFC61 VA: 0x15FFB60
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x15FFF90 Offset: 0x1600091 VA: 0x15FFF90
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x1600050 Offset: 0x1600151 VA: 0x1600050
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x1600060 Offset: 0x1600161 VA: 0x1600060
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x1600160 Offset: 0x1600261 VA: 0x1600160
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x16002D0 Offset: 0x16003D1 VA: 0x16002D0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1600390 Offset: 0x1600491 VA: 0x1600390
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x1600580 Offset: 0x1600681 VA: 0x1600580
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

[ComVisibleAttribute] // RVA: 0xB04D0 Offset: 0xB05D1 VA: 0xB04D0
public static class FormatterServices // TypeDefIndex: 999
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x15FE320 Offset: 0x15FE421 VA: 0x15FE320
	private static void .cctor() { }

	// RVA: 0x15FE490 Offset: 0x15FE591 VA: 0x15FE490
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FE690 Offset: 0x15FE791 VA: 0x15FE690
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x15FE6B0 Offset: 0x15FE7B1 VA: 0x15FE6B0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FEDD0 Offset: 0x15FEED1 VA: 0x15FEDD0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x15FF160 Offset: 0x15FF261 VA: 0x15FF160
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x15FF3D0 Offset: 0x15FF4D1 VA: 0x15FF3D0
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x15FF590 Offset: 0x15FF691 VA: 0x15FF590
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x15FF5A0 Offset: 0x15FF6A1 VA: 0x15FF5A0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x15FF5B0 Offset: 0x15FF6B1 VA: 0x15FF5B0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x15FF690 Offset: 0x15FF791 VA: 0x15FF690
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x15FF870 Offset: 0x15FF971 VA: 0x15FF870
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x15FFB60 Offset: 0x15FFC61 VA: 0x15FFB60
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x15FFF90 Offset: 0x1600091 VA: 0x15FFF90
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x1600050 Offset: 0x1600151 VA: 0x1600050
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x1600060 Offset: 0x1600161 VA: 0x1600060
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x1600160 Offset: 0x1600261 VA: 0x1600160
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x16002D0 Offset: 0x16003D1 VA: 0x16002D0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1600390 Offset: 0x1600491 VA: 0x1600390
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x1600580 Offset: 0x1600681 VA: 0x1600580
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

[ComVisibleAttribute] // RVA: 0xB04D0 Offset: 0xB05D1 VA: 0xB04D0
public static class FormatterServices // TypeDefIndex: 999
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x15FE320 Offset: 0x15FE421 VA: 0x15FE320
	private static void .cctor() { }

	// RVA: 0x15FE490 Offset: 0x15FE591 VA: 0x15FE490
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FE690 Offset: 0x15FE791 VA: 0x15FE690
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x15FE6B0 Offset: 0x15FE7B1 VA: 0x15FE6B0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FEDD0 Offset: 0x15FEED1 VA: 0x15FEDD0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x15FF160 Offset: 0x15FF261 VA: 0x15FF160
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x15FF3D0 Offset: 0x15FF4D1 VA: 0x15FF3D0
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x15FF590 Offset: 0x15FF691 VA: 0x15FF590
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x15FF5A0 Offset: 0x15FF6A1 VA: 0x15FF5A0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x15FF5B0 Offset: 0x15FF6B1 VA: 0x15FF5B0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x15FF690 Offset: 0x15FF791 VA: 0x15FF690
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x15FF870 Offset: 0x15FF971 VA: 0x15FF870
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x15FFB60 Offset: 0x15FFC61 VA: 0x15FFB60
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x15FFF90 Offset: 0x1600091 VA: 0x15FFF90
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x1600050 Offset: 0x1600151 VA: 0x1600050
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x1600060 Offset: 0x1600161 VA: 0x1600060
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x1600160 Offset: 0x1600261 VA: 0x1600160
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x16002D0 Offset: 0x16003D1 VA: 0x16002D0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1600390 Offset: 0x1600491 VA: 0x1600390
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x1600580 Offset: 0x1600681 VA: 0x1600580
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

[ComVisibleAttribute] // RVA: 0xB04D0 Offset: 0xB05D1 VA: 0xB04D0
public static class FormatterServices // TypeDefIndex: 999
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x15FE320 Offset: 0x15FE421 VA: 0x15FE320
	private static void .cctor() { }

	// RVA: 0x15FE490 Offset: 0x15FE591 VA: 0x15FE490
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FE690 Offset: 0x15FE791 VA: 0x15FE690
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x15FE6B0 Offset: 0x15FE7B1 VA: 0x15FE6B0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FEDD0 Offset: 0x15FEED1 VA: 0x15FEDD0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x15FF160 Offset: 0x15FF261 VA: 0x15FF160
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x15FF3D0 Offset: 0x15FF4D1 VA: 0x15FF3D0
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x15FF590 Offset: 0x15FF691 VA: 0x15FF590
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x15FF5A0 Offset: 0x15FF6A1 VA: 0x15FF5A0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x15FF5B0 Offset: 0x15FF6B1 VA: 0x15FF5B0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x15FF690 Offset: 0x15FF791 VA: 0x15FF690
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x15FF870 Offset: 0x15FF971 VA: 0x15FF870
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x15FFB60 Offset: 0x15FFC61 VA: 0x15FFB60
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x15FFF90 Offset: 0x1600091 VA: 0x15FFF90
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x1600050 Offset: 0x1600151 VA: 0x1600050
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x1600060 Offset: 0x1600161 VA: 0x1600060
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x1600160 Offset: 0x1600261 VA: 0x1600160
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x16002D0 Offset: 0x16003D1 VA: 0x16002D0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1600390 Offset: 0x1600491 VA: 0x1600390
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x1600580 Offset: 0x1600681 VA: 0x1600580
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

[ComVisibleAttribute] // RVA: 0xB04D0 Offset: 0xB05D1 VA: 0xB04D0
public static class FormatterServices // TypeDefIndex: 999
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x15FE320 Offset: 0x15FE421 VA: 0x15FE320
	private static void .cctor() { }

	// RVA: 0x15FE490 Offset: 0x15FE591 VA: 0x15FE490
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FE690 Offset: 0x15FE791 VA: 0x15FE690
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x15FE6B0 Offset: 0x15FE7B1 VA: 0x15FE6B0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FEDD0 Offset: 0x15FEED1 VA: 0x15FEDD0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x15FF160 Offset: 0x15FF261 VA: 0x15FF160
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x15FF3D0 Offset: 0x15FF4D1 VA: 0x15FF3D0
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x15FF590 Offset: 0x15FF691 VA: 0x15FF590
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x15FF5A0 Offset: 0x15FF6A1 VA: 0x15FF5A0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x15FF5B0 Offset: 0x15FF6B1 VA: 0x15FF5B0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x15FF690 Offset: 0x15FF791 VA: 0x15FF690
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x15FF870 Offset: 0x15FF971 VA: 0x15FF870
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x15FFB60 Offset: 0x15FFC61 VA: 0x15FFB60
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x15FFF90 Offset: 0x1600091 VA: 0x15FFF90
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x1600050 Offset: 0x1600151 VA: 0x1600050
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x1600060 Offset: 0x1600161 VA: 0x1600060
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x1600160 Offset: 0x1600261 VA: 0x1600160
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x16002D0 Offset: 0x16003D1 VA: 0x16002D0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1600390 Offset: 0x1600491 VA: 0x1600390
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x1600580 Offset: 0x1600681 VA: 0x1600580
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

[ComVisibleAttribute] // RVA: 0xB04D0 Offset: 0xB05D1 VA: 0xB04D0
public static class FormatterServices // TypeDefIndex: 999
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x15FE320 Offset: 0x15FE421 VA: 0x15FE320
	private static void .cctor() { }

	// RVA: 0x15FE490 Offset: 0x15FE591 VA: 0x15FE490
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FE690 Offset: 0x15FE791 VA: 0x15FE690
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x15FE6B0 Offset: 0x15FE7B1 VA: 0x15FE6B0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x15FEDD0 Offset: 0x15FEED1 VA: 0x15FEDD0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x15FF160 Offset: 0x15FF261 VA: 0x15FF160
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x15FF3D0 Offset: 0x15FF4D1 VA: 0x15FF3D0
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x15FF590 Offset: 0x15FF691 VA: 0x15FF590
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x15FF5A0 Offset: 0x15FF6A1 VA: 0x15FF5A0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x15FF5B0 Offset: 0x15FF6B1 VA: 0x15FF5B0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x15FF690 Offset: 0x15FF791 VA: 0x15FF690
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x15FF870 Offset: 0x15FF971 VA: 0x15FF870
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x15FFB60 Offset: 0x15FFC61 VA: 0x15FFB60
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x15FFF90 Offset: 0x1600091 VA: 0x15FFF90
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x1600050 Offset: 0x1600151 VA: 0x1600050
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x1600060 Offset: 0x1600161 VA: 0x1600060
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x1600160 Offset: 0x1600261 VA: 0x1600160
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x16002D0 Offset: 0x16003D1 VA: 0x16002D0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1600390 Offset: 0x1600491 VA: 0x1600390
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x1600580 Offset: 0x1600681 VA: 0x1600580
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

