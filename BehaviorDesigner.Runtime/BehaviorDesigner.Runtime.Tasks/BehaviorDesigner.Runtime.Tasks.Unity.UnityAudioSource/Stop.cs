[TaskCategoryAttribute] // RVA: 0x155C80 Offset: 0x155D81 VA: 0x155C80
[TaskDescriptionAttribute] // RVA: 0x155C80 Offset: 0x155D81 VA: 0x155C80
public class Stop : Action // TypeDefIndex: 11382
{
	// Fields
	[TooltipAttribute] // RVA: 0x192BE0 Offset: 0x192CE1 VA: 0x192BE0
	public SharedGameObject targetGameObject; // 0x50
	private AudioSource audioSource; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x279AB20 Offset: 0x279AC21 VA: 0x279AB20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279AC20 Offset: 0x279AD21 VA: 0x279AC20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279AD00 Offset: 0x279AE01 VA: 0x279AD00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279AD10 Offset: 0x279AE11 VA: 0x279AD10
	public void .ctor() { }
}

