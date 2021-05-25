[TaskCategoryAttribute] // RVA: 0x150460 Offset: 0x150561 VA: 0x150460
[TaskDescriptionAttribute] // RVA: 0x150460 Offset: 0x150561 VA: 0x150460
public class SetAngularDrag : Action // TypeDefIndex: 11142
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A780 Offset: 0x18A881 VA: 0x18A780
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A7C0 Offset: 0x18A8C1 VA: 0x18A7C0
	public SharedFloat angularDrag; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28845B0 Offset: 0x28846B1 VA: 0x28845B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28846B0 Offset: 0x28847B1 VA: 0x28846B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28847A0 Offset: 0x28848A1 VA: 0x28847A0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28847F0 Offset: 0x28848F1 VA: 0x28847F0
	public void .ctor() { }
}

