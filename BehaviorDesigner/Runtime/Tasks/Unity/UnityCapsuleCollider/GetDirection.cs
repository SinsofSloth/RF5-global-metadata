[TaskCategoryAttribute] // RVA: 0x1549C0 Offset: 0x154AC1 VA: 0x1549C0
[TaskDescriptionAttribute] // RVA: 0x1549C0 Offset: 0x154AC1 VA: 0x1549C0
public class GetDirection : Action // TypeDefIndex: 11332
{
	// Fields
	[TooltipAttribute] // RVA: 0x191270 Offset: 0x191371 VA: 0x191270
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1912B0 Offset: 0x1913B1 VA: 0x1912B0
	[RequiredFieldAttribute] // RVA: 0x1912B0 Offset: 0x1913B1 VA: 0x1912B0
	public SharedInt storeValue; // 0x58
	private CapsuleCollider capsuleCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279C310 Offset: 0x279C411 VA: 0x279C310 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279C410 Offset: 0x279C511 VA: 0x279C410 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279C510 Offset: 0x279C611 VA: 0x279C510 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279C560 Offset: 0x279C661 VA: 0x279C560
	public void .ctor() { }
}

