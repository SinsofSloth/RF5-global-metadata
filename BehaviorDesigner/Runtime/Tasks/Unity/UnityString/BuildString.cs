[TaskCategoryAttribute] // RVA: 0x14E070 Offset: 0x14E171 VA: 0x14E070
[TaskDescriptionAttribute] // RVA: 0x14E070 Offset: 0x14E171 VA: 0x14E070
public class BuildString : Action // TypeDefIndex: 11047
{
	// Fields
	[TooltipAttribute] // RVA: 0x187220 Offset: 0x187321 VA: 0x187220
	public SharedString[] source; // 0x50
	[TooltipAttribute] // RVA: 0x187260 Offset: 0x187361 VA: 0x187260
	[RequiredFieldAttribute] // RVA: 0x187260 Offset: 0x187361 VA: 0x187260
	public SharedString storeResult; // 0x58

	// Methods

	// RVA: 0x288ACE0 Offset: 0x288ADE1 VA: 0x288ACE0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288ADC0 Offset: 0x288AEC1 VA: 0x288ADC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288AE00 Offset: 0x288AF01 VA: 0x288AE00
	public void .ctor() { }
}

