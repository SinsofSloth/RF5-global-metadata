[TaskCategoryAttribute] // RVA: 0x1545A0 Offset: 0x1546A1 VA: 0x1545A0
[TaskDescriptionAttribute] // RVA: 0x1545A0 Offset: 0x1546A1 VA: 0x1545A0
public class GetVelocity : Action // TypeDefIndex: 11321
{
	// Fields
	[TooltipAttribute] // RVA: 0x190CD0 Offset: 0x190DD1 VA: 0x190CD0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190D10 Offset: 0x190E11 VA: 0x190D10
	[RequiredFieldAttribute] // RVA: 0x190D10 Offset: 0x190E11 VA: 0x190D10
	public SharedVector3 storeValue; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279DF70 Offset: 0x279E071 VA: 0x279DF70 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279E070 Offset: 0x279E171 VA: 0x279E070 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279E160 Offset: 0x279E261 VA: 0x279E160 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279E1F0 Offset: 0x279E2F1 VA: 0x279E1F0
	public void .ctor() { }
}

