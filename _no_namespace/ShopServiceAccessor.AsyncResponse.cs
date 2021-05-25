public sealed class ShopServiceAccessor.AsyncResponse : IDisposable // TypeDefIndex: 11700
{
	// Fields
	internal IntPtr _asyncResponse; // 0x10
	private bool isDisposed; // 0x18

	// Methods

	// RVA: 0x26A9150 Offset: 0x26A9251 VA: 0x26A9150
	public void .ctor() { }

	// RVA: 0x26A91C0 Offset: 0x26A92C1 VA: 0x26A91C0
	public void .ctor(IntPtr asyncResponsePtr) { }

	// RVA: 0x26A9220 Offset: 0x26A9321 VA: 0x26A9220 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A9340 Offset: 0x26A9441 VA: 0x26A9340
	public Result Get(ref string outJson) { }

	// RVA: 0x26A9470 Offset: 0x26A9571 VA: 0x26A9470
	public void Wait() { }

	// RVA: 0x26A9490 Offset: 0x26A9591 VA: 0x26A9490
	public bool TryWait() { }

	// RVA: 0x26A94D0 Offset: 0x26A95D1 VA: 0x26A94D0
	public void Cancel() { }

	// RVA: 0x26A94F0 Offset: 0x26A95F1 VA: 0x26A94F0
	public ErrorCode GetErrorCode() { }

	// RVA: 0x26A9290 Offset: 0x26A9391 VA: 0x26A9290 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A9420 Offset: 0x26A9521 VA: 0x26A9420
	private static extern Result GetSize(IntPtr asyncResponse, ref long outSize) { }

	// RVA: 0x26A9440 Offset: 0x26A9541 VA: 0x26A9440
	private static extern Result Get(IntPtr asyncResponse, byte[] outReceivedData, long bufferCapacity) { }

	// RVA: 0x26A9480 Offset: 0x26A9581 VA: 0x26A9480
	private static extern void Wait(IntPtr asyncResponce) { }

	// RVA: 0x26A94B0 Offset: 0x26A95B1 VA: 0x26A94B0
	private static extern bool TryWait(IntPtr asyncResponce) { }

	// RVA: 0x26A94E0 Offset: 0x26A95E1 VA: 0x26A94E0
	private static extern void Cancel(IntPtr asyncResponce) { }

	// RVA: 0x26A9500 Offset: 0x26A9601 VA: 0x26A9500
	private static extern ErrorCode GetErrorCode(IntPtr asyncResponce) { }

	// RVA: 0x26A91B0 Offset: 0x26A92B1 VA: 0x26A91B0
	private static extern void New(ref IntPtr asyncResponce) { }

	// RVA: 0x26A9510 Offset: 0x26A9611 VA: 0x26A9510
	private static extern void Delete(IntPtr asyncResponce) { }
}

