[TaskCategoryAttribute] // RVA: 0x154D20 Offset: 0x154E21 VA: 0x154D20
[TaskDescriptionAttribute] // RVA: 0x154D20 Offset: 0x154E21 VA: 0x154D20
public class GetCenter : Action // TypeDefIndex: 11341
{
	// Fields
	[TooltipAttribute] // RVA: 0x191730 Offset: 0x191831 VA: 0x191730
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191770 Offset: 0x191871 VA: 0x191770
	[RequiredFieldAttribute] // RVA: 0x191770 Offset: 0x191871 VA: 0x191770
	public SharedVector3 storeValue; // 0x58
	private BoxCollider boxCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279B120 Offset: 0x279B221 VA: 0x279B120 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279B220 Offset: 0x279B321 VA: 0x279B220 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279B310 Offset: 0x279B411 VA: 0x279B310 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279B3A0 Offset: 0x279B4A1 VA: 0x279B3A0
	public void .ctor() { }
}

