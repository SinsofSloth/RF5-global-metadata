[TaskCategoryAttribute] // RVA: 0x14E0D0 Offset: 0x14E1D1 VA: 0x14E0D0
[TaskDescriptionAttribute] // RVA: 0x14E0D0 Offset: 0x14E1D1 VA: 0x14E0D0
public class CompareTo : Action // TypeDefIndex: 11048
{
	// Fields
	[TooltipAttribute] // RVA: 0x1872B0 Offset: 0x1873B1 VA: 0x1872B0
	public SharedString firstString; // 0x50
	[TooltipAttribute] // RVA: 0x1872F0 Offset: 0x1873F1 VA: 0x1872F0
	public SharedString secondString; // 0x58
	[TooltipAttribute] // RVA: 0x187330 Offset: 0x187431 VA: 0x187330
	[RequiredFieldAttribute] // RVA: 0x187330 Offset: 0x187431 VA: 0x187330
	public SharedInt storeResult; // 0x60

	// Methods

	// RVA: 0x288AE10 Offset: 0x288AF11 VA: 0x288AE10 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288AEC0 Offset: 0x288AFC1 VA: 0x288AEC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288AF60 Offset: 0x288B061 VA: 0x288AF60
	public void .ctor() { }
}

