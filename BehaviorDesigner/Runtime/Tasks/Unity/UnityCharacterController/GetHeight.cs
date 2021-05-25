[TaskCategoryAttribute] // RVA: 0x154420 Offset: 0x154521 VA: 0x154420
[TaskDescriptionAttribute] // RVA: 0x154420 Offset: 0x154521 VA: 0x154420
public class GetHeight : Action // TypeDefIndex: 11317
{
	// Fields
	[TooltipAttribute] // RVA: 0x190A90 Offset: 0x190B91 VA: 0x190A90
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190AD0 Offset: 0x190BD1 VA: 0x190AD0
	[RequiredFieldAttribute] // RVA: 0x190AD0 Offset: 0x190BD1 VA: 0x190AD0
	public SharedFloat storeValue; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279D630 Offset: 0x279D731 VA: 0x279D630 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279D730 Offset: 0x279D831 VA: 0x279D730 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279D820 Offset: 0x279D921 VA: 0x279D820 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279D870 Offset: 0x279D971 VA: 0x279D870
	public void .ctor() { }
}

