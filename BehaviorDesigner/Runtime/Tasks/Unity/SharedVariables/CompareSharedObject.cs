[TaskCategoryAttribute] // RVA: 0x14E790 Offset: 0x14E891 VA: 0x14E790
[TaskDescriptionAttribute] // RVA: 0x14E790 Offset: 0x14E891 VA: 0x14E790
public class CompareSharedObject : Conditional // TypeDefIndex: 11066
{
	// Fields
	[TooltipAttribute] // RVA: 0x187D80 Offset: 0x187E81 VA: 0x187D80
	public SharedObject variable; // 0x50
	[TooltipAttribute] // RVA: 0x187DC0 Offset: 0x187EC1 VA: 0x187DC0
	public SharedObject compareTo; // 0x58

	// Methods

	// RVA: 0x20ED8C0 Offset: 0x20ED9C1 VA: 0x20ED8C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EDA90 Offset: 0x20EDB91 VA: 0x20EDA90 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EDAD0 Offset: 0x20EDBD1 VA: 0x20EDAD0
	public void .ctor() { }
}

