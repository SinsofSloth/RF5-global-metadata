public class DirectorControlPlayable : PlayableBehaviour // TypeDefIndex: 4604
{
	// Fields
	public PlayableDirector director; // 0x10
	private bool m_SyncTime; // 0x18
	private double m_AssetDuration; // 0x20

	// Methods

	// RVA: 0x17DD0E0 Offset: 0x17DD1E1 VA: 0x17DD0E0
	public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director) { }

	// RVA: 0x17DF270 Offset: 0x17DF371 VA: 0x17DF270 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x17DF350 Offset: 0x17DF451 VA: 0x17DF350 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x17DF7E0 Offset: 0x17DF8E1 VA: 0x17DF7E0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x17DF8D0 Offset: 0x17DF9D1 VA: 0x17DF8D0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x17DF9E0 Offset: 0x17DFAE1 VA: 0x17DF9E0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x17DF610 Offset: 0x17DF711 VA: 0x17DF610
	private void SyncSpeed(double speed) { }

	// RVA: 0x17DF740 Offset: 0x17DF841 VA: 0x17DF740
	private void SyncPlayState(PlayableGraph graph, double playableTime) { }

	// RVA: 0x17DF510 Offset: 0x17DF611 VA: 0x17DF510
	private bool DetectDiscontinuity(Playable playable, FrameData info) { }

	// RVA: 0x17DFB10 Offset: 0x17DFC11 VA: 0x17DFB10
	private bool DetectOutOfSync(Playable playable) { }

	// RVA: 0x17DFC60 Offset: 0x17DFD61 VA: 0x17DFC60
	private void UpdateTime(Playable playable) { }

	// RVA: 0x17DFE40 Offset: 0x17DFF41 VA: 0x17DFE40
	public void .ctor() { }
}

