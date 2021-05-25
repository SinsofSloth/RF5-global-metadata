[TaskCategoryAttribute] // RVA: 0x14F690 Offset: 0x14F791 VA: 0x14F690
[TaskDescriptionAttribute] // RVA: 0x14F690 Offset: 0x14F791 VA: 0x14F690
public class GetRotation : Action // TypeDefIndex: 11106
{
	// Fields
	[TooltipAttribute] // RVA: 0x1893B0 Offset: 0x1894B1 VA: 0x1893B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1893F0 Offset: 0x1894F1 VA: 0x1893F0
	[RequiredFieldAttribute] // RVA: 0x1893F0 Offset: 0x1894F1 VA: 0x1893F0
	public SharedFloat storeValue; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28880F0 Offset: 0x28881F1 VA: 0x28880F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28881F0 Offset: 0x28882F1 VA: 0x28881F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28882E0 Offset: 0x28883E1 VA: 0x28882E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2888330 Offset: 0x2888431 VA: 0x2888330
	public void .ctor() { }
}

