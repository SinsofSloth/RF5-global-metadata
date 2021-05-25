[TaskCategoryAttribute] // RVA: 0x155620 Offset: 0x155721 VA: 0x155620
[TaskDescriptionAttribute] // RVA: 0x155620 Offset: 0x155721 VA: 0x155620
public class PlayScheduled : Action // TypeDefIndex: 11365
{
	// Fields
	[TooltipAttribute] // RVA: 0x192360 Offset: 0x192461 VA: 0x192360
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1923A0 Offset: 0x1924A1 VA: 0x1923A0
	public SharedFloat time; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2798340 Offset: 0x2798441 VA: 0x2798340 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2798440 Offset: 0x2798541 VA: 0x2798440 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2798540 Offset: 0x2798641 VA: 0x2798540 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2798590 Offset: 0x2798691 VA: 0x2798590
	public void .ctor() { }
}

