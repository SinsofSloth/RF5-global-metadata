[ComVisibleAttribute] // RVA: 0xAB2F0 Offset: 0xAB3F1 VA: 0xAB2F0
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 88
{
	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[ComVisibleAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	[MonoTODOAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1929D70 Offset: 0x1929E71 VA: 0x1929D70
	private static void .cctor() { }

	// RVA: 0x1929D20 Offset: 0x1929E21 VA: 0x1929D20
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1929F30 Offset: 0x192A031 VA: 0x1929F30
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1926660 Offset: 0x1926761 VA: 0x1926660
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x192A140 Offset: 0x192A241 VA: 0x192A140
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x192A220 Offset: 0x192A321 VA: 0x192A220 Slot: 6
	public void Dispose() { }

	// RVA: 0x192A3C0 Offset: 0x192A4C1 VA: 0x192A3C0
	public string get_Name() { }

	// RVA: 0x192A3D0 Offset: 0x192A4D1 VA: 0x192A3D0
	public void Flush() { }

	// RVA: 0x192A290 Offset: 0x192A391 VA: 0x192A290
	public void Close() { }

	// RVA: 0x192A4B0 Offset: 0x192A5B1 VA: 0x192A4B0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x192A7A0 Offset: 0x192A8A1 VA: 0x192A7A0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x192A7B0 Offset: 0x192A8B1 VA: 0x192A7B0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x192AA60 Offset: 0x192AB61 VA: 0x192AA60
	public object GetValue(string name) { }

	// RVA: 0x192AA70 Offset: 0x192AB71 VA: 0x192AA70
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x192ABF0 Offset: 0x192ACF1 VA: 0x192ABF0
	public string[] GetSubKeyNames() { }

	// RVA: 0x192AD50 Offset: 0x192AE51 VA: 0x192AD50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1927E80 Offset: 0x1927F81 VA: 0x1927E80
	internal bool get_IsRoot() { }

	// RVA: 0x1927E90 Offset: 0x1927F91 VA: 0x1927E90
	internal RegistryHive get_Hive() { }

	// RVA: 0x192AEB0 Offset: 0x192AFB1 VA: 0x192AEB0
	internal object get_InternalHandle() { }

	// RVA: 0x192A6A0 Offset: 0x192A7A1 VA: 0x192A6A0
	private void AssertKeyStillValid() { }

	// RVA: 0x192A9D0 Offset: 0x192AAD1 VA: 0x192A9D0
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x192AEC0 Offset: 0x192AFC1 VA: 0x192AEC0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x192AF70 Offset: 0x192B071 VA: 0x192AF70
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x192A040 Offset: 0x192A141 VA: 0x192A040
	private static string GetHiveName(RegistryHive hive) { }
}

[ComVisibleAttribute] // RVA: 0xAB2F0 Offset: 0xAB3F1 VA: 0xAB2F0
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 88
{
	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[ComVisibleAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	[MonoTODOAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1929D70 Offset: 0x1929E71 VA: 0x1929D70
	private static void .cctor() { }

	// RVA: 0x1929D20 Offset: 0x1929E21 VA: 0x1929D20
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1929F30 Offset: 0x192A031 VA: 0x1929F30
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1926660 Offset: 0x1926761 VA: 0x1926660
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x192A140 Offset: 0x192A241 VA: 0x192A140
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x192A220 Offset: 0x192A321 VA: 0x192A220 Slot: 6
	public void Dispose() { }

	// RVA: 0x192A3C0 Offset: 0x192A4C1 VA: 0x192A3C0
	public string get_Name() { }

	// RVA: 0x192A3D0 Offset: 0x192A4D1 VA: 0x192A3D0
	public void Flush() { }

	// RVA: 0x192A290 Offset: 0x192A391 VA: 0x192A290
	public void Close() { }

	// RVA: 0x192A4B0 Offset: 0x192A5B1 VA: 0x192A4B0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x192A7A0 Offset: 0x192A8A1 VA: 0x192A7A0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x192A7B0 Offset: 0x192A8B1 VA: 0x192A7B0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x192AA60 Offset: 0x192AB61 VA: 0x192AA60
	public object GetValue(string name) { }

	// RVA: 0x192AA70 Offset: 0x192AB71 VA: 0x192AA70
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x192ABF0 Offset: 0x192ACF1 VA: 0x192ABF0
	public string[] GetSubKeyNames() { }

	// RVA: 0x192AD50 Offset: 0x192AE51 VA: 0x192AD50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1927E80 Offset: 0x1927F81 VA: 0x1927E80
	internal bool get_IsRoot() { }

	// RVA: 0x1927E90 Offset: 0x1927F91 VA: 0x1927E90
	internal RegistryHive get_Hive() { }

	// RVA: 0x192AEB0 Offset: 0x192AFB1 VA: 0x192AEB0
	internal object get_InternalHandle() { }

	// RVA: 0x192A6A0 Offset: 0x192A7A1 VA: 0x192A6A0
	private void AssertKeyStillValid() { }

	// RVA: 0x192A9D0 Offset: 0x192AAD1 VA: 0x192A9D0
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x192AEC0 Offset: 0x192AFC1 VA: 0x192AEC0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x192AF70 Offset: 0x192B071 VA: 0x192AF70
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x192A040 Offset: 0x192A141 VA: 0x192A040
	private static string GetHiveName(RegistryHive hive) { }
}

[ComVisibleAttribute] // RVA: 0xAB2F0 Offset: 0xAB3F1 VA: 0xAB2F0
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 88
{
	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[ComVisibleAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	[MonoTODOAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1929D70 Offset: 0x1929E71 VA: 0x1929D70
	private static void .cctor() { }

	// RVA: 0x1929D20 Offset: 0x1929E21 VA: 0x1929D20
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1929F30 Offset: 0x192A031 VA: 0x1929F30
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1926660 Offset: 0x1926761 VA: 0x1926660
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x192A140 Offset: 0x192A241 VA: 0x192A140
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x192A220 Offset: 0x192A321 VA: 0x192A220 Slot: 6
	public void Dispose() { }

	// RVA: 0x192A3C0 Offset: 0x192A4C1 VA: 0x192A3C0
	public string get_Name() { }

	// RVA: 0x192A3D0 Offset: 0x192A4D1 VA: 0x192A3D0
	public void Flush() { }

	// RVA: 0x192A290 Offset: 0x192A391 VA: 0x192A290
	public void Close() { }

	// RVA: 0x192A4B0 Offset: 0x192A5B1 VA: 0x192A4B0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x192A7A0 Offset: 0x192A8A1 VA: 0x192A7A0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x192A7B0 Offset: 0x192A8B1 VA: 0x192A7B0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x192AA60 Offset: 0x192AB61 VA: 0x192AA60
	public object GetValue(string name) { }

	// RVA: 0x192AA70 Offset: 0x192AB71 VA: 0x192AA70
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x192ABF0 Offset: 0x192ACF1 VA: 0x192ABF0
	public string[] GetSubKeyNames() { }

	// RVA: 0x192AD50 Offset: 0x192AE51 VA: 0x192AD50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1927E80 Offset: 0x1927F81 VA: 0x1927E80
	internal bool get_IsRoot() { }

	// RVA: 0x1927E90 Offset: 0x1927F91 VA: 0x1927E90
	internal RegistryHive get_Hive() { }

	// RVA: 0x192AEB0 Offset: 0x192AFB1 VA: 0x192AEB0
	internal object get_InternalHandle() { }

	// RVA: 0x192A6A0 Offset: 0x192A7A1 VA: 0x192A6A0
	private void AssertKeyStillValid() { }

	// RVA: 0x192A9D0 Offset: 0x192AAD1 VA: 0x192A9D0
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x192AEC0 Offset: 0x192AFC1 VA: 0x192AEC0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x192AF70 Offset: 0x192B071 VA: 0x192AF70
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x192A040 Offset: 0x192A141 VA: 0x192A040
	private static string GetHiveName(RegistryHive hive) { }
}

[ComVisibleAttribute] // RVA: 0xAB2F0 Offset: 0xAB3F1 VA: 0xAB2F0
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 88
{
	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[ComVisibleAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	[MonoTODOAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1929D70 Offset: 0x1929E71 VA: 0x1929D70
	private static void .cctor() { }

	// RVA: 0x1929D20 Offset: 0x1929E21 VA: 0x1929D20
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1929F30 Offset: 0x192A031 VA: 0x1929F30
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1926660 Offset: 0x1926761 VA: 0x1926660
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x192A140 Offset: 0x192A241 VA: 0x192A140
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x192A220 Offset: 0x192A321 VA: 0x192A220 Slot: 6
	public void Dispose() { }

	// RVA: 0x192A3C0 Offset: 0x192A4C1 VA: 0x192A3C0
	public string get_Name() { }

	// RVA: 0x192A3D0 Offset: 0x192A4D1 VA: 0x192A3D0
	public void Flush() { }

	// RVA: 0x192A290 Offset: 0x192A391 VA: 0x192A290
	public void Close() { }

	// RVA: 0x192A4B0 Offset: 0x192A5B1 VA: 0x192A4B0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x192A7A0 Offset: 0x192A8A1 VA: 0x192A7A0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x192A7B0 Offset: 0x192A8B1 VA: 0x192A7B0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x192AA60 Offset: 0x192AB61 VA: 0x192AA60
	public object GetValue(string name) { }

	// RVA: 0x192AA70 Offset: 0x192AB71 VA: 0x192AA70
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x192ABF0 Offset: 0x192ACF1 VA: 0x192ABF0
	public string[] GetSubKeyNames() { }

	// RVA: 0x192AD50 Offset: 0x192AE51 VA: 0x192AD50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1927E80 Offset: 0x1927F81 VA: 0x1927E80
	internal bool get_IsRoot() { }

	// RVA: 0x1927E90 Offset: 0x1927F91 VA: 0x1927E90
	internal RegistryHive get_Hive() { }

	// RVA: 0x192AEB0 Offset: 0x192AFB1 VA: 0x192AEB0
	internal object get_InternalHandle() { }

	// RVA: 0x192A6A0 Offset: 0x192A7A1 VA: 0x192A6A0
	private void AssertKeyStillValid() { }

	// RVA: 0x192A9D0 Offset: 0x192AAD1 VA: 0x192A9D0
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x192AEC0 Offset: 0x192AFC1 VA: 0x192AEC0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x192AF70 Offset: 0x192B071 VA: 0x192AF70
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x192A040 Offset: 0x192A141 VA: 0x192A040
	private static string GetHiveName(RegistryHive hive) { }
}

[ComVisibleAttribute] // RVA: 0xAB2F0 Offset: 0xAB3F1 VA: 0xAB2F0
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 88
{
	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[ComVisibleAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	[MonoTODOAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1929D70 Offset: 0x1929E71 VA: 0x1929D70
	private static void .cctor() { }

	// RVA: 0x1929D20 Offset: 0x1929E21 VA: 0x1929D20
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1929F30 Offset: 0x192A031 VA: 0x1929F30
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1926660 Offset: 0x1926761 VA: 0x1926660
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x192A140 Offset: 0x192A241 VA: 0x192A140
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x192A220 Offset: 0x192A321 VA: 0x192A220 Slot: 6
	public void Dispose() { }

	// RVA: 0x192A3C0 Offset: 0x192A4C1 VA: 0x192A3C0
	public string get_Name() { }

	// RVA: 0x192A3D0 Offset: 0x192A4D1 VA: 0x192A3D0
	public void Flush() { }

	// RVA: 0x192A290 Offset: 0x192A391 VA: 0x192A290
	public void Close() { }

	// RVA: 0x192A4B0 Offset: 0x192A5B1 VA: 0x192A4B0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x192A7A0 Offset: 0x192A8A1 VA: 0x192A7A0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x192A7B0 Offset: 0x192A8B1 VA: 0x192A7B0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x192AA60 Offset: 0x192AB61 VA: 0x192AA60
	public object GetValue(string name) { }

	// RVA: 0x192AA70 Offset: 0x192AB71 VA: 0x192AA70
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x192ABF0 Offset: 0x192ACF1 VA: 0x192ABF0
	public string[] GetSubKeyNames() { }

	// RVA: 0x192AD50 Offset: 0x192AE51 VA: 0x192AD50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1927E80 Offset: 0x1927F81 VA: 0x1927E80
	internal bool get_IsRoot() { }

	// RVA: 0x1927E90 Offset: 0x1927F91 VA: 0x1927E90
	internal RegistryHive get_Hive() { }

	// RVA: 0x192AEB0 Offset: 0x192AFB1 VA: 0x192AEB0
	internal object get_InternalHandle() { }

	// RVA: 0x192A6A0 Offset: 0x192A7A1 VA: 0x192A6A0
	private void AssertKeyStillValid() { }

	// RVA: 0x192A9D0 Offset: 0x192AAD1 VA: 0x192A9D0
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x192AEC0 Offset: 0x192AFC1 VA: 0x192AEC0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x192AF70 Offset: 0x192B071 VA: 0x192AF70
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x192A040 Offset: 0x192A141 VA: 0x192A040
	private static string GetHiveName(RegistryHive hive) { }
}

[ComVisibleAttribute] // RVA: 0xAB2F0 Offset: 0xAB3F1 VA: 0xAB2F0
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 88
{
	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[ComVisibleAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	[MonoTODOAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1929D70 Offset: 0x1929E71 VA: 0x1929D70
	private static void .cctor() { }

	// RVA: 0x1929D20 Offset: 0x1929E21 VA: 0x1929D20
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1929F30 Offset: 0x192A031 VA: 0x1929F30
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1926660 Offset: 0x1926761 VA: 0x1926660
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x192A140 Offset: 0x192A241 VA: 0x192A140
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x192A220 Offset: 0x192A321 VA: 0x192A220 Slot: 6
	public void Dispose() { }

	// RVA: 0x192A3C0 Offset: 0x192A4C1 VA: 0x192A3C0
	public string get_Name() { }

	// RVA: 0x192A3D0 Offset: 0x192A4D1 VA: 0x192A3D0
	public void Flush() { }

	// RVA: 0x192A290 Offset: 0x192A391 VA: 0x192A290
	public void Close() { }

	// RVA: 0x192A4B0 Offset: 0x192A5B1 VA: 0x192A4B0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x192A7A0 Offset: 0x192A8A1 VA: 0x192A7A0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x192A7B0 Offset: 0x192A8B1 VA: 0x192A7B0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x192AA60 Offset: 0x192AB61 VA: 0x192AA60
	public object GetValue(string name) { }

	// RVA: 0x192AA70 Offset: 0x192AB71 VA: 0x192AA70
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x192ABF0 Offset: 0x192ACF1 VA: 0x192ABF0
	public string[] GetSubKeyNames() { }

	// RVA: 0x192AD50 Offset: 0x192AE51 VA: 0x192AD50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1927E80 Offset: 0x1927F81 VA: 0x1927E80
	internal bool get_IsRoot() { }

	// RVA: 0x1927E90 Offset: 0x1927F91 VA: 0x1927E90
	internal RegistryHive get_Hive() { }

	// RVA: 0x192AEB0 Offset: 0x192AFB1 VA: 0x192AEB0
	internal object get_InternalHandle() { }

	// RVA: 0x192A6A0 Offset: 0x192A7A1 VA: 0x192A6A0
	private void AssertKeyStillValid() { }

	// RVA: 0x192A9D0 Offset: 0x192AAD1 VA: 0x192A9D0
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x192AEC0 Offset: 0x192AFC1 VA: 0x192AEC0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x192AF70 Offset: 0x192B071 VA: 0x192AF70
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x192A040 Offset: 0x192A141 VA: 0x192A040
	private static string GetHiveName(RegistryHive hive) { }
}

[ComVisibleAttribute] // RVA: 0xAB2F0 Offset: 0xAB3F1 VA: 0xAB2F0
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 88
{
	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[ComVisibleAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	[MonoTODOAttribute] // RVA: 0xB9F90 Offset: 0xBA091 VA: 0xB9F90
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1929D70 Offset: 0x1929E71 VA: 0x1929D70
	private static void .cctor() { }

	// RVA: 0x1929D20 Offset: 0x1929E21 VA: 0x1929D20
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1929F30 Offset: 0x192A031 VA: 0x1929F30
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1926660 Offset: 0x1926761 VA: 0x1926660
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x192A140 Offset: 0x192A241 VA: 0x192A140
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x192A220 Offset: 0x192A321 VA: 0x192A220 Slot: 6
	public void Dispose() { }

	// RVA: 0x192A3C0 Offset: 0x192A4C1 VA: 0x192A3C0
	public string get_Name() { }

	// RVA: 0x192A3D0 Offset: 0x192A4D1 VA: 0x192A3D0
	public void Flush() { }

	// RVA: 0x192A290 Offset: 0x192A391 VA: 0x192A290
	public void Close() { }

	// RVA: 0x192A4B0 Offset: 0x192A5B1 VA: 0x192A4B0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x192A7A0 Offset: 0x192A8A1 VA: 0x192A7A0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x192A7B0 Offset: 0x192A8B1 VA: 0x192A7B0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x192AA60 Offset: 0x192AB61 VA: 0x192AA60
	public object GetValue(string name) { }

	// RVA: 0x192AA70 Offset: 0x192AB71 VA: 0x192AA70
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x192ABF0 Offset: 0x192ACF1 VA: 0x192ABF0
	public string[] GetSubKeyNames() { }

	// RVA: 0x192AD50 Offset: 0x192AE51 VA: 0x192AD50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1927E80 Offset: 0x1927F81 VA: 0x1927E80
	internal bool get_IsRoot() { }

	// RVA: 0x1927E90 Offset: 0x1927F91 VA: 0x1927E90
	internal RegistryHive get_Hive() { }

	// RVA: 0x192AEB0 Offset: 0x192AFB1 VA: 0x192AEB0
	internal object get_InternalHandle() { }

	// RVA: 0x192A6A0 Offset: 0x192A7A1 VA: 0x192A6A0
	private void AssertKeyStillValid() { }

	// RVA: 0x192A9D0 Offset: 0x192AAD1 VA: 0x192A9D0
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x192AEC0 Offset: 0x192AFC1 VA: 0x192AEC0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x192AF70 Offset: 0x192B071 VA: 0x192AF70
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x192A040 Offset: 0x192A141 VA: 0x192A040
	private static string GetHiveName(RegistryHive hive) { }
}

