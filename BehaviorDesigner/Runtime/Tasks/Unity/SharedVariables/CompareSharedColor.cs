[TaskCategoryAttribute] // RVA: 0x14E5B0 Offset: 0x14E6B1 VA: 0x14E5B0
[TaskDescriptionAttribute] // RVA: 0x14E5B0 Offset: 0x14E6B1 VA: 0x14E5B0
public class CompareSharedColor : Conditional // TypeDefIndex: 11061
{
	// Fields
	[TooltipAttribute] // RVA: 0x187B00 Offset: 0x187C01 VA: 0x187B00
	public SharedColor variable; // 0x50
	[TooltipAttribute] // RVA: 0x187B40 Offset: 0x187C41 VA: 0x187B40
	public SharedColor compareTo; // 0x58

	// Methods

	// RVA: 0x20ECE80 Offset: 0x20ECF81 VA: 0x20ECE80 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20ECF20 Offset: 0x20ED021 VA: 0x20ECF20 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20ED090 Offset: 0x20ED191 VA: 0x20ED090
	public void .ctor() { }
}

