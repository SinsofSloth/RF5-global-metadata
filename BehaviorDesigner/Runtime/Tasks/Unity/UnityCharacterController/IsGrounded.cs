[TaskCategoryAttribute] // RVA: 0x154660 Offset: 0x154761 VA: 0x154660
[TaskDescriptionAttribute] // RVA: 0x154660 Offset: 0x154761 VA: 0x154660
public class IsGrounded : Conditional // TypeDefIndex: 11323
{
	// Fields
	[TooltipAttribute] // RVA: 0x190E20 Offset: 0x190F21 VA: 0x190E20
	public SharedGameObject targetGameObject; // 0x50
	private CharacterController characterController; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x279E420 Offset: 0x279E521 VA: 0x279E420 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279E520 Offset: 0x279E621 VA: 0x279E520 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279E600 Offset: 0x279E701 VA: 0x279E600 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279E610 Offset: 0x279E711 VA: 0x279E610
	public void .ctor() { }
}

