public class ActivationControlPlayable : PlayableBehaviour // TypeDefIndex: 4600
{
	// Fields
	public GameObject gameObject; // 0x10
	public ActivationControlPlayable.PostPlaybackState postPlayback; // 0x18
	private ActivationControlPlayable.InitialState m_InitialState; // 0x1C

	// Methods

	// RVA: 0x17D20B0 Offset: 0x17D21B1 VA: 0x17D20B0
	public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, ActivationControlPlayable.PostPlaybackState postPlaybackState) { }

	// RVA: 0x17D21F0 Offset: 0x17D22F1 VA: 0x17D21F0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x17D2290 Offset: 0x17D2391 VA: 0x17D2290 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x17D2350 Offset: 0x17D2451 VA: 0x17D2350 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object userData) { }

	// RVA: 0x17D23F0 Offset: 0x17D24F1 VA: 0x17D23F0 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x17D24A0 Offset: 0x17D25A1 VA: 0x17D24A0 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x17D25A0 Offset: 0x17D26A1 VA: 0x17D25A0
	public void .ctor() { }
}

