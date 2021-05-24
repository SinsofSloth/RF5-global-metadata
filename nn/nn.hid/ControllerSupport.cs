public static class ControllerSupport // TypeDefIndex: 11543
{
	// Fields
	public const int ExplainTextMaxLength = 32;
	public const int Utf8ByteSize = 4;
	public const int ExplainTextMaxBufferSize = 129;
	public const int ControllerSupportPlayerCountMax = 8;

	// Properties
	public static ErrorRange ResultCanceled { get; }
	public static ErrorRange ResultNotSupportedNpadStyle { get; }

	// Methods

	// RVA: 0x26AE280 Offset: 0x26AE381 VA: 0x26AE280
	public static extern Result Show(ControllerSupportArg showControllerSupportArg) { }

	// RVA: 0x26AE380 Offset: 0x26AE481 VA: 0x26AE380
	public static extern Result Show(ref ControllerSupportResultInfo pOutValue, ControllerSupportArg showControllerSupportArg) { }

	// RVA: 0x26AE490 Offset: 0x26AE591 VA: 0x26AE490
	public static extern void SetExplainText(ref ControllerSupportArg pOutControllerSupportArg, string pStr, NpadId npadId) { }

	// RVA: 0x26AE600 Offset: 0x26AE701 VA: 0x26AE600
	public static Result Show(ControllerSupportArg showControllerSupportArg, bool suspendUnityThreads) { }

	// RVA: 0x26AE810 Offset: 0x26AE911 VA: 0x26AE810
	public static Result Show(ref ControllerSupportResultInfo pOutValue, ControllerSupportArg showControllerSupportArg, bool suspendUnityThreads) { }

	// RVA: 0x26AEA20 Offset: 0x26AEB21 VA: 0x26AEA20
	public static ErrorRange get_ResultCanceled() { }

	// RVA: 0x26AEA30 Offset: 0x26AEB31 VA: 0x26AEA30
	public static ErrorRange get_ResultNotSupportedNpadStyle() { }
}

