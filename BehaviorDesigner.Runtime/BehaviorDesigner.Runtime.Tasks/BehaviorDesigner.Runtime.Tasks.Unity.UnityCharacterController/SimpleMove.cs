[TaskCategoryAttribute] // RVA: 0x154900 Offset: 0x154A01 VA: 0x154900
[TaskDescriptionAttribute] // RVA: 0x154900 Offset: 0x154A01 VA: 0x154900
public class SimpleMove : Action // TypeDefIndex: 11330
{
	// Fields
	[TooltipAttribute] // RVA: 0x191160 Offset: 0x191261 VA: 0x191160
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1911A0 Offset: 0x1912A1 VA: 0x1911A0
	public SharedVector3 speed; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279F480 Offset: 0x279F581 VA: 0x279F480 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279F580 Offset: 0x279F681 VA: 0x279F580 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279F670 Offset: 0x279F771 VA: 0x279F670 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279F700 Offset: 0x279F801 VA: 0x279F700
	public void .ctor() { }
}

