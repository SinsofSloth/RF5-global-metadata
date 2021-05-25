[FlagsAttribute] // RVA: 0xAEB80 Offset: 0xAEC81 VA: 0xAEB80
[ComVisibleAttribute] // RVA: 0xAEB80 Offset: 0xAEC81 VA: 0xAEB80
[Serializable]
public enum FileAttributes // TypeDefIndex: 681
{
	// Fields
	public int value__; // 0x0
	public const FileAttributes Archive = 32;
	public const FileAttributes Compressed = 2048;
	public const FileAttributes Device = 64;
	public const FileAttributes Directory = 16;
	public const FileAttributes Encrypted = 16384;
	public const FileAttributes Hidden = 2;
	public const FileAttributes Normal = 128;
	public const FileAttributes NotContentIndexed = 8192;
	public const FileAttributes Offline = 4096;
	public const FileAttributes ReadOnly = 1;
	public const FileAttributes ReparsePoint = 1024;
	public const FileAttributes SparseFile = 512;
	public const FileAttributes System = 4;
	public const FileAttributes Temporary = 256;
	public const FileAttributes IntegrityStream = 32768;
	public const FileAttributes NoScrubData = 131072;
}

