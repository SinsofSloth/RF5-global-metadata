[TaskCategoryAttribute] // RVA: 0x155680 Offset: 0x155781 VA: 0x155680
[TaskDescriptionAttribute] // RVA: 0x155680 Offset: 0x155781 VA: 0x155680
public class SetAudioClip : Action // TypeDefIndex: 11366
{
	// Fields
	[TooltipAttribute] // RVA: 0x1923E0 Offset: 0x1924E1 VA: 0x1923E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192420 Offset: 0x192521 VA: 0x192420
	public AudioClip audioClip; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27985D0 Offset: 0x27986D1 VA: 0x27985D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27986D0 Offset: 0x27987D1 VA: 0x27986D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27987B0 Offset: 0x27988B1 VA: 0x27987B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27987F0 Offset: 0x27988F1 VA: 0x27987F0
	public void .ctor() { }
}

