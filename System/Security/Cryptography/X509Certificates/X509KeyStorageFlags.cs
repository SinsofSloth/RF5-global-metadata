[FlagsAttribute] // RVA: 0xB0450 Offset: 0xB0551 VA: 0xB0450
public enum X509KeyStorageFlags // TypeDefIndex: 988
{
	// Fields
	public int value__; // 0x0
	public const X509KeyStorageFlags DefaultKeySet = 0;
	public const X509KeyStorageFlags UserKeySet = 1;
	public const X509KeyStorageFlags MachineKeySet = 2;
	public const X509KeyStorageFlags Exportable = 4;
	public const X509KeyStorageFlags UserProtected = 8;
	public const X509KeyStorageFlags PersistKeySet = 16;
	public const X509KeyStorageFlags EphemeralKeySet = 32;
}

