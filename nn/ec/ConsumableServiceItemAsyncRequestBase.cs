public abstract class ConsumableServiceItemAsyncRequestBase : IDisposable // TypeDefIndex: 11690
{
	// Fields
	protected IntPtr _consumableServiceItemAsyncRequestBase; // 0x10
	protected bool isDisposed; // 0x18

	// Properties
	internal IntPtr Ptr { get; }

	// Methods

	// RVA: 0x26A6CD0 Offset: 0x26A6DD1 VA: 0x26A6CD0
	public void .ctor() { }

	// RVA: 0x26A70A0 Offset: 0x26A71A1 VA: 0x26A70A0
	internal IntPtr get_Ptr() { }

	// RVA: 0x26A70B0 Offset: 0x26A71B1 VA: 0x26A70B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A7180 Offset: 0x26A7281 VA: 0x26A7180
	public void Cancel() { }

	// RVA: 0x26A7200 Offset: 0x26A7301 VA: 0x26A7200
	public void Wait() { }

	// RVA: 0x26A7280 Offset: 0x26A7381 VA: 0x26A7280
	public bool TryWait() { }

	// RVA: 0x26A7320 Offset: 0x26A7421 VA: 0x26A7320
	public ErrorCode GetErrorCode() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Result Begin() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Result End() { }

	// RVA: 0x26A73B0 Offset: 0x26A74B1 VA: 0x26A73B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A7140 Offset: 0x26A7241 VA: 0x26A7140
	private void _Dispose() { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void Free(IntPtr asyncRequestPtr) { }

	// RVA: 0x26A71F0 Offset: 0x26A72F1 VA: 0x26A71F0
	private static extern void Cancel(IntPtr consumableServiceItemAsyncRequestBase) { }

	// RVA: 0x26A7270 Offset: 0x26A7371 VA: 0x26A7270
	private static extern void Wait(IntPtr consumableServiceItemAsyncRequestBase) { }

	// RVA: 0x26A7300 Offset: 0x26A7401 VA: 0x26A7300
	private static extern bool TryWait(IntPtr consumableServiceItemAsyncRequestBase) { }

	// RVA: 0x26A73A0 Offset: 0x26A74A1 VA: 0x26A73A0
	private static extern ErrorCode GetErrorCode(IntPtr consumableServiceItemAsyncRequestBase) { }
}

