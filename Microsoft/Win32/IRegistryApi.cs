internal interface IRegistryApi // TypeDefIndex: 85
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writtable) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Flush(RegistryKey rkey) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Close(RegistryKey rkey) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(RegistryKey rkey) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IntPtr GetHandle(RegistryKey key) { }
}

