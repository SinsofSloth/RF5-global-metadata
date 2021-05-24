[NativeHeaderAttribute] // RVA: 0x114E80 Offset: 0x114F81 VA: 0x114E80
public static class NetworkInterfaceWrapper // TypeDefIndex: 3873
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x114FE0 Offset: 0x1150E1 VA: 0x114FE0
	[DebuggerBrowsableAttribute] // RVA: 0x114FE0 Offset: 0x1150E1 VA: 0x114FE0
	private static NetworkInterfaceWrapper.NetworkConnectedHandler _networkConnected; // 0x0

	// Methods

	[NativeConditionalAttribute] // RVA: 0x1150A0 Offset: 0x1151A1 VA: 0x1150A0
	[ThreadSafeAttribute] // RVA: 0x1150A0 Offset: 0x1151A1 VA: 0x1150A0
	// RVA: 0x3516440 Offset: 0x3516541 VA: 0x3516440
	public static bool EnterNetworkConnecting(bool isLocalNetworkMode = False) { }

	[NativeConditionalAttribute] // RVA: 0x1150F0 Offset: 0x1151F1 VA: 0x1150F0
	[FreeFunctionAttribute] // RVA: 0x1150F0 Offset: 0x1151F1 VA: 0x1150F0
	[ThreadSafeAttribute] // RVA: 0x1150F0 Offset: 0x1151F1 VA: 0x1150F0
	// RVA: 0x3516490 Offset: 0x3516591 VA: 0x3516490
	public static bool EnterNetworkConnecting(bool isLocalNetworkMode, bool reportIfUnavailable) { }

	[FreeFunctionAttribute] // RVA: 0x115160 Offset: 0x115261 VA: 0x115160
	[ThreadSafeAttribute] // RVA: 0x115160 Offset: 0x115261 VA: 0x115160
	[NativeConditionalAttribute] // RVA: 0x115160 Offset: 0x115261 VA: 0x115160
	// RVA: 0x35164E0 Offset: 0x35165E1 VA: 0x35164E0
	public static bool WeakEnterNetworkConnecting() { }

	[ThreadSafeAttribute] // RVA: 0x1151D0 Offset: 0x1152D1 VA: 0x1151D0
	[NativeConditionalAttribute] // RVA: 0x1151D0 Offset: 0x1152D1 VA: 0x1151D0
	[FreeFunctionAttribute] // RVA: 0x1151D0 Offset: 0x1152D1 VA: 0x1151D0
	// RVA: 0x3516520 Offset: 0x3516621 VA: 0x3516520
	public static void LeaveNetworkConnecting() { }

	[NativeConditionalAttribute] // RVA: 0x115240 Offset: 0x115341 VA: 0x115240
	[FreeFunctionAttribute] // RVA: 0x115240 Offset: 0x115341 VA: 0x115240
	[ThreadSafeAttribute] // RVA: 0x115240 Offset: 0x115341 VA: 0x115240
	// RVA: 0x3516560 Offset: 0x3516661 VA: 0x3516560
	public static bool IsNetworkConnecting() { }

	[ThreadSafeAttribute] // RVA: 0x1152B0 Offset: 0x1153B1 VA: 0x1152B0
	[NativeConditionalAttribute] // RVA: 0x1152B0 Offset: 0x1153B1 VA: 0x1152B0
	[FreeFunctionAttribute] // RVA: 0x1152B0 Offset: 0x1153B1 VA: 0x1152B0
	// RVA: 0x35165A0 Offset: 0x35166A1 VA: 0x35165A0
	public static void WaitForNetworkConnecting() { }

	[FreeFunctionAttribute] // RVA: 0x115320 Offset: 0x115421 VA: 0x115320
	[NativeConditionalAttribute] // RVA: 0x115320 Offset: 0x115421 VA: 0x115320
	[ThreadSafeAttribute] // RVA: 0x115320 Offset: 0x115421 VA: 0x115320
	// RVA: 0x35165E0 Offset: 0x35166E1 VA: 0x35165E0
	public static bool IsNetworkAccepted() { }

	[NativeConditionalAttribute] // RVA: 0x115390 Offset: 0x115491 VA: 0x115390
	[ThreadSafeAttribute] // RVA: 0x115390 Offset: 0x115491 VA: 0x115390
	[FreeFunctionAttribute] // RVA: 0x115390 Offset: 0x115491 VA: 0x115390
	// RVA: 0x3516620 Offset: 0x3516721 VA: 0x3516620
	public static bool IsNetworkFinished() { }

	[ThreadSafeAttribute] // RVA: 0x115400 Offset: 0x115501 VA: 0x115400
	[FreeFunctionAttribute] // RVA: 0x115400 Offset: 0x115501 VA: 0x115400
	[NativeConditionalAttribute] // RVA: 0x115400 Offset: 0x115501 VA: 0x115400
	// RVA: 0x3516660 Offset: 0x3516761 VA: 0x3516660
	public static int GetNetworkReferenceCount() { }

	[FreeFunctionAttribute] // RVA: 0x115470 Offset: 0x115571 VA: 0x115470
	[NativeConditionalAttribute] // RVA: 0x115470 Offset: 0x115571 VA: 0x115470
	[ThreadSafeAttribute] // RVA: 0x115470 Offset: 0x115571 VA: 0x115470
	// RVA: 0x35166A0 Offset: 0x35167A1 VA: 0x35166A0
	public static bool IsNetworkAvailable() { }

	[NativeConditionalAttribute] // RVA: 0x1154E0 Offset: 0x1155E1 VA: 0x1154E0
	[ThreadSafeAttribute] // RVA: 0x1154E0 Offset: 0x1155E1 VA: 0x1154E0
	[FreeFunctionAttribute] // RVA: 0x1154E0 Offset: 0x1155E1 VA: 0x1154E0
	// RVA: 0x35166E0 Offset: 0x35167E1 VA: 0x35166E0
	public static bool IsNetworkConnectingOnBackground() { }

	[FreeFunctionAttribute] // RVA: 0x115550 Offset: 0x115651 VA: 0x115550
	[ThreadSafeAttribute] // RVA: 0x115550 Offset: 0x115651 VA: 0x115550
	[NativeConditionalAttribute] // RVA: 0x115550 Offset: 0x115651 VA: 0x115550
	// RVA: 0x3516720 Offset: 0x3516821 VA: 0x3516720
	public static void SetNetworkConnectingOnBackground(bool isBackground) { }

	[FreeFunctionAttribute] // RVA: 0x1155C0 Offset: 0x1156C1 VA: 0x1155C0
	[ThreadSafeAttribute] // RVA: 0x1155C0 Offset: 0x1156C1 VA: 0x1155C0
	[NativeConditionalAttribute] // RVA: 0x1155C0 Offset: 0x1156C1 VA: 0x1155C0
	// RVA: 0x3516770 Offset: 0x3516871 VA: 0x3516770
	private static void SetNetworkConnectedEnabled(bool isEnabled) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x115630 Offset: 0x115731 VA: 0x115630
	// RVA: 0x35167C0 Offset: 0x35168C1 VA: 0x35167C0
	private static int InvokeNetworkConnected() { }

	// RVA: 0x3516A70 Offset: 0x3516B71 VA: 0x3516A70
	public static void add_networkConnected(NetworkInterfaceWrapper.NetworkConnectedHandler value) { }

	// RVA: 0x3516C10 Offset: 0x3516D11 VA: 0x3516C10
	public static void remove_networkConnected(NetworkInterfaceWrapper.NetworkConnectedHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x115640 Offset: 0x115741 VA: 0x115640
	// RVA: 0x3516B50 Offset: 0x3516C51 VA: 0x3516B50
	private static void add__networkConnected(NetworkInterfaceWrapper.NetworkConnectedHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x115650 Offset: 0x115751 VA: 0x115650
	// RVA: 0x3516D30 Offset: 0x3516E31 VA: 0x3516D30
	private static void remove__networkConnected(NetworkInterfaceWrapper.NetworkConnectedHandler value) { }
}

