[TaskCategoryAttribute] // RVA: 0x150520 Offset: 0x150621 VA: 0x150520
[TaskDescriptionAttribute] // RVA: 0x150520 Offset: 0x150621 VA: 0x150520
public class SetCenterOfMass : Action // TypeDefIndex: 11144
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A880 Offset: 0x18A981 VA: 0x18A880
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A8C0 Offset: 0x18A9C1 VA: 0x18A8C0
	public SharedVector3 centerOfMass; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2884A90 Offset: 0x2884B91 VA: 0x2884A90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2884B90 Offset: 0x2884C91 VA: 0x2884B90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2884C80 Offset: 0x2884D81 VA: 0x2884C80 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2884D10 Offset: 0x2884E11 VA: 0x2884D10
	public void .ctor() { }
}

