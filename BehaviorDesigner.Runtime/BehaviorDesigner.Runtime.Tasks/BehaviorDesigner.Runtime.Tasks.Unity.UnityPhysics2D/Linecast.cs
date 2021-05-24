[TaskCategoryAttribute] // RVA: 0x151300 Offset: 0x151401 VA: 0x151300
[TaskDescriptionAttribute] // RVA: 0x151300 Offset: 0x151401 VA: 0x151300
public class Linecast : Action // TypeDefIndex: 11181
{
	// Fields
	[TooltipAttribute] // RVA: 0x18BF20 Offset: 0x18C021 VA: 0x18BF20
	public SharedVector2 startPosition; // 0x50
	[TooltipAttribute] // RVA: 0x18BF60 Offset: 0x18C061 VA: 0x18BF60
	public SharedVector2 endPosition; // 0x58
	[TooltipAttribute] // RVA: 0x18BFA0 Offset: 0x18C0A1 VA: 0x18BFA0
	public LayerMask layerMask; // 0x60

	// Methods

	// RVA: 0x287E840 Offset: 0x287E941 VA: 0x287E840 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287E960 Offset: 0x287EA61 VA: 0x287E960 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287EA10 Offset: 0x287EB11 VA: 0x287EA10
	public void .ctor() { }
}

