[TaskCategoryAttribute] // RVA: 0x14FAB0 Offset: 0x14FBB1 VA: 0x14FAB0
[TaskDescriptionAttribute] // RVA: 0x14FAB0 Offset: 0x14FBB1 VA: 0x14FAB0
public class SetMass : Action // TypeDefIndex: 11117
{
	// Fields
	[TooltipAttribute] // RVA: 0x1898D0 Offset: 0x1899D1 VA: 0x1898D0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189910 Offset: 0x189A11 VA: 0x189910
	public SharedFloat mass; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2889A50 Offset: 0x2889B51 VA: 0x2889A50 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2889B50 Offset: 0x2889C51 VA: 0x2889B50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2889C40 Offset: 0x2889D41 VA: 0x2889C40 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2889C90 Offset: 0x2889D91 VA: 0x2889C90
	public void .ctor() { }
}

