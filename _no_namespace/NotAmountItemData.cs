public abstract class NotAmountItemData : ItemData // TypeDefIndex: 8217
{
	// Fields
	[KeyAttribute] // RVA: 0x16BC60 Offset: 0x16BD61 VA: 0x16BC60
	public int Level; // 0x14
	[IgnoreMemberAttribute] // RVA: 0x16BC80 Offset: 0x16BD81 VA: 0x16BC80
	private bool Poped; // 0x18

	// Properties
	[IgnoreMemberAttribute] // RVA: 0x1B91E0 Offset: 0x1B92E1 VA: 0x1B91E0
	public override int Amount { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B91F0 Offset: 0x1B92F1 VA: 0x1B91F0
	public override int ItemLevel { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9200 Offset: 0x1B9301 VA: 0x1B9200
	public override int FreeSpace { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9210 Offset: 0x1B9311 VA: 0x1B9210
	public override int SortValue { get; }

	// Methods

	// RVA: 0x1FB7D10 Offset: 0x1FB7E11 VA: 0x1FB7D10 Slot: 4
	public override int get_Amount() { }

	// RVA: 0x1FB7D20 Offset: 0x1FB7E21 VA: 0x1FB7D20 Slot: 5
	public override int get_ItemLevel() { }

	// RVA: 0x1FB7D30 Offset: 0x1FB7E31 VA: 0x1FB7D30 Slot: 6
	public override int get_FreeSpace() { }

	// RVA: 0x1FB7D40 Offset: 0x1FB7E41 VA: 0x1FB7D40 Slot: 7
	public override int get_SortValue() { }

	// RVA: 0x1FB7D50 Offset: 0x1FB7E51 VA: 0x1FB7D50 Slot: 8
	public override void AppendMigrate(ItemData ItemData) { }

	// RVA: 0x1FB7D60 Offset: 0x1FB7E61 VA: 0x1FB7D60 Slot: 9
	public override ItemData Pop(int amount) { }

	// RVA: 0x1FB7D90 Offset: 0x1FB7E91 VA: 0x1FB7D90 Slot: 10
	public override ItemData Copy() { }

	// RVA: -1 Offset: -1
	protected static void CopyTo<T>(T[] source, out T[] to) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6A70 Offset: 0x21D6B71 VA: 0x21D6A70
	|-NotAmountItemData.CopyTo<ItemID>
	|-NotAmountItemData.CopyTo<Int32Enum>
	|
	|-RVA: 0x21D6B30 Offset: 0x21D6C31 VA: 0x21D6B30
	|-NotAmountItemData.CopyTo<object>
	*/

	// RVA: 0x1FB7E30 Offset: 0x1FB7F31 VA: 0x1FB7E30
	protected void .ctor() { }
}

