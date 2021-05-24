[TaskCategoryAttribute] // RVA: 0x154540 Offset: 0x154641 VA: 0x154540
[TaskDescriptionAttribute] // RVA: 0x154540 Offset: 0x154641 VA: 0x154540
public class GetStepOffset : Action // TypeDefIndex: 11320
{
	// Fields
	[TooltipAttribute] // RVA: 0x190C40 Offset: 0x190D41 VA: 0x190C40
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190C80 Offset: 0x190D81 VA: 0x190C80
	[RequiredFieldAttribute] // RVA: 0x190C80 Offset: 0x190D81 VA: 0x190C80
	public SharedFloat storeValue; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279DD20 Offset: 0x279DE21 VA: 0x279DD20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279DE20 Offset: 0x279DF21 VA: 0x279DE20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279DF10 Offset: 0x279E011 VA: 0x279DF10 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279DF60 Offset: 0x279E061 VA: 0x279DF60
	public void .ctor() { }
}

