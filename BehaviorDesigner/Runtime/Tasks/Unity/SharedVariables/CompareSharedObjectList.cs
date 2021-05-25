[TaskCategoryAttribute] // RVA: 0x14E7F0 Offset: 0x14E8F1 VA: 0x14E7F0
[TaskDescriptionAttribute] // RVA: 0x14E7F0 Offset: 0x14E8F1 VA: 0x14E7F0
public class CompareSharedObjectList : Conditional // TypeDefIndex: 11067
{
	// Fields
	[TooltipAttribute] // RVA: 0x187E00 Offset: 0x187F01 VA: 0x187E00
	public SharedObjectList variable; // 0x50
	[TooltipAttribute] // RVA: 0x187E40 Offset: 0x187F41 VA: 0x187E40
	public SharedObjectList compareTo; // 0x58

	// Methods

	// RVA: 0x20EDAE0 Offset: 0x20EDBE1 VA: 0x20EDAE0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EDCB0 Offset: 0x20EDDB1 VA: 0x20EDCB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EDCF0 Offset: 0x20EDDF1 VA: 0x20EDCF0
	public void .ctor() { }
}

