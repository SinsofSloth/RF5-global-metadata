[ComVisibleAttribute] // RVA: 0xAEBE0 Offset: 0xAECE1 VA: 0xAEBE0
[FlagsAttribute] // RVA: 0xAEBE0 Offset: 0xAECE1 VA: 0xAEBE0
[Serializable]
public enum FileOptions // TypeDefIndex: 683
{
	// Fields
	public int value__; // 0x0
	public const FileOptions None = 0;
	public const FileOptions Encrypted = 16384;
	public const FileOptions DeleteOnClose = 67108864;
	public const FileOptions SequentialScan = 134217728;
	public const FileOptions RandomAccess = 268435456;
	public const FileOptions Asynchronous = 1073741824;
	public const FileOptions WriteThrough = -2147483648;
}

