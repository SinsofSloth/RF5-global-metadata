[TaskCategoryAttribute] // RVA: 0x1550E0 Offset: 0x1551E1 VA: 0x1550E0
[TaskDescriptionAttribute] // RVA: 0x1550E0 Offset: 0x1551E1 VA: 0x1550E0
public class GetMaxDistance : Action // TypeDefIndex: 11351
{
	// Fields
	[TooltipAttribute] // RVA: 0x191C50 Offset: 0x191D51 VA: 0x191C50
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191C90 Offset: 0x191D91 VA: 0x191C90
	[RequiredFieldAttribute] // RVA: 0x191C90 Offset: 0x191D91 VA: 0x191C90
	public SharedFloat storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27962F0 Offset: 0x27963F1 VA: 0x27962F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27963F0 Offset: 0x27964F1 VA: 0x27963F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27964E0 Offset: 0x27965E1 VA: 0x27964E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2796530 Offset: 0x2796631 VA: 0x2796530
	public void .ctor() { }
}

