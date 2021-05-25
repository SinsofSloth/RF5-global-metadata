[TaskCategoryAttribute] // RVA: 0x150760 Offset: 0x150861 VA: 0x150760
[TaskDescriptionAttribute] // RVA: 0x150760 Offset: 0x150861 VA: 0x150760
public class SetPosition : Action // TypeDefIndex: 11150
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AB80 Offset: 0x18AC81 VA: 0x18AB80
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18ABC0 Offset: 0x18ACC1 VA: 0x18ABC0
	public SharedVector3 position; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28858A0 Offset: 0x28859A1 VA: 0x28858A0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28859A0 Offset: 0x2885AA1 VA: 0x28859A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2885A90 Offset: 0x2885B91 VA: 0x2885A90 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2885B20 Offset: 0x2885C21 VA: 0x2885B20
	public void .ctor() { }
}

