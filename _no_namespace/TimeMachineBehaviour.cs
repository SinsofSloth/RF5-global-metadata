[Serializable]
public class TimeMachineBehaviour : PlayableBehaviour // TypeDefIndex: 8372
{
	// Fields
	public TimeMachineCondition condition; // 0x10
	public float timeOfLoopStart; // 0x14
	public float timeOfLoopEnd; // 0x18
	[HideInInspector] // RVA: 0x16F2C0 Offset: 0x16F3C1 VA: 0x16F2C0
	public bool clipExecuted; // 0x1C
	private PlayableDirector director; // 0x20

	// Methods

	// RVA: 0x1D16F10 Offset: 0x1D17011 VA: 0x1D16F10 Slot: 15
	public override void OnPlayableCreate(Playable playable) { }

	// RVA: 0x1D17000 Offset: 0x1D17101 VA: 0x1D17000 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1D170E0 Offset: 0x1D171E1 VA: 0x1D170E0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1D17220 Offset: 0x1D17321 VA: 0x1D17220
	public bool ConditionMet() { }

	// RVA: 0x1D17280 Offset: 0x1D17381 VA: 0x1D17280
	public void .ctor() { }
}

