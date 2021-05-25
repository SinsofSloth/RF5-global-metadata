[TaskCategoryAttribute] // RVA: 0x14F2D0 Offset: 0x14F3D1 VA: 0x14F2D0
[TaskDescriptionAttribute] // RVA: 0x14F2D0 Offset: 0x14F3D1 VA: 0x14F2D0
public class AddForce : Action // TypeDefIndex: 11096
{
	// Fields
	[TooltipAttribute] // RVA: 0x188E00 Offset: 0x188F01 VA: 0x188E00
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x188E40 Offset: 0x188F41 VA: 0x188E40
	public SharedVector2 force; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28868B0 Offset: 0x28869B1 VA: 0x28868B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28869B0 Offset: 0x2886AB1 VA: 0x28869B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2886AA0 Offset: 0x2886BA1 VA: 0x2886AA0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2886B30 Offset: 0x2886C31 VA: 0x2886B30
	public void .ctor() { }
}

