[NativeConditionalAttribute] // RVA: 0x106AE0 Offset: 0x106BE1 VA: 0x106AE0
[NativeTypeAttribute] // RVA: 0x106AE0 Offset: 0x106BE1 VA: 0x106AE0
[UsedByNativeCodeAttribute] // RVA: 0x106AE0 Offset: 0x106BE1 VA: 0x106AE0
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 3734
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x1070B0 Offset: 0x1071B1 VA: 0x1070B0
	[CompilerGeneratedAttribute] // RVA: 0x1070B0 Offset: 0x1071B1 VA: 0x1070B0
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1070F0 Offset: 0x1071F1 VA: 0x1070F0
	[DebuggerBrowsableAttribute] // RVA: 0x1070F0 Offset: 0x1071F1 VA: 0x1070F0
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x1072A0 Offset: 0x1073A1 VA: 0x1072A0
	// RVA: 0x1BCD130 Offset: 0x1BCD231 VA: 0x1BCD130
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1072E0 Offset: 0x1073E1 VA: 0x1072E0
	// RVA: 0x1BCD210 Offset: 0x1BCD311 VA: 0x1BCD210
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x1BCD2F0 Offset: 0x1BCD3F1 VA: 0x1BCD2F0
	public void .ctor() { }
}

