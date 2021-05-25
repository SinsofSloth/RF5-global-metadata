internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 1915
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xBCF00 Offset: 0xBD001 VA: 0xBCF00
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_UserEvent; // 0x34
	private object m_Event; // 0x38

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }

	// Methods

	// RVA: 0x1794DF0 Offset: 0x1794EF1 VA: 0x1794DF0
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x177E670 Offset: 0x177E771 VA: 0x177E670
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1794EA0 Offset: 0x1794FA1 VA: 0x1794EA0
	internal object get_AsyncObject() { }

	// RVA: 0x1794EB0 Offset: 0x1794FB1 VA: 0x1794EB0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1794EC0 Offset: 0x1794FC1 VA: 0x1794EC0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1794F90 Offset: 0x1795091 VA: 0x1794F90
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x17951B0 Offset: 0x17952B1 VA: 0x17951B0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x177FEA0 Offset: 0x177FFA1 VA: 0x177FEA0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x17951A0 Offset: 0x17952A1 VA: 0x17951A0
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x17951F0 Offset: 0x17952F1 VA: 0x17951F0
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x177F1F0 Offset: 0x177F2F1 VA: 0x177F1F0
	internal void InvokeCallback(object result) { }

	// RVA: 0x17953F0 Offset: 0x17954F1 VA: 0x17953F0 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x17955C0 Offset: 0x17956C1 VA: 0x17955C0
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x1795640 Offset: 0x1795741 VA: 0x1795640 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x177EA30 Offset: 0x177EB31 VA: 0x177EA30
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1795650 Offset: 0x1795751 VA: 0x1795650
	private object WaitForCompletion(bool snap) { }
}

