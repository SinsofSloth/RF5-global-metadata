[UnionAttribute] // RVA: 0x146950 Offset: 0x146A51 VA: 0x146950
[UnionAttribute] // RVA: 0x146950 Offset: 0x146A51 VA: 0x146950
[UnionAttribute] // RVA: 0x146950 Offset: 0x146A51 VA: 0x146950
[UnionAttribute] // RVA: 0x146950 Offset: 0x146A51 VA: 0x146950
[UnionAttribute] // RVA: 0x146950 Offset: 0x146A51 VA: 0x146950
[UnionAttribute] // RVA: 0x146950 Offset: 0x146A51 VA: 0x146950
[UnionAttribute] // RVA: 0x146950 Offset: 0x146A51 VA: 0x146950
[MessagePackObjectAttribute] // RVA: 0x146950 Offset: 0x146A51 VA: 0x146950
public abstract class ItemData // TypeDefIndex: 8214
{
	// Fields
	[KeyAttribute] // RVA: 0x16BC20 Offset: 0x16BD21 VA: 0x16BC20
	public ItemID ItemID; // 0x10

	// Properties
	[IgnoreMemberAttribute] // RVA: 0x1B9100 Offset: 0x1B9201 VA: 0x1B9100
	public ItemDataTable ItemDataTable { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9110 Offset: 0x1B9211 VA: 0x1B9110
	public UseParamDataTable UseParameterDataTable { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9120 Offset: 0x1B9221 VA: 0x1B9120
	public abstract int Amount { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9130 Offset: 0x1B9231 VA: 0x1B9130
	public abstract int ItemLevel { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9140 Offset: 0x1B9241 VA: 0x1B9140
	public abstract int FreeSpace { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9150 Offset: 0x1B9251 VA: 0x1B9150
	public abstract int SortValue { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9160 Offset: 0x1B9261 VA: 0x1B9160
	public bool IsFull { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9170 Offset: 0x1B9271 VA: 0x1B9170
	public bool IsEquipale { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9180 Offset: 0x1B9281 VA: 0x1B9180
	public virtual bool IsEatble { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9190 Offset: 0x1B9291 VA: 0x1B9190
	public virtual bool CalcCheckGomi { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B91A0 Offset: 0x1B92A1 VA: 0x1B91A0
	public bool IsStackable { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B91B0 Offset: 0x1B92B1 VA: 0x1B91B0
	public virtual bool IsOriginal { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B91C0 Offset: 0x1B92C1 VA: 0x1B91C0
	public int ShopPrice { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B91D0 Offset: 0x1B92D1 VA: 0x1B91D0
	public int SellPrice { get; }

	// Methods

	// RVA: 0x20D0AB0 Offset: 0x20D0BB1 VA: 0x20D0AB0
	public ItemDataTable get_ItemDataTable() { }

	// RVA: 0x20D0C00 Offset: 0x20D0D01 VA: 0x20D0C00
	public UseParamDataTable get_UseParameterDataTable() { }

	// RVA: 0x20D0C10 Offset: 0x20D0D11 VA: 0x20D0C10
	public static ItemData Instantiate(ItemID itemID, int level = 1) { }

	// RVA: 0x20D0CF0 Offset: 0x20D0DF1 VA: 0x20D0CF0
	public static ItemData Instantiate(ItemID itemID, int[] levelAmount) { }

	// RVA: 0x20D0D70 Offset: 0x20D0E71 VA: 0x20D0D70
	public static ItemData Instantiate(ItemID itemID, List<int> levelAmount) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_Amount() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_ItemLevel() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_FreeSpace() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_SortValue() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void AppendMigrate(ItemData ItemData) { }

	// RVA: 0x20D10C0 Offset: 0x20D11C1 VA: 0x20D10C0
	public ItemData Pop() { }

	// RVA: 0x20D10D0 Offset: 0x20D11D1 VA: 0x20D10D0
	public ItemData PopAll() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ItemData Pop(int amount) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ItemData Copy() { }

	// RVA: 0x20D1110 Offset: 0x20D1211 VA: 0x20D1110
	public bool get_IsFull() { }

	// RVA: 0x20D1140 Offset: 0x20D1241 VA: 0x20D1140
	public bool get_IsEquipale() { }

	// RVA: 0x20D1150 Offset: 0x20D1251 VA: 0x20D1150 Slot: 11
	public virtual bool get_IsEatble() { }

	// RVA: 0x20D1160 Offset: 0x20D1261 VA: 0x20D1160 Slot: 12
	public virtual bool get_CalcCheckGomi() { }

	// RVA: 0x20D1170 Offset: 0x20D1271 VA: 0x20D1170
	public bool get_IsStackable() { }

	// RVA: 0x20D11A0 Offset: 0x20D12A1 VA: 0x20D11A0 Slot: 13
	public virtual bool get_IsOriginal() { }

	// RVA: 0x20D11B0 Offset: 0x20D12B1 VA: 0x20D11B0 Slot: 14
	public virtual Parameter CalcParameter() { }

	// RVA: 0x20D11F0 Offset: 0x20D12F1 VA: 0x20D11F0 Slot: 15
	public virtual UseParameter CalcUseParameter() { }

	// RVA: 0x20D1390 Offset: 0x20D1491 VA: 0x20D1390
	public int get_ShopPrice() { }

	// RVA: 0x20D14F0 Offset: 0x20D15F1 VA: 0x20D14F0
	public int get_SellPrice() { }

	// RVA: 0x20D1560 Offset: 0x20D1661 VA: 0x20D1560 Slot: 16
	public virtual int GetTotalShopPrice() { }

	// RVA: 0x20D15D0 Offset: 0x20D16D1 VA: 0x20D15D0 Slot: 17
	public virtual int GetTotalSellPrice() { }

	// RVA: 0x20D1640 Offset: 0x20D1741 VA: 0x20D1640 Slot: 3
	public override string ToString() { }

	// RVA: 0x20D1650 Offset: 0x20D1751 VA: 0x20D1650
	protected void .ctor() { }
}

