internal class UnixRegistryApi : IRegistryApi // TypeDefIndex: 94
{
	// Methods

	// RVA: 0x192B540 Offset: 0x192B641 VA: 0x192B540
	private static string ToUnix(string keyname) { }

	// RVA: 0x192B5A0 Offset: 0x192B6A1 VA: 0x192B5A0
	private static bool IsWellKnownKey(string parentKeyName, string keyname) { }

	// RVA: 0x192B6E0 Offset: 0x192B7E1 VA: 0x192B6E0 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x192B830 Offset: 0x192B931 VA: 0x192B830 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x192B8C0 Offset: 0x192B9C1 VA: 0x192B8C0 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x192B940 Offset: 0x192BA41 VA: 0x192B940 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	// RVA: 0x192BA10 Offset: 0x192BB11 VA: 0x192BA10 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x192BA90 Offset: 0x192BB91 VA: 0x192BA90 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x192B820 Offset: 0x192B921 VA: 0x192B820
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x192BAB0 Offset: 0x192BBB1 VA: 0x192BAB0
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile) { }

	// RVA: 0x192BC40 Offset: 0x192BD41 VA: 0x192BC40 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x1929F20 Offset: 0x192A021 VA: 0x1929F20
	public void .ctor() { }
}

