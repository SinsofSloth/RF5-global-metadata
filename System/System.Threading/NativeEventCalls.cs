internal static class NativeEventCalls // TypeDefIndex: 828
{
	// Methods

	// RVA: 0x1A0DA80 Offset: 0x1A0DB81 VA: 0x1A0DA80
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x1A0DBE0 Offset: 0x1A0DCE1 VA: 0x1A0DBE0
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1A11CA0 Offset: 0x1A11DA1 VA: 0x1A11CA0
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x1A0DB20 Offset: 0x1A0DC21 VA: 0x1A0DB20
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1A11CB0 Offset: 0x1A11DB1 VA: 0x1A11CB0
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x1A11CC0 Offset: 0x1A11DC1 VA: 0x1A11CC0
	public static void CloseEvent_internal(IntPtr handle) { }
}

