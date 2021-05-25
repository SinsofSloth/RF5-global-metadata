[MessagePackObjectAttribute] // RVA: 0x1462F0 Offset: 0x1463F1 VA: 0x1462F0
public struct OrderSaveData // TypeDefIndex: 7204
{
	// Fields
	[KeyAttribute] // RVA: 0x164E90 Offset: 0x164F91 VA: 0x164E90
	public int OrderClearCount; // 0x0
	[KeyAttribute] // RVA: 0x164EB0 Offset: 0x164FB1 VA: 0x164EB0
	public List<OrderSaveParameter> AcceptOrderParameters; // 0x8
	[KeyAttribute] // RVA: 0x164ED0 Offset: 0x164FD1 VA: 0x164ED0
	public List<OrderLotterySaveParameter> LotteryBoardOrderDatas; // 0x10
	[KeyAttribute] // RVA: 0x164EF0 Offset: 0x164FF1 VA: 0x164EF0
	public List<OrderLotterySaveParameter> LotteryNpcOrderDatas; // 0x18
	[KeyAttribute] // RVA: 0x164F10 Offset: 0x165011 VA: 0x164F10
	public List<OrderSaveParameter> LotMasterOrderParameters; // 0x20

	// Methods

	// RVA: 0x2E13C0 Offset: 0x2E14C1 VA: 0x2E13C0
	public void InitializeForNewGame() { }

	// RVA: 0x2E13D0 Offset: 0x2E14D1 VA: 0x2E13D0
	public void Initialize() { }
}

