[TaskCategoryAttribute] // RVA: 0x154BA0 Offset: 0x154CA1 VA: 0x154BA0
[TaskDescriptionAttribute] // RVA: 0x154BA0 Offset: 0x154CA1 VA: 0x154BA0
public class SetHeight : Action // TypeDefIndex: 11337
{
	// Fields
	[TooltipAttribute] // RVA: 0x191520 Offset: 0x191621 VA: 0x191520
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191560 Offset: 0x191661 VA: 0x191560
	public SharedFloat direction; // 0x58
	private CapsuleCollider capsuleCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279CF00 Offset: 0x279D001 VA: 0x279CF00 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279D000 Offset: 0x279D101 VA: 0x279D000 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279D0F0 Offset: 0x279D1F1 VA: 0x279D0F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279D140 Offset: 0x279D241 VA: 0x279D140
	public void .ctor() { }
}

