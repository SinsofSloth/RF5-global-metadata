[TaskCategoryAttribute] // RVA: 0x14F330 Offset: 0x14F431 VA: 0x14F330
[TaskDescriptionAttribute] // RVA: 0x14F330 Offset: 0x14F431 VA: 0x14F330
public class AddForceAtPosition : Action // TypeDefIndex: 11097
{
	// Fields
	[TooltipAttribute] // RVA: 0x188E80 Offset: 0x188F81 VA: 0x188E80
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x188EC0 Offset: 0x188FC1 VA: 0x188EC0
	public SharedVector2 force; // 0x58
	[TooltipAttribute] // RVA: 0x188F00 Offset: 0x189001 VA: 0x188F00
	public SharedVector2 position; // 0x60
	private Rigidbody2D rigidbody2D; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2886B40 Offset: 0x2886C41 VA: 0x2886B40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2886C40 Offset: 0x2886D41 VA: 0x2886C40 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2886D60 Offset: 0x2886E61 VA: 0x2886D60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2886E10 Offset: 0x2886F11 VA: 0x2886E10
	public void .ctor() { }
}

