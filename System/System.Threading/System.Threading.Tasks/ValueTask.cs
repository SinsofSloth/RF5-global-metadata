[AsyncMethodBuilderAttribute] // RVA: 0x129480 Offset: 0x129581 VA: 0x129480
[IsReadOnlyAttribute] // RVA: 0x129480 Offset: 0x129581 VA: 0x129480
public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 4429
{
	// Fields
	private static readonly Task s_canceledTask; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x129670 Offset: 0x129771 VA: 0x129670
	private static readonly Task <CompletedTask>k__BackingField; // 0x8
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x129690 Offset: 0x129791 VA: 0x129690
	// RVA: 0x1BDA120 Offset: 0x1BDA221 VA: 0x1BDA120
	internal static Task get_CompletedTask() { }

	// RVA: 0x269C0 Offset: 0x26AC1 VA: 0x269C0
	public void .ctor(Task task) { }

	// RVA: 0x26A00 Offset: 0x26B01 VA: 0x26A00
	private void .ctor(object obj, short token, bool continueOnCapturedContext) { }

	// RVA: 0x26A50 Offset: 0x26B51 VA: 0x26A50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26A70 Offset: 0x26B71 VA: 0x26A70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26B40 Offset: 0x26C41 VA: 0x26B40 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x26B70 Offset: 0x26C71 VA: 0x26B70
	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x1296A0 Offset: 0x1297A1 VA: 0x1296A0
	// RVA: 0x26C90 Offset: 0x26D91 VA: 0x26C90
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x26CA0 Offset: 0x26DA1 VA: 0x26CA0
	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1BDA630 Offset: 0x1BDA731 VA: 0x1BDA630
	private static void .cctor() { }
}

