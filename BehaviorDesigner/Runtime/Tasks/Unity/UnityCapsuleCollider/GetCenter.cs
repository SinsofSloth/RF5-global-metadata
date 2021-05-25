[TaskCategoryAttribute] // RVA: 0x154960 Offset: 0x154A61 VA: 0x154960
[TaskDescriptionAttribute] // RVA: 0x154960 Offset: 0x154A61 VA: 0x154960
public class GetCenter : Action // TypeDefIndex: 11331
{
	// Fields
	[TooltipAttribute] // RVA: 0x1911E0 Offset: 0x1912E1 VA: 0x1911E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191220 Offset: 0x191321 VA: 0x191220
	[RequiredFieldAttribute] // RVA: 0x191220 Offset: 0x191321 VA: 0x191220
	public SharedVector3 storeValue; // 0x58
	private CapsuleCollider capsuleCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279C080 Offset: 0x279C181 VA: 0x279C080 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279C180 Offset: 0x279C281 VA: 0x279C180 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279C270 Offset: 0x279C371 VA: 0x279C270 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279C300 Offset: 0x279C401 VA: 0x279C300
	public void .ctor() { }
}

