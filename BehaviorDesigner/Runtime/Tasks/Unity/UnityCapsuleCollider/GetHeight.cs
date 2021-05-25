[TaskCategoryAttribute] // RVA: 0x154A20 Offset: 0x154B21 VA: 0x154A20
[TaskDescriptionAttribute] // RVA: 0x154A20 Offset: 0x154B21 VA: 0x154A20
public class GetHeight : Action // TypeDefIndex: 11333
{
	// Fields
	[TooltipAttribute] // RVA: 0x191300 Offset: 0x191401 VA: 0x191300
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191340 Offset: 0x191441 VA: 0x191340
	[RequiredFieldAttribute] // RVA: 0x191340 Offset: 0x191441 VA: 0x191340
	public SharedFloat storeValue; // 0x58
	private CapsuleCollider capsuleCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279C570 Offset: 0x279C671 VA: 0x279C570 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279C670 Offset: 0x279C771 VA: 0x279C670 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279C760 Offset: 0x279C861 VA: 0x279C760 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279C7B0 Offset: 0x279C8B1 VA: 0x279C7B0
	public void .ctor() { }
}

