[TaskCategoryAttribute] // RVA: 0x1552C0 Offset: 0x1553C1 VA: 0x1552C0
[TaskDescriptionAttribute] // RVA: 0x1552C0 Offset: 0x1553C1 VA: 0x1552C0
public class GetSpread : Action // TypeDefIndex: 11356
{
	// Fields
	[TooltipAttribute] // RVA: 0x191F20 Offset: 0x192021 VA: 0x191F20
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191F60 Offset: 0x192061 VA: 0x191F60
	[RequiredFieldAttribute] // RVA: 0x191F60 Offset: 0x192061 VA: 0x191F60
	public SharedFloat storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2796EA0 Offset: 0x2796FA1 VA: 0x2796EA0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2796FA0 Offset: 0x27970A1 VA: 0x2796FA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2797090 Offset: 0x2797191 VA: 0x2797090 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27970E0 Offset: 0x27971E1 VA: 0x27970E0
	public void .ctor() { }
}

