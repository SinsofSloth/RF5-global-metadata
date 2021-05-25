[TaskCategoryAttribute] // RVA: 0x1505E0 Offset: 0x1506E1 VA: 0x1505E0
[TaskDescriptionAttribute] // RVA: 0x1505E0 Offset: 0x1506E1 VA: 0x1505E0
public class SetDrag : Action // TypeDefIndex: 11146
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A980 Offset: 0x18AA81 VA: 0x18A980
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A9C0 Offset: 0x18AAC1 VA: 0x18A9C0
	public SharedFloat drag; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2884F40 Offset: 0x2885041 VA: 0x2884F40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2885040 Offset: 0x2885141 VA: 0x2885040 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2885130 Offset: 0x2885231 VA: 0x2885130 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2885180 Offset: 0x2885281 VA: 0x2885180
	public void .ctor() { }
}

