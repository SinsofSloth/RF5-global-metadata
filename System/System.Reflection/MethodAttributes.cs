[FlagsAttribute] // RVA: 0xADC00 Offset: 0xADD01 VA: 0xADC00
[ComVisibleAttribute] // RVA: 0xADC00 Offset: 0xADD01 VA: 0xADC00
[Serializable]
public enum MethodAttributes // TypeDefIndex: 549
{
	// Fields
	public int value__; // 0x0
	public const MethodAttributes MemberAccessMask = 7;
	public const MethodAttributes PrivateScope = 0;
	public const MethodAttributes Private = 1;
	public const MethodAttributes FamANDAssem = 2;
	public const MethodAttributes Assembly = 3;
	public const MethodAttributes Family = 4;
	public const MethodAttributes FamORAssem = 5;
	public const MethodAttributes Public = 6;
	public const MethodAttributes Static = 16;
	public const MethodAttributes Final = 32;
	public const MethodAttributes Virtual = 64;
	public const MethodAttributes HideBySig = 128;
	public const MethodAttributes CheckAccessOnOverride = 512;
	public const MethodAttributes VtableLayoutMask = 256;
	public const MethodAttributes ReuseSlot = 0;
	public const MethodAttributes NewSlot = 256;
	public const MethodAttributes Abstract = 1024;
	public const MethodAttributes SpecialName = 2048;
	public const MethodAttributes PinvokeImpl = 8192;
	public const MethodAttributes UnmanagedExport = 8;
	public const MethodAttributes RTSpecialName = 4096;
	public const MethodAttributes ReservedMask = 53248;
	public const MethodAttributes HasSecurity = 16384;
	public const MethodAttributes RequireSecObject = 32768;
}

