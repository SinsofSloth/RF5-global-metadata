[TaskCategoryAttribute] // RVA: 0x155560 Offset: 0x155661 VA: 0x155560
[TaskDescriptionAttribute] // RVA: 0x155560 Offset: 0x155661 VA: 0x155560
public class PlayDelayed : Action // TypeDefIndex: 11363
{
	// Fields
	[TooltipAttribute] // RVA: 0x192220 Offset: 0x192321 VA: 0x192220
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192260 Offset: 0x192361 VA: 0x192260
	public SharedFloat delay; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2797DF0 Offset: 0x2797EF1 VA: 0x2797DF0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2797EF0 Offset: 0x2797FF1 VA: 0x2797EF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2797FE0 Offset: 0x27980E1 VA: 0x2797FE0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2798030 Offset: 0x2798131 VA: 0x2798030
	public void .ctor() { }
}

