[FlagsAttribute] // RVA: 0xADB00 Offset: 0xADC01 VA: 0xADB00
[Serializable]
internal enum PInvokeAttributes // TypeDefIndex: 544
{
	// Fields
	public int value__; // 0x0
	public const PInvokeAttributes NoMangle = 1;
	public const PInvokeAttributes CharSetMask = 6;
	public const PInvokeAttributes CharSetNotSpec = 0;
	public const PInvokeAttributes CharSetAnsi = 2;
	public const PInvokeAttributes CharSetUnicode = 4;
	public const PInvokeAttributes CharSetAuto = 6;
	public const PInvokeAttributes BestFitUseAssem = 0;
	public const PInvokeAttributes BestFitEnabled = 16;
	public const PInvokeAttributes BestFitDisabled = 32;
	public const PInvokeAttributes BestFitMask = 48;
	public const PInvokeAttributes ThrowOnUnmappableCharUseAssem = 0;
	public const PInvokeAttributes ThrowOnUnmappableCharEnabled = 4096;
	public const PInvokeAttributes ThrowOnUnmappableCharDisabled = 8192;
	public const PInvokeAttributes ThrowOnUnmappableCharMask = 12288;
	public const PInvokeAttributes SupportsLastError = 64;
	public const PInvokeAttributes CallConvMask = 1792;
	public const PInvokeAttributes CallConvWinapi = 256;
	public const PInvokeAttributes CallConvCdecl = 512;
	public const PInvokeAttributes CallConvStdcall = 768;
	public const PInvokeAttributes CallConvThiscall = 1024;
	public const PInvokeAttributes CallConvFastcall = 1280;
	public const PInvokeAttributes MaxValue = 65535;
}

