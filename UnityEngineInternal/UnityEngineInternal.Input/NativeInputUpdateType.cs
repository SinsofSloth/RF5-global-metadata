[FlagsAttribute] // RVA: 0x10F580 Offset: 0x10F681 VA: 0x10F580
internal enum NativeInputUpdateType // TypeDefIndex: 3810
{
	// Fields
	public int value__; // 0x0
	public const NativeInputUpdateType Dynamic = 1;
	public const NativeInputUpdateType Fixed = 2;
	public const NativeInputUpdateType BeforeRender = 4;
	public const NativeInputUpdateType Editor = 8;
	public const NativeInputUpdateType IgnoreFocus = -2147483648;
}

