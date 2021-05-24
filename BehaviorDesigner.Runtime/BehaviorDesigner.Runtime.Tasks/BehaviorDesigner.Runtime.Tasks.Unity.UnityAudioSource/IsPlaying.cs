[TaskCategoryAttribute] // RVA: 0x155440 Offset: 0x155541 VA: 0x155440
[TaskDescriptionAttribute] // RVA: 0x155440 Offset: 0x155541 VA: 0x155440
public class IsPlaying : Conditional // TypeDefIndex: 11360
{
	// Fields
	[TooltipAttribute] // RVA: 0x192160 Offset: 0x192261 VA: 0x192160
	public SharedGameObject targetGameObject; // 0x50
	private AudioSource audioSource; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x27977F0 Offset: 0x27978F1 VA: 0x27977F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27978F0 Offset: 0x27979F1 VA: 0x27978F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27979D0 Offset: 0x2797AD1 VA: 0x27979D0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27979E0 Offset: 0x2797AE1 VA: 0x27979E0
	public void .ctor() { }
}

