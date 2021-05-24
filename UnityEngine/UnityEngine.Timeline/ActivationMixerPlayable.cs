internal class ActivationMixerPlayable : PlayableBehaviour // TypeDefIndex: 4526
{
	// Fields
	private ActivationTrack.PostPlaybackState m_PostPlaybackState; // 0x10
	private bool m_BoundGameObjectInitialStateIsActive; // 0x14
	private GameObject m_BoundGameObject; // 0x18

	// Properties
	public ActivationTrack.PostPlaybackState postPlaybackState { get; set; }

	// Methods

	// RVA: 0x17D25B0 Offset: 0x17D26B1 VA: 0x17D25B0
	public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount) { }

	// RVA: 0x17D2640 Offset: 0x17D2741 VA: 0x17D2640
	public ActivationTrack.PostPlaybackState get_postPlaybackState() { }

	// RVA: 0x17D2650 Offset: 0x17D2751 VA: 0x17D2650
	public void set_postPlaybackState(ActivationTrack.PostPlaybackState value) { }

	// RVA: 0x17D2660 Offset: 0x17D2761 VA: 0x17D2660 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x17D2750 Offset: 0x17D2851 VA: 0x17D2750 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x17D2930 Offset: 0x17D2A31 VA: 0x17D2930
	public void .ctor() { }
}

