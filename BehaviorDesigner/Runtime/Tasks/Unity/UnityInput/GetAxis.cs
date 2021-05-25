[TaskCategoryAttribute] // RVA: 0x1535E0 Offset: 0x1536E1 VA: 0x1535E0
[TaskDescriptionAttribute] // RVA: 0x1535E0 Offset: 0x1536E1 VA: 0x1535E0
public class GetAxis : Action // TypeDefIndex: 11279
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F690 Offset: 0x18F791 VA: 0x18F690
	public SharedString axisName; // 0x50
	[TooltipAttribute] // RVA: 0x18F6D0 Offset: 0x18F7D1 VA: 0x18F6D0
	public SharedFloat multiplier; // 0x58
	[RequiredFieldAttribute] // RVA: 0x18F710 Offset: 0x18F811 VA: 0x18F710
	[TooltipAttribute] // RVA: 0x18F710 Offset: 0x18F811 VA: 0x18F710
	public SharedFloat storeResult; // 0x60

	// Methods

	// RVA: 0x27A1FF0 Offset: 0x27A20F1 VA: 0x27A1FF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A20B0 Offset: 0x27A21B1 VA: 0x27A20B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A2150 Offset: 0x27A2251 VA: 0x27A2150
	public void .ctor() { }
}

