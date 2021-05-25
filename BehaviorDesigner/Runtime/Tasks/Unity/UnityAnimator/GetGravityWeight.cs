[TaskCategoryAttribute] // RVA: 0x155F20 Offset: 0x156021 VA: 0x155F20
[TaskDescriptionAttribute] // RVA: 0x155F20 Offset: 0x156021 VA: 0x155F20
public class GetGravityWeight : Action // TypeDefIndex: 11389
{
	// Fields
	[TooltipAttribute] // RVA: 0x1930B0 Offset: 0x1931B1 VA: 0x1930B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1930F0 Offset: 0x1931F1 VA: 0x1930F0
	[RequiredFieldAttribute] // RVA: 0x1930F0 Offset: 0x1931F1 VA: 0x1930F0
	public SharedFloat storeValue; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27914A0 Offset: 0x27915A1 VA: 0x27914A0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27915A0 Offset: 0x27916A1 VA: 0x27915A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2791690 Offset: 0x2791791 VA: 0x2791690 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27916E0 Offset: 0x27917E1 VA: 0x27916E0
	public void .ctor() { }
}

