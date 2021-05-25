[MessagePackObjectAttribute] // RVA: 0x146330 Offset: 0x146431 VA: 0x146330
public struct OrderLotterySaveParameter // TypeDefIndex: 7206
{
	// Fields
	[KeyAttribute] // RVA: 0x165050 Offset: 0x165151 VA: 0x165050
	public int OrderId; // 0x0
	[KeyAttribute] // RVA: 0x165070 Offset: 0x165171 VA: 0x165070
	public int OrderRequestId; // 0x4
	[KeyAttribute] // RVA: 0x165090 Offset: 0x165191 VA: 0x165090
	public int TypeKey; // 0x8

	// Methods

	// RVA: 0x2E1330 Offset: 0x2E1431 VA: 0x2E1330
	public void .ctor(int orderId, int reqId, int type) { }

	// RVA: 0x2E1340 Offset: 0x2E1441 VA: 0x2E1340
	public void Initialize() { }

	// RVA: 0x2E1360 Offset: 0x2E1461 VA: 0x2E1360
	public void SetParameterByOrderData(int orderId, int requestId, int type) { }
}

