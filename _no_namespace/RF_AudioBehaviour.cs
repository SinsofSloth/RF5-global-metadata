[Serializable]
public class RF_AudioBehaviour : PlayableBehaviour // TypeDefIndex: 8360
{
	// Fields
	public SoundID SoundID; // 0x10
	[SerializeField] // RVA: 0x16F180 Offset: 0x16F281 VA: 0x16F180
	public string InputSoundIDString; // 0x18
	public Transform TargetTransform; // 0x20
	public bool IsLoop; // 0x28
	public float Volume; // 0x2C
	private AudioSourceController<SoundID> audioSourceController; // 0x30

	// Methods

	// RVA: 0x1DA9590 Offset: 0x1DA9691 VA: 0x1DA9590 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1DA9710 Offset: 0x1DA9811 VA: 0x1DA9710 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1DA97D0 Offset: 0x1DA98D1 VA: 0x1DA97D0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1DA9850 Offset: 0x1DA9951 VA: 0x1DA9850 Slot: 14
	public override void OnGraphStop(Playable playable) { }

	// RVA: 0x1DA98F0 Offset: 0x1DA99F1 VA: 0x1DA98F0
	public void .ctor() { }
}

