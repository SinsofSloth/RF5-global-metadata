public sealed class AsyncRecoverRightDataRequest : ConsumableServiceItemAsyncRequestBase // TypeDefIndex: 11693
{
	// Methods

	// RVA: 0x26A6EE0 Offset: 0x26A6FE1 VA: 0x26A6EE0
	public void .ctor() { }

	// RVA: 0x26A6F60 Offset: 0x26A7061 VA: 0x26A6F60 Slot: 7
	protected override void Free(IntPtr asyncRequestPtr) { }

	// RVA: 0x26A6F90 Offset: 0x26A7091 VA: 0x26A6F90 Slot: 5
	public override Result Begin() { }

	// RVA: 0x26A6FD0 Offset: 0x26A70D1 VA: 0x26A6FD0 Slot: 6
	public override Result End() { }

	// RVA: 0x26A6FB0 Offset: 0x26A70B1 VA: 0x26A6FB0
	private static extern Result Begin(IntPtr asyncGetConsumableRightDataRequestBase) { }

	// RVA: 0x26A6FF0 Offset: 0x26A70F1 VA: 0x26A6FF0
	private static extern Result End(IntPtr asyncGetConsumableRightDataRequestBase) { }

	// RVA: 0x26A6F40 Offset: 0x26A7041 VA: 0x26A6F40
	private static extern Result New(ref IntPtr asyncGetConsumableRightDataRequestBase) { }

	// RVA: 0x26A6F70 Offset: 0x26A7071 VA: 0x26A6F70
	private static extern Result Delete(IntPtr asyncGetConsumableRightDataRequestBase) { }
}

