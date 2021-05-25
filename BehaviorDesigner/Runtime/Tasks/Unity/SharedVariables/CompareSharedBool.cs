[TaskCategoryAttribute] // RVA: 0x14E550 Offset: 0x14E651 VA: 0x14E550
[TaskDescriptionAttribute] // RVA: 0x14E550 Offset: 0x14E651 VA: 0x14E550
public class CompareSharedBool : Conditional // TypeDefIndex: 11060
{
	// Fields
	[TooltipAttribute] // RVA: 0x187A80 Offset: 0x187B81 VA: 0x187A80
	public SharedBool variable; // 0x50
	[TooltipAttribute] // RVA: 0x187AC0 Offset: 0x187BC1 VA: 0x187AC0
	public SharedBool compareTo; // 0x58

	// Methods

	// RVA: 0x20ECCA0 Offset: 0x20ECDA1 VA: 0x20ECCA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20ECD40 Offset: 0x20ECE41 VA: 0x20ECD40 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20ECE70 Offset: 0x20ECF71 VA: 0x20ECE70
	public void .ctor() { }
}

