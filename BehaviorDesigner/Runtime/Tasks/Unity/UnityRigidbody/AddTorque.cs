[TaskCategoryAttribute] // RVA: 0x14FE60 Offset: 0x14FF61 VA: 0x14FE60
[TaskDescriptionAttribute] // RVA: 0x14FE60 Offset: 0x14FF61 VA: 0x14FE60
public class AddTorque : Action // TypeDefIndex: 11126
{
	// Fields
	[TooltipAttribute] // RVA: 0x189F10 Offset: 0x18A011 VA: 0x189F10
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189F50 Offset: 0x18A051 VA: 0x189F50
	public SharedVector3 torque; // 0x58
	[TooltipAttribute] // RVA: 0x189F90 Offset: 0x18A091 VA: 0x189F90
	public ForceMode forceMode; // 0x60
	private Rigidbody rigidbody; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2881F00 Offset: 0x2882001 VA: 0x2881F00 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2882000 Offset: 0x2882101 VA: 0x2882000 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2882100 Offset: 0x2882201 VA: 0x2882100 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28821A0 Offset: 0x28822A1 VA: 0x28821A0
	public void .ctor() { }
}

