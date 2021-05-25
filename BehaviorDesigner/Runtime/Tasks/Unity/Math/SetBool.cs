[TaskCategoryAttribute] // RVA: 0x152CE0 Offset: 0x152DE1 VA: 0x152CE0
[TaskDescriptionAttribute] // RVA: 0x152CE0 Offset: 0x152DE1 VA: 0x152CE0
public class SetBool : Action // TypeDefIndex: 11255
{
	// Fields
	[TooltipAttribute] // RVA: 0x18EA40 Offset: 0x18EB41 VA: 0x18EA40
	public SharedBool boolValue; // 0x50
	[TooltipAttribute] // RVA: 0x18EA80 Offset: 0x18EB81 VA: 0x18EA80
	public SharedBool storeResult; // 0x58

	// Methods

	// RVA: 0x20EC7C0 Offset: 0x20EC8C1 VA: 0x20EC7C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EC840 Offset: 0x20EC941 VA: 0x20EC840 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EC8F0 Offset: 0x20EC9F1 VA: 0x20EC8F0
	public void .ctor() { }
}

