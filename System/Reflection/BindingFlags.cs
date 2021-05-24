[ComVisibleAttribute] // RVA: 0xAD900 Offset: 0xADA01 VA: 0xAD900
[FlagsAttribute] // RVA: 0xAD900 Offset: 0xADA01 VA: 0xAD900
[Serializable]
public enum BindingFlags // TypeDefIndex: 532
{
	// Fields
	public int value__; // 0x0
	public const BindingFlags Default = 0;
	public const BindingFlags IgnoreCase = 1;
	public const BindingFlags DeclaredOnly = 2;
	public const BindingFlags Instance = 4;
	public const BindingFlags Static = 8;
	public const BindingFlags Public = 16;
	public const BindingFlags NonPublic = 32;
	public const BindingFlags FlattenHierarchy = 64;
	public const BindingFlags InvokeMethod = 256;
	public const BindingFlags CreateInstance = 512;
	public const BindingFlags GetField = 1024;
	public const BindingFlags SetField = 2048;
	public const BindingFlags GetProperty = 4096;
	public const BindingFlags SetProperty = 8192;
	public const BindingFlags PutDispProperty = 16384;
	public const BindingFlags PutRefDispProperty = 32768;
	public const BindingFlags ExactBinding = 65536;
	public const BindingFlags SuppressChangeType = 131072;
	public const BindingFlags OptionalParamBinding = 262144;
	public const BindingFlags IgnoreReturn = 16777216;
}

