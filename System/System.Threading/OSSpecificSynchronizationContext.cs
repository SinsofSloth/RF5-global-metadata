internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 797
{
	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x1A11E60 Offset: 0x1A11F61 VA: 0x1A11E60
	private void .ctor(object osContext) { }

	// RVA: 0x1A11EA0 Offset: 0x1A11FA1 VA: 0x1A11EA0
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x1A12030 Offset: 0x1A12131 VA: 0x1A12030 Slot: 6
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x1A120B0 Offset: 0x1A121B1 VA: 0x1A120B0 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1A12110 Offset: 0x1A12211 VA: 0x1A12110 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute] // RVA: 0xB8BB0 Offset: 0xB8CB1 VA: 0xB8BB0
	// RVA: 0x1A11CD0 Offset: 0x1A11DD1 VA: 0x1A11CD0
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x1A12020 Offset: 0x1A12121 VA: 0x1A12020
	private static object GetOSContext() { }

	// RVA: 0x1A122D0 Offset: 0x1A123D1 VA: 0x1A122D0
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x1A12310 Offset: 0x1A12411 VA: 0x1A12310
	private static void .cctor() { }
}

