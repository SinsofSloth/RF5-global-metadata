[MessagePackObjectAttribute] // RVA: 0x146890 Offset: 0x146991 VA: 0x146890
public class AmountItemData : ItemData // TypeDefIndex: 8205
{
	// Fields
	[KeyAttribute] // RVA: 0x16B950 Offset: 0x16BA51 VA: 0x16B950
	public List<int> LevelAmount; // 0x18
	private static AmountItemData.LevelAmountCompare CompareClass; // 0x0

	// Properties
	[IgnoreMemberAttribute] // RVA: 0x1B9010 Offset: 0x1B9111 VA: 0x1B9010
	private int StackSize { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9020 Offset: 0x1B9121 VA: 0x1B9020
	public override int Amount { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9030 Offset: 0x1B9131 VA: 0x1B9030
	public override int ItemLevel { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9040 Offset: 0x1B9141 VA: 0x1B9040
	public override int FreeSpace { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9050 Offset: 0x1B9151 VA: 0x1B9050
	public override int SortValue { get; }

	// Methods

	// RVA: 0x22793D0 Offset: 0x22794D1 VA: 0x22793D0
	private int get_StackSize() { }

	// RVA: 0x2279400 Offset: 0x2279501 VA: 0x2279400 Slot: 4
	public override int get_Amount() { }

	// RVA: 0x2279450 Offset: 0x2279551 VA: 0x2279450 Slot: 5
	public override int get_ItemLevel() { }

	// RVA: 0x22794C0 Offset: 0x22795C1 VA: 0x22794C0 Slot: 6
	public override int get_FreeSpace() { }

	// RVA: 0x2279510 Offset: 0x2279611 VA: 0x2279510 Slot: 7
	public override int get_SortValue() { }

	// RVA: 0x22795C0 Offset: 0x22796C1 VA: 0x22795C0
	private void LevelAmountSort() { }

	// RVA: 0x2279650 Offset: 0x2279751 VA: 0x2279650 Slot: 8
	public override void AppendMigrate(ItemData itemData) { }

	// RVA: 0x2279830 Offset: 0x2279931 VA: 0x2279830 Slot: 9
	public override ItemData Pop(int amount) { }

	// RVA: 0x22798F0 Offset: 0x22799F1 VA: 0x22798F0 Slot: 16
	public override int GetTotalShopPrice() { }

	// RVA: 0x22799F0 Offset: 0x2279AF1 VA: 0x22799F0 Slot: 17
	public override int GetTotalSellPrice() { }

	// RVA: 0x2279AF0 Offset: 0x2279BF1 VA: 0x2279AF0 Slot: 10
	public override ItemData Copy() { }

	// RVA: 0x2279BD0 Offset: 0x2279CD1 VA: 0x2279BD0
	public void .ctor() { }

	// RVA: 0x2279C50 Offset: 0x2279D51 VA: 0x2279C50
	private static void .cctor() { }
}

