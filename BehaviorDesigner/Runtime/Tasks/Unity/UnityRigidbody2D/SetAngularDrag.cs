[TaskCategoryAttribute] // RVA: 0x14F8D0 Offset: 0x14F9D1 VA: 0x14F8D0
[TaskDescriptionAttribute] // RVA: 0x14F8D0 Offset: 0x14F9D1 VA: 0x14F8D0
public class SetAngularDrag : Action // TypeDefIndex: 11112
{
	// Fields
	[TooltipAttribute] // RVA: 0x189650 Offset: 0x189751 VA: 0x189650
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189690 Offset: 0x189791 VA: 0x189690
	public SharedFloat angularDrag; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2888EB0 Offset: 0x2888FB1 VA: 0x2888EB0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2888FB0 Offset: 0x28890B1 VA: 0x2888FB0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28890A0 Offset: 0x28891A1 VA: 0x28890A0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28890F0 Offset: 0x28891F1 VA: 0x28890F0
	public void .ctor() { }
}

