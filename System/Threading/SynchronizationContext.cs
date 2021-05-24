public class SynchronizationContext // TypeDefIndex: 796
{
	// Fields
	private SynchronizationContextProperties _props; // 0x10
	private static Type s_cachedPreparedType1; // 0x0
	private static Type s_cachedPreparedType2; // 0x8
	private static Type s_cachedPreparedType3; // 0x10
	private static Type s_cachedPreparedType4; // 0x18
	private static Type s_cachedPreparedType5; // 0x20

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }

	// Methods

	// RVA: 0x157A430 Offset: 0x157A531 VA: 0x157A430
	public void .ctor() { }

	// RVA: 0x157A440 Offset: 0x157A541 VA: 0x157A440 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x157A460 Offset: 0x157A561 VA: 0x157A460 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x157A4F0 Offset: 0x157A5F1 VA: 0x157A4F0
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x157A630 Offset: 0x157A731 VA: 0x157A630
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowedAttribute] // RVA: 0xB8BA0 Offset: 0xB8CA1 VA: 0xB8BA0
	// RVA: 0x157A7C0 Offset: 0x157A8C1 VA: 0x157A7C0
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x157A750 Offset: 0x157A851 VA: 0x157A750
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x157A8B0 Offset: 0x157A9B1 VA: 0x157A8B0 Slot: 6
	public virtual SynchronizationContext CreateCopy() { }
}

