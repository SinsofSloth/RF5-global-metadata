[TaskCategoryAttribute] // RVA: 0x150160 Offset: 0x150261 VA: 0x150160
[TaskDescriptionAttribute] // RVA: 0x150160 Offset: 0x150261 VA: 0x150160
public class GetPosition : Action // TypeDefIndex: 11134
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A3C0 Offset: 0x18A4C1 VA: 0x18A3C0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A400 Offset: 0x18A501 VA: 0x18A400
	[RequiredFieldAttribute] // RVA: 0x18A400 Offset: 0x18A501 VA: 0x18A400
	public SharedVector3 storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2883280 Offset: 0x2883381 VA: 0x2883280 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2883380 Offset: 0x2883481 VA: 0x2883380 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2883470 Offset: 0x2883571 VA: 0x2883470 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2883500 Offset: 0x2883601 VA: 0x2883500
	public void .ctor() { }
}

