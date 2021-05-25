public sealed class AsyncConsumeRightDataRequest : ConsumableServiceItemAsyncRequestBase // TypeDefIndex: 11692
{
	// Methods

	// RVA: 0x26A6C70 Offset: 0x26A6D71 VA: 0x26A6C70
	public void .ctor() { }

	// RVA: 0x26A6D30 Offset: 0x26A6E31 VA: 0x26A6D30 Slot: 7
	protected override void Free(IntPtr asyncRequestPtr) { }

	// RVA: 0x26A6D50 Offset: 0x26A6E51 VA: 0x26A6D50 Slot: 5
	public override Result Begin() { }

	// RVA: 0x26A6D90 Offset: 0x26A6E91 VA: 0x26A6D90 Slot: 6
	public override Result End() { }

	// RVA: 0x26A6D70 Offset: 0x26A6E71 VA: 0x26A6D70
	private static extern Result Begin(IntPtr asyncConsumeRightDataRequest) { }

	// RVA: 0x26A6DB0 Offset: 0x26A6EB1 VA: 0x26A6DB0
	private static extern Result End(IntPtr asyncConsumeRightDataRequest) { }

	// RVA: 0x26A6D20 Offset: 0x26A6E21 VA: 0x26A6D20
	private static extern void New(ref IntPtr asyncConsumeRightDataRequest) { }

	// RVA: 0x26A6D40 Offset: 0x26A6E41 VA: 0x26A6D40
	private static extern void Delete(IntPtr asyncConsumeRightDataRequest) { }
}

