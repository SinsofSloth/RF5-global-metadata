[TaskCategoryAttribute] // RVA: 0x154720 Offset: 0x154821 VA: 0x154720
[TaskDescriptionAttribute] // RVA: 0x154720 Offset: 0x154821 VA: 0x154720
public class SetCenter : Action // TypeDefIndex: 11325
{
	// Fields
	[TooltipAttribute] // RVA: 0x190EE0 Offset: 0x190FE1 VA: 0x190EE0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190F20 Offset: 0x191021 VA: 0x190F20
	public SharedVector3 center; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279E8B0 Offset: 0x279E9B1 VA: 0x279E8B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279E9B0 Offset: 0x279EAB1 VA: 0x279E9B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279EAA0 Offset: 0x279EBA1 VA: 0x279EAA0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279EB30 Offset: 0x279EC31 VA: 0x279EB30
	public void .ctor() { }
}

