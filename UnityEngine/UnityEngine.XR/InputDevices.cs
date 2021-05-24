[StaticAccessorAttribute] // RVA: 0x106870 Offset: 0x106971 VA: 0x106870
[UsedByNativeCodeAttribute] // RVA: 0x106870 Offset: 0x106971 VA: 0x106870
[NativeHeaderAttribute] // RVA: 0x106870 Offset: 0x106971 VA: 0x106870
[NativeConditionalAttribute] // RVA: 0x106870 Offset: 0x106971 VA: 0x106870
public class InputDevices // TypeDefIndex: 3729
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x106FB0 Offset: 0x1070B1 VA: 0x106FB0
	[DebuggerBrowsableAttribute] // RVA: 0x106FB0 Offset: 0x1070B1 VA: 0x106FB0
	private static Action<InputDevice> deviceConnected; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x106FF0 Offset: 0x1070F1 VA: 0x106FF0
	[CompilerGeneratedAttribute] // RVA: 0x106FF0 Offset: 0x1070F1 VA: 0x106FF0
	private static Action<InputDevice> deviceDisconnected; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x107030 Offset: 0x107131 VA: 0x107030
	[DebuggerBrowsableAttribute] // RVA: 0x107030 Offset: 0x107131 VA: 0x107030
	private static Action<InputDevice> deviceConfigChanged; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x107280 Offset: 0x107381 VA: 0x107280
	// RVA: 0x1BCC4F0 Offset: 0x1BCC5F1 VA: 0x1BCC4F0
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }
}

