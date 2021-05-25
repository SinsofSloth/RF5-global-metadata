public class TimelinePlayable : PlayableBehaviour // TypeDefIndex: 4628
{
	// Fields
	private IntervalTree<RuntimeElement> m_IntervalTree; // 0x10
	private List<RuntimeElement> m_ActiveClips; // 0x18
	private List<RuntimeElement> m_CurrentListOfActiveClips; // 0x20
	private int m_ActiveBit; // 0x28
	private List<ITimelineEvaluateCallback> m_EvaluateCallbacks; // 0x30
	private Dictionary<TrackAsset, Playable> m_PlayableCache; // 0x38
	internal static bool muteAudioScrubbing; // 0x0

	// Methods

	// RVA: 0x1B3BEC0 Offset: 0x1B3BFC1 VA: 0x1B3BEC0
	public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	// RVA: 0x1B3C090 Offset: 0x1B3C191 VA: 0x1B3C090
	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	// RVA: 0x1B3C2C0 Offset: 0x1B3C3C1 VA: 0x1B3C2C0
	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs) { }

	// RVA: 0x1B3CF50 Offset: 0x1B3D051 VA: 0x1B3CF50
	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) { }

	// RVA: 0x1B3D6D0 Offset: 0x1B3D7D1 VA: 0x1B3D6D0
	private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput) { }

	// RVA: 0x1B3D770 Offset: 0x1B3D871 VA: 0x1B3D770
	private void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput) { }

	// RVA: 0x1B3D810 Offset: 0x1B3D911 VA: 0x1B3D810
	private static Playable CreatePlayableGraph(PlayableGraph graph, TrackAsset asset, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) { }

	// RVA: 0x1B3CAC0 Offset: 0x1B3CBC1 VA: 0x1B3CAC0
	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) { }

	// RVA: 0x1B3DB90 Offset: 0x1B3DC91 VA: 0x1B3DB90 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1B3DBD0 Offset: 0x1B3DCD1 VA: 0x1B3DBD0
	private void Evaluate(Playable playable, FrameData frameData) { }

	// RVA: 0x1B3DB10 Offset: 0x1B3DC11 VA: 0x1B3DB10
	private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent) { }

	// RVA: 0x1B3E1F0 Offset: 0x1B3E2F1 VA: 0x1B3E1F0
	private static void ForAOTCompilationOnly() { }

	// RVA: 0x1B3E250 Offset: 0x1B3E351 VA: 0x1B3E250
	public void .ctor() { }

	// RVA: 0x1B3E370 Offset: 0x1B3E471 VA: 0x1B3E370
	private static void .cctor() { }
}

