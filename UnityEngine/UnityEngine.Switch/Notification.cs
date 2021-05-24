public static class Notification // TypeDefIndex: 3879
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x115020 Offset: 0x115121 VA: 0x115020
	[CompilerGeneratedAttribute] // RVA: 0x115020 Offset: 0x115121 VA: 0x115020
	private static Action<Notification.Message> notificationMessageReceived; // 0x0

	// Methods

	// RVA: 0x3516E70 Offset: 0x3516F71 VA: 0x3516E70
	public static void SetFocusHandlingMode(Notification.FocusHandlingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x1157E0 Offset: 0x1158E1 VA: 0x1157E0
	[NativeConditionalAttribute] // RVA: 0x1157E0 Offset: 0x1158E1 VA: 0x1157E0
	// RVA: 0x3516EC0 Offset: 0x3516FC1 VA: 0x3516EC0
	private static void SetFocusHandlingMode_Internal(Notification.FocusHandlingMode mode) { }

	// RVA: 0x3516F10 Offset: 0x3517011 VA: 0x3516F10
	public static Notification.FocusState GetCurrentFocusState() { }

	[FreeFunctionAttribute] // RVA: 0x115840 Offset: 0x115941 VA: 0x115840
	[NativeConditionalAttribute] // RVA: 0x115840 Offset: 0x115941 VA: 0x115840
	// RVA: 0x3516F50 Offset: 0x3517051 VA: 0x3516F50
	private static Notification.FocusState GetCurrentFocusState_Internal() { }

	// RVA: 0x3516F90 Offset: 0x3517091 VA: 0x3516F90
	public static void SetResumeNotificationEnabled(bool enabled) { }

	[FreeFunctionAttribute] // RVA: 0x1158A0 Offset: 0x1159A1 VA: 0x1158A0
	[NativeConditionalAttribute] // RVA: 0x1158A0 Offset: 0x1159A1 VA: 0x1158A0
	// RVA: 0x3516FE0 Offset: 0x35170E1 VA: 0x3516FE0
	private static void SetResumeNotificationEnabled_Internal(bool enabled) { }

	// RVA: 0x3517030 Offset: 0x3517131 VA: 0x3517030
	public static void EnterExitRequestHandlingSection() { }

	[FreeFunctionAttribute] // RVA: 0x115900 Offset: 0x115A01 VA: 0x115900
	[NativeConditionalAttribute] // RVA: 0x115900 Offset: 0x115A01 VA: 0x115900
	// RVA: 0x3517070 Offset: 0x3517171 VA: 0x3517070
	private static void EnterExitRequestHandlingSection_Internal() { }

	// RVA: 0x35170B0 Offset: 0x35171B1 VA: 0x35170B0
	public static void LeaveExitRequestHandlingSection() { }

	[NativeConditionalAttribute] // RVA: 0x115960 Offset: 0x115A61 VA: 0x115960
	[FreeFunctionAttribute] // RVA: 0x115960 Offset: 0x115A61 VA: 0x115960
	// RVA: 0x35170F0 Offset: 0x35171F1 VA: 0x35170F0
	private static void LeaveExitRequestHandlingSection_Internal() { }

	// RVA: 0x3517130 Offset: 0x3517231 VA: 0x3517130
	public static void SetOperationModeChangedNotificationEnabled(bool enabled) { }

	[FreeFunctionAttribute] // RVA: 0x1159C0 Offset: 0x115AC1 VA: 0x1159C0
	[NativeConditionalAttribute] // RVA: 0x1159C0 Offset: 0x115AC1 VA: 0x1159C0
	// RVA: 0x3517180 Offset: 0x3517281 VA: 0x3517180
	private static void SetOperationModeChangedNotificationEnabled_Internal(bool enabled) { }

	// RVA: 0x35171D0 Offset: 0x35172D1 VA: 0x35171D0
	public static void SetPerformanceModeChangedNotificationEnabled(bool enabled) { }

	[FreeFunctionAttribute] // RVA: 0x115A20 Offset: 0x115B21 VA: 0x115A20
	[NativeConditionalAttribute] // RVA: 0x115A20 Offset: 0x115B21 VA: 0x115A20
	// RVA: 0x3517220 Offset: 0x3517321 VA: 0x3517220
	private static void SetPerformanceModeChangedNotificationEnabled_Internal(bool enabled) { }

	// RVA: 0x3517270 Offset: 0x3517371 VA: 0x3517270
	private static void InvokeNotificationMessage(int message) { }

	[CompilerGeneratedAttribute] // RVA: 0x115A80 Offset: 0x115B81 VA: 0x115A80
	// RVA: 0x35172F0 Offset: 0x35173F1 VA: 0x35172F0
	public static void add_notificationMessageReceived(Action<Notification.Message> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x115A90 Offset: 0x115B91 VA: 0x115A90
	// RVA: 0x35173B0 Offset: 0x35174B1 VA: 0x35173B0
	public static void remove_notificationMessageReceived(Action<Notification.Message> value) { }
}

