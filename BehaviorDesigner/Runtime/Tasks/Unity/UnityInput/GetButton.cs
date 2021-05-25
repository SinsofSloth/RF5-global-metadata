[TaskCategoryAttribute] // RVA: 0x1536A0 Offset: 0x1537A1 VA: 0x1536A0
[TaskDescriptionAttribute] // RVA: 0x1536A0 Offset: 0x1537A1 VA: 0x1536A0
public class GetButton : Action // TypeDefIndex: 11281
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F830 Offset: 0x18F931 VA: 0x18F830
	public SharedString buttonName; // 0x50
	[RequiredFieldAttribute] // RVA: 0x18F870 Offset: 0x18F971 VA: 0x18F870
	[TooltipAttribute] // RVA: 0x18F870 Offset: 0x18F971 VA: 0x18F870
	public SharedBool storeResult; // 0x58

	// Methods

	// RVA: 0x27A22D0 Offset: 0x27A23D1 VA: 0x27A22D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A2360 Offset: 0x27A2461 VA: 0x27A2360 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A23E0 Offset: 0x27A24E1 VA: 0x27A23E0
	public void .ctor() { }
}

