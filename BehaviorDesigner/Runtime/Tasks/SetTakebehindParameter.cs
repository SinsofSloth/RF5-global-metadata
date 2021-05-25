[TaskDescriptionAttribute] // RVA: 0x14AE00 Offset: 0x14AF01 VA: 0x14AE00
[TaskCategoryAttribute] // RVA: 0x14AE00 Offset: 0x14AF01 VA: 0x14AE00
[TaskIconAttribute] // RVA: 0x14AE00 Offset: 0x14AF01 VA: 0x14AE00
public class SetTakebehindParameter : Action // TypeDefIndex: 10914
{
	// Fields
	[TooltipAttribute] // RVA: 0x182510 Offset: 0x182611 VA: 0x182510
	public SharedGameObject Target; // 0x50
	[TooltipAttribute] // RVA: 0x182550 Offset: 0x182651 VA: 0x182550
	public SharedFloat TakebehindRange; // 0x58
	[TooltipAttribute] // RVA: 0x182590 Offset: 0x182691 VA: 0x182590
	public SharedVector3 MovePosition; // 0x60

	// Methods

	// RVA: 0x20E8860 Offset: 0x20E8961 VA: 0x20E8860 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E8AC0 Offset: 0x20E8BC1 VA: 0x20E8AC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E8AD0 Offset: 0x20E8BD1 VA: 0x20E8AD0
	public void .ctor() { }
}

