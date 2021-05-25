[TaskCategoryAttribute] // RVA: 0x155380 Offset: 0x155481 VA: 0x155380
[TaskDescriptionAttribute] // RVA: 0x155380 Offset: 0x155481 VA: 0x155380
public class GetTimeSamples : Action // TypeDefIndex: 11358
{
	// Fields
	[TooltipAttribute] // RVA: 0x192040 Offset: 0x192141 VA: 0x192040
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192080 Offset: 0x192181 VA: 0x192080
	[RequiredFieldAttribute] // RVA: 0x192080 Offset: 0x192181 VA: 0x192080
	public SharedFloat storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2797340 Offset: 0x2797441 VA: 0x2797340 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2797440 Offset: 0x2797541 VA: 0x2797440 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2797540 Offset: 0x2797641 VA: 0x2797540 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2797590 Offset: 0x2797691 VA: 0x2797590
	public void .ctor() { }
}

