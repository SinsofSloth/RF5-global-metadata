public abstract class SynthesisItemData : NotAmountItemData // TypeDefIndex: 8221
{
	// Fields
	[KeyAttribute] // RVA: 0x16BCB0 Offset: 0x16BDB1 VA: 0x16BCB0
	public ItemID[] SourceItems; // 0x20
	public const int SourceMax = 6;

	// Properties
	[IgnoreMemberAttribute] // RVA: 0x1B9230 Offset: 0x1B9331 VA: 0x1B9230
	public override bool IsOriginal { get; }

	// Methods

	// RVA: 0x1C69410 Offset: 0x1C69511 VA: 0x1C69410 Slot: 13
	public override bool get_IsOriginal() { }

	// RVA: 0x1C69470 Offset: 0x1C69571 VA: 0x1C69470 Slot: 10
	public override ItemData Copy() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool CheckIsArrenge() { }

	// RVA: 0x1C69520 Offset: 0x1C69621 VA: 0x1C69520
	protected void .ctor() { }
}

