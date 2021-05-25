[TaskCategoryAttribute] // RVA: 0x14E190 Offset: 0x14E291 VA: 0x14E190
[TaskDescriptionAttribute] // RVA: 0x14E190 Offset: 0x14E291 VA: 0x14E190
public class GetLength : Action // TypeDefIndex: 11050
{
	// Fields
	[TooltipAttribute] // RVA: 0x187450 Offset: 0x187551 VA: 0x187450
	public SharedString targetString; // 0x50
	[TooltipAttribute] // RVA: 0x187490 Offset: 0x187591 VA: 0x187490
	[RequiredFieldAttribute] // RVA: 0x187490 Offset: 0x187591 VA: 0x187490
	public SharedInt storeResult; // 0x58

	// Methods

	// RVA: 0x288B2B0 Offset: 0x288B3B1 VA: 0x288B2B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288B340 Offset: 0x288B441 VA: 0x288B340 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288B3C0 Offset: 0x288B4C1 VA: 0x288B3C0
	public void .ctor() { }
}

