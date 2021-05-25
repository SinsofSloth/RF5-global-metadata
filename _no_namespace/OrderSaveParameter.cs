[MessagePackObjectAttribute] // RVA: 0x146310 Offset: 0x146411 VA: 0x146310
public struct OrderSaveParameter // TypeDefIndex: 7205
{
	// Fields
	[KeyAttribute] // RVA: 0x164F30 Offset: 0x165031 VA: 0x164F30
	public int OrderId; // 0x0
	[KeyAttribute] // RVA: 0x164F50 Offset: 0x165051 VA: 0x164F50
	public int AcceptId; // 0x4
	[KeyAttribute] // RVA: 0x164F70 Offset: 0x165071 VA: 0x164F70
	public int OrderTargetCurrentAmount; // 0x8
	[KeyAttribute] // RVA: 0x164F90 Offset: 0x165091 VA: 0x164F90
	public int CompleteDate; // 0xC
	[KeyAttribute] // RVA: 0x164FB0 Offset: 0x1650B1 VA: 0x164FB0
	public bool RecievedOrder; // 0x10
	[KeyAttribute] // RVA: 0x164FD0 Offset: 0x1650D1 VA: 0x164FD0
	public bool Completed; // 0x11
	[KeyAttribute] // RVA: 0x164FF0 Offset: 0x1650F1 VA: 0x164FF0
	public bool GotReward; // 0x12
	[KeyAttribute] // RVA: 0x165010 Offset: 0x165111 VA: 0x165010
	public bool FirstCompleted; // 0x13
	[KeyAttribute] // RVA: 0x165030 Offset: 0x165131 VA: 0x165030
	public string CompletedEventStep; // 0x18

	// Methods

	// RVA: 0x2E1510 Offset: 0x2E1611 VA: 0x2E1510
	public void Initialize() { }

	// RVA: 0x2E1580 Offset: 0x2E1681 VA: 0x2E1580
	public void SetParameterByOrderData(OrderData data) { }
}

