[Serializable]
public class OrderMasterData // TypeDefIndex: 7213
{
	// Fields
	public int OrderId; // 0x10
	public OrderCategory OrderCategory; // 0x14
	public int EventId; // 0x18
	public int OrderNpcId; // 0x1C
	public int OrderRequestNpcId; // 0x20
	public int RandomId; // 0x24
	public int OrderNeedRank; // 0x28
	public int[] OrderNeedCompOrders; // 0x30
	public OrderType OrderType; // 0x38
	public OrderCompleteType OrderCompleteType; // 0x3C
	public int OrderWithNpcId; // 0x40
	public int OrderEquipWeapon; // 0x44
	public int OrderTargetSpecialType; // 0x48
	public int OrderTargetType; // 0x4C
	public int OrderTargetId; // 0x50
	public int OrderTargetLv; // 0x54
	public int OrderTargetCompleteAmount; // 0x58
	public int OrderDeliverTarget; // 0x5C
	public int[] OrderOccuredType; // 0x60
	public int[] OrderOccuredTypeValue; // 0x68
	public int RepeatType; // 0x70
	public int[] RewardType; // 0x78
	public int[] RewardId; // 0x80
	public int[] RewardAmount; // 0x88
	public int[] RewardItemLevel; // 0x90
	public int[] RewardPosition; // 0x98
	public int[] HandoutType; // 0xA0
	public int[] HandoutId; // 0xA8
	public int[] HandoutAmount; // 0xB0
	public string OrderEventStartPoint; // 0xB8
	public string OrderAcceptScriptID; // 0xC0
	public string OrderClearScriptID; // 0xC8
	public GameFlagData OrderAcceptFlag; // 0xD0
	public GameFlagData OrderClearFlag; // 0xD4
	public bool RewardUnnecessary; // 0xD8

	// Methods

	// RVA: 0x1F2B7A0 Offset: 0x1F2B8A1 VA: 0x1F2B7A0
	public void .ctor() { }
}

