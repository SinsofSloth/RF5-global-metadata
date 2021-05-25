[TaskCategoryAttribute] // RVA: 0x154C60 Offset: 0x154D61 VA: 0x154C60
[TaskDescriptionAttribute] // RVA: 0x154C60 Offset: 0x154D61 VA: 0x154C60
public class GetSize : Action // TypeDefIndex: 11339
{
	// Fields
	[TooltipAttribute] // RVA: 0x191620 Offset: 0x191721 VA: 0x191620
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191660 Offset: 0x191761 VA: 0x191660
	[RequiredFieldAttribute] // RVA: 0x191660 Offset: 0x191761 VA: 0x191660
	public SharedVector2 storeValue; // 0x58
	private BoxCollider2D boxCollider2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279BB60 Offset: 0x279BC61 VA: 0x279BB60 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279BC60 Offset: 0x279BD61 VA: 0x279BC60 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279BD50 Offset: 0x279BE51 VA: 0x279BD50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279BDE0 Offset: 0x279BEE1 VA: 0x279BDE0
	public void .ctor() { }
}

