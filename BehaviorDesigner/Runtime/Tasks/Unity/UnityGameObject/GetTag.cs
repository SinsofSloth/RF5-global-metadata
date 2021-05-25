[TaskCategoryAttribute] // RVA: 0x153E20 Offset: 0x153F21 VA: 0x153E20
[TaskDescriptionAttribute] // RVA: 0x153E20 Offset: 0x153F21 VA: 0x153E20
public class GetTag : Action // TypeDefIndex: 11301
{
	// Fields
	[TooltipAttribute] // RVA: 0x1900B0 Offset: 0x1901B1 VA: 0x1900B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1900F0 Offset: 0x1901F1 VA: 0x1900F0
	[RequiredFieldAttribute] // RVA: 0x1900F0 Offset: 0x1901F1 VA: 0x1900F0
	public SharedString storeValue; // 0x58

	// Methods

	// RVA: 0x27A1760 Offset: 0x27A1861 VA: 0x27A1760 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A1800 Offset: 0x27A1901 VA: 0x27A1800 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A1870 Offset: 0x27A1971 VA: 0x27A1870
	public void .ctor() { }
}

