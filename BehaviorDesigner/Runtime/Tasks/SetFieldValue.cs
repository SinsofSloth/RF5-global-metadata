[TaskDescriptionAttribute] // RVA: 0x14B440 Offset: 0x14B541 VA: 0x14B440
[TaskCategoryAttribute] // RVA: 0x14B440 Offset: 0x14B541 VA: 0x14B440
[TaskIconAttribute] // RVA: 0x14B440 Offset: 0x14B541 VA: 0x14B440
public class SetFieldValue : Action // TypeDefIndex: 10929
{
	// Fields
	[TooltipAttribute] // RVA: 0x182FB0 Offset: 0x1830B1 VA: 0x182FB0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x182FF0 Offset: 0x1830F1 VA: 0x182FF0
	public SharedString componentName; // 0x58
	[TooltipAttribute] // RVA: 0x183030 Offset: 0x183131 VA: 0x183030
	public SharedString fieldName; // 0x60
	[TooltipAttribute] // RVA: 0x183070 Offset: 0x183171 VA: 0x183070
	public SharedVariable fieldValue; // 0x68

	// Methods

	// RVA: 0x20E8140 Offset: 0x20E8241 VA: 0x20E8140 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E83C0 Offset: 0x20E84C1 VA: 0x20E83C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E8420 Offset: 0x20E8521 VA: 0x20E8420
	public void .ctor() { }
}

