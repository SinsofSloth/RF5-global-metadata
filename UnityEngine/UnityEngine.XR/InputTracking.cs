[StaticAccessorAttribute] // RVA: 0x106450 Offset: 0x106551 VA: 0x106450
[NativeConditionalAttribute] // RVA: 0x106450 Offset: 0x106551 VA: 0x106450
[NativeHeaderAttribute] // RVA: 0x106450 Offset: 0x106551 VA: 0x106450
[RequiredByNativeCodeAttribute] // RVA: 0x106450 Offset: 0x106551 VA: 0x106450
public static class InputTracking // TypeDefIndex: 3717
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x106E70 Offset: 0x106F71 VA: 0x106E70
	[CompilerGeneratedAttribute] // RVA: 0x106E70 Offset: 0x106F71 VA: 0x106E70
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x106EB0 Offset: 0x106FB1 VA: 0x106EB0
	[DebuggerBrowsableAttribute] // RVA: 0x106EB0 Offset: 0x106FB1 VA: 0x106EB0
	private static Action<XRNodeState> trackingLost; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x106EF0 Offset: 0x106FF1 VA: 0x106EF0
	[DebuggerBrowsableAttribute] // RVA: 0x106EF0 Offset: 0x106FF1 VA: 0x106EF0
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x106F30 Offset: 0x107031 VA: 0x106F30
	[DebuggerBrowsableAttribute] // RVA: 0x106F30 Offset: 0x107031 VA: 0x106F30
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x107270 Offset: 0x107371 VA: 0x107270
	// RVA: 0x1BCC760 Offset: 0x1BCC861 VA: 0x1BCC760
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

	// RVA: 0x1BCC9F0 Offset: 0x1BCCAF1 VA: 0x1BCC9F0
	private static void .cctor() { }
}

