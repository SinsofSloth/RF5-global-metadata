[TaskCategoryAttribute] // RVA: 0x14E1F0 Offset: 0x14E2F1 VA: 0x14E1F0
[TaskDescriptionAttribute] // RVA: 0x14E1F0 Offset: 0x14E2F1 VA: 0x14E1F0
public class GetRandomString : Action // TypeDefIndex: 11051
{
	// Fields
	[TooltipAttribute] // RVA: 0x1874E0 Offset: 0x1875E1 VA: 0x1874E0
	public SharedString[] source; // 0x50
	[TooltipAttribute] // RVA: 0x187520 Offset: 0x187621 VA: 0x187520
	[RequiredFieldAttribute] // RVA: 0x187520 Offset: 0x187621 VA: 0x187520
	public SharedString storeResult; // 0x58

	// Methods

	// RVA: 0x288B3D0 Offset: 0x288B4D1 VA: 0x288B3D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288B490 Offset: 0x288B591 VA: 0x288B490 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288B4D0 Offset: 0x288B5D1 VA: 0x288B4D0
	public void .ctor() { }
}

