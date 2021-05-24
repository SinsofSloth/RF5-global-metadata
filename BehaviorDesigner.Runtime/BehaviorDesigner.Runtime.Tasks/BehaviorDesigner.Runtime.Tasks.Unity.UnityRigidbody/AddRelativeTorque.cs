[TaskCategoryAttribute] // RVA: 0x14FE00 Offset: 0x14FF01 VA: 0x14FE00
[TaskDescriptionAttribute] // RVA: 0x14FE00 Offset: 0x14FF01 VA: 0x14FE00
public class AddRelativeTorque : Action // TypeDefIndex: 11125
{
	// Fields
	[TooltipAttribute] // RVA: 0x189E50 Offset: 0x189F51 VA: 0x189E50
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189E90 Offset: 0x189F91 VA: 0x189E90
	public SharedVector3 torque; // 0x58
	[TooltipAttribute] // RVA: 0x189ED0 Offset: 0x189FD1 VA: 0x189ED0
	public ForceMode forceMode; // 0x60
	private Rigidbody rigidbody; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2881CD0 Offset: 0x2881DD1 VA: 0x2881CD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2881DD0 Offset: 0x2881ED1 VA: 0x2881DD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2881E50 Offset: 0x2881F51 VA: 0x2881E50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2881EF0 Offset: 0x2881FF1 VA: 0x2881EF0
	public void .ctor() { }
}

