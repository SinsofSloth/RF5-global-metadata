[TrackClipTypeAttribute] // RVA: 0x12A5C0 Offset: 0x12A6C1 VA: 0x12A5C0
[TrackBindingTypeAttribute] // RVA: 0x12A5C0 Offset: 0x12A6C1 VA: 0x12A5C0
[ExcludeFromPresetAttribute] // RVA: 0x12A5C0 Offset: 0x12A6C1 VA: 0x12A5C0
[Serializable]
public class AnimationTrack : TrackAsset, ILayerable // TypeDefIndex: 4542
{
	// Fields
	private const string k_DefaultInfiniteClipName = "Recorded";
	private const string k_DefaultRecordableClipName = "Recorded";
	[SerializeField] // RVA: 0x12AF80 Offset: 0x12B081 VA: 0x12AF80
	[FormerlySerializedAsAttribute] // RVA: 0x12AF80 Offset: 0x12B081 VA: 0x12AF80
	private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation; // 0xA0
	[SerializeField] // RVA: 0x12AFD0 Offset: 0x12B0D1 VA: 0x12AFD0
	[FormerlySerializedAsAttribute] // RVA: 0x12AFD0 Offset: 0x12B0D1 VA: 0x12AFD0
	private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation; // 0xA4
	[SerializeField] // RVA: 0x12B020 Offset: 0x12B121 VA: 0x12B020
	[FormerlySerializedAsAttribute] // RVA: 0x12B020 Offset: 0x12B121 VA: 0x12B020
	private Vector3 m_InfiniteClipOffsetPosition; // 0xA8
	[SerializeField] // RVA: 0x12B070 Offset: 0x12B171 VA: 0x12B070
	[FormerlySerializedAsAttribute] // RVA: 0x12B070 Offset: 0x12B171 VA: 0x12B070
	private Vector3 m_InfiniteClipOffsetEulerAngles; // 0xB4
	[SerializeField] // RVA: 0x12B0C0 Offset: 0x12B1C1 VA: 0x12B0C0
	[FormerlySerializedAsAttribute] // RVA: 0x12B0C0 Offset: 0x12B1C1 VA: 0x12B0C0
	private double m_InfiniteClipTimeOffset; // 0xC0
	[SerializeField] // RVA: 0x12B110 Offset: 0x12B211 VA: 0x12B110
	[FormerlySerializedAsAttribute] // RVA: 0x12B110 Offset: 0x12B211 VA: 0x12B110
	private bool m_InfiniteClipRemoveOffset; // 0xC8
	[SerializeField] // RVA: 0x12B160 Offset: 0x12B261 VA: 0x12B160
	private bool m_InfiniteClipApplyFootIK; // 0xC9
	[SerializeField] // RVA: 0x12B170 Offset: 0x12B271 VA: 0x12B170
	[HideInInspector] // RVA: 0x12B170 Offset: 0x12B271 VA: 0x12B170
	private AnimationPlayableAsset.LoopMode mInfiniteClipLoop; // 0xCC
	[SerializeField] // RVA: 0x12B1B0 Offset: 0x12B2B1 VA: 0x12B1B0
	private MatchTargetFields m_MatchTargetFields; // 0xD0
	[SerializeField] // RVA: 0x12B1C0 Offset: 0x12B2C1 VA: 0x12B1C0
	private Vector3 m_Position; // 0xD4
	[SerializeField] // RVA: 0x12B1D0 Offset: 0x12B2D1 VA: 0x12B1D0
	private Vector3 m_EulerAngles; // 0xE0
	[SerializeField] // RVA: 0x12B1E0 Offset: 0x12B2E1 VA: 0x12B1E0
	private AvatarMask m_AvatarMask; // 0xF0
	[SerializeField] // RVA: 0x12B1F0 Offset: 0x12B2F1 VA: 0x12B1F0
	private bool m_ApplyAvatarMask; // 0xF8
	[SerializeField] // RVA: 0x12B200 Offset: 0x12B301 VA: 0x12B200
	private TrackOffset m_TrackOffset; // 0xFC
	[SerializeField] // RVA: 0x12B210 Offset: 0x12B311 VA: 0x12B210
	[HideInInspector] // RVA: 0x12B210 Offset: 0x12B311 VA: 0x12B210
	private AnimationClip m_InfiniteClip; // 0x100
	private static readonly Queue<Transform> s_CachedQueue; // 0x0
	[SerializeField] // RVA: 0x12B250 Offset: 0x12B351 VA: 0x12B250
	[ObsoleteAttribute] // RVA: 0x12B250 Offset: 0x12B351 VA: 0x12B250
	[HideInInspector] // RVA: 0x12B250 Offset: 0x12B351 VA: 0x12B250
	private Quaternion m_OpenClipOffsetRotation; // 0x108
	[SerializeField] // RVA: 0x12B2B0 Offset: 0x12B3B1 VA: 0x12B2B0
	[ObsoleteAttribute] // RVA: 0x12B2B0 Offset: 0x12B3B1 VA: 0x12B2B0
	[HideInInspector] // RVA: 0x12B2B0 Offset: 0x12B3B1 VA: 0x12B2B0
	private Quaternion m_Rotation; // 0x118
	[SerializeField] // RVA: 0x12B310 Offset: 0x12B411 VA: 0x12B310
	[ObsoleteAttribute] // RVA: 0x12B310 Offset: 0x12B411 VA: 0x12B310
	[HideInInspector] // RVA: 0x12B310 Offset: 0x12B411 VA: 0x12B310
	private bool m_ApplyOffsets; // 0x128

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	[ObsoleteAttribute] // RVA: 0x12C7D0 Offset: 0x12C8D1 VA: 0x12C7D0
	public bool applyOffsets { get; set; }
	public TrackOffset trackOffset { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public AnimationClip infiniteClip { get; set; }
	internal bool infiniteClipRemoveOffset { get; set; }
	public AvatarMask avatarMask { get; set; }
	public bool applyAvatarMask { get; set; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public bool inClipMode { get; }
	public Vector3 infiniteClipOffsetPosition { get; set; }
	public Quaternion infiniteClipOffsetRotation { get; set; }
	public Vector3 infiniteClipOffsetEulerAngles { get; set; }
	internal bool infiniteClipApplyFootIK { get; set; }
	internal double infiniteClipTimeOffset { get; set; }
	public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get; set; }
	public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get; set; }
	internal AnimationPlayableAsset.LoopMode infiniteClipLoop { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x12C810 Offset: 0x12C911 VA: 0x12C810
	[ObsoleteAttribute] // RVA: 0x12C810 Offset: 0x12C911 VA: 0x12C810
	public Vector3 openClipOffsetPosition { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x12C870 Offset: 0x12C971 VA: 0x12C870
	[ObsoleteAttribute] // RVA: 0x12C870 Offset: 0x12C971 VA: 0x12C870
	public Quaternion openClipOffsetRotation { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x12C8D0 Offset: 0x12C9D1 VA: 0x12C8D0
	[ObsoleteAttribute] // RVA: 0x12C8D0 Offset: 0x12C9D1 VA: 0x12C8D0
	public Vector3 openClipOffsetEulerAngles { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x12C930 Offset: 0x12CA31 VA: 0x12C930
	[ObsoleteAttribute] // RVA: 0x12C930 Offset: 0x12CA31 VA: 0x12C930
	public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x12C990 Offset: 0x12CA91 VA: 0x12C990
	[ObsoleteAttribute] // RVA: 0x12C990 Offset: 0x12CA91 VA: 0x12C990
	public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get; set; }

	// Methods

	// RVA: 0x17D4BC0 Offset: 0x17D4CC1 VA: 0x17D4BC0
	public Vector3 get_position() { }

	// RVA: 0x17D4BD0 Offset: 0x17D4CD1 VA: 0x17D4BD0
	public void set_position(Vector3 value) { }

	// RVA: 0x17D4BE0 Offset: 0x17D4CE1 VA: 0x17D4BE0
	public Quaternion get_rotation() { }

	// RVA: 0x17D4C70 Offset: 0x17D4D71 VA: 0x17D4C70
	public void set_rotation(Quaternion value) { }

	// RVA: 0x17D4CC0 Offset: 0x17D4DC1 VA: 0x17D4CC0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x17D4CD0 Offset: 0x17D4DD1 VA: 0x17D4CD0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x17D4CE0 Offset: 0x17D4DE1 VA: 0x17D4CE0
	public bool get_applyOffsets() { }

	// RVA: 0x17D4CF0 Offset: 0x17D4DF1 VA: 0x17D4CF0
	public void set_applyOffsets(bool value) { }

	// RVA: 0x17D4D00 Offset: 0x17D4E01 VA: 0x17D4D00
	public TrackOffset get_trackOffset() { }

	// RVA: 0x17D4D10 Offset: 0x17D4E11 VA: 0x17D4D10
	public void set_trackOffset(TrackOffset value) { }

	// RVA: 0x17D4D20 Offset: 0x17D4E21 VA: 0x17D4D20
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0x17D4D30 Offset: 0x17D4E31 VA: 0x17D4D30
	public void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0x17D4DB0 Offset: 0x17D4EB1 VA: 0x17D4DB0
	public AnimationClip get_infiniteClip() { }

	// RVA: 0x17D4DC0 Offset: 0x17D4EC1 VA: 0x17D4DC0
	internal void set_infiniteClip(AnimationClip value) { }

	// RVA: 0x17D4DD0 Offset: 0x17D4ED1 VA: 0x17D4DD0
	internal bool get_infiniteClipRemoveOffset() { }

	// RVA: 0x17D4DE0 Offset: 0x17D4EE1 VA: 0x17D4DE0
	internal void set_infiniteClipRemoveOffset(bool value) { }

	// RVA: 0x17D4DF0 Offset: 0x17D4EF1 VA: 0x17D4DF0
	public AvatarMask get_avatarMask() { }

	// RVA: 0x17D4E00 Offset: 0x17D4F01 VA: 0x17D4E00
	public void set_avatarMask(AvatarMask value) { }

	// RVA: 0x17D4E10 Offset: 0x17D4F11 VA: 0x17D4E10
	public bool get_applyAvatarMask() { }

	// RVA: 0x17D4E20 Offset: 0x17D4F21 VA: 0x17D4E20
	public void set_applyAvatarMask(bool value) { }

	// RVA: 0x17D4E30 Offset: 0x17D4F31 VA: 0x17D4E30 Slot: 33
	internal override bool CanCompileClips() { }

	[IteratorStateMachineAttribute] // RVA: 0x12BF40 Offset: 0x12C041 VA: 0x12BF40
	// RVA: 0x17D4F20 Offset: 0x17D5021 VA: 0x17D4F20 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x17D4FF0 Offset: 0x17D50F1 VA: 0x17D4FF0
	public bool get_inClipMode() { }

	// RVA: 0x17D5040 Offset: 0x17D5141 VA: 0x17D5040
	public Vector3 get_infiniteClipOffsetPosition() { }

	// RVA: 0x17D5050 Offset: 0x17D5151 VA: 0x17D5050
	public void set_infiniteClipOffsetPosition(Vector3 value) { }

	// RVA: 0x17D5060 Offset: 0x17D5161 VA: 0x17D5060
	public Quaternion get_infiniteClipOffsetRotation() { }

	// RVA: 0x17D50F0 Offset: 0x17D51F1 VA: 0x17D50F0
	public void set_infiniteClipOffsetRotation(Quaternion value) { }

	// RVA: 0x17D5140 Offset: 0x17D5241 VA: 0x17D5140
	public Vector3 get_infiniteClipOffsetEulerAngles() { }

	// RVA: 0x17D5150 Offset: 0x17D5251 VA: 0x17D5150
	public void set_infiniteClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0x17D5160 Offset: 0x17D5261 VA: 0x17D5160
	internal bool get_infiniteClipApplyFootIK() { }

	// RVA: 0x17D5170 Offset: 0x17D5271 VA: 0x17D5170
	internal void set_infiniteClipApplyFootIK(bool value) { }

	// RVA: 0x17D5180 Offset: 0x17D5281 VA: 0x17D5180
	internal double get_infiniteClipTimeOffset() { }

	// RVA: 0x17D5190 Offset: 0x17D5291 VA: 0x17D5190
	internal void set_infiniteClipTimeOffset(double value) { }

	// RVA: 0x17D51A0 Offset: 0x17D52A1 VA: 0x17D51A0
	public TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation() { }

	// RVA: 0x17D51B0 Offset: 0x17D52B1 VA: 0x17D51B0
	public void set_infiniteClipPreExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x17D51C0 Offset: 0x17D52C1 VA: 0x17D51C0
	public TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation() { }

	// RVA: 0x17D51D0 Offset: 0x17D52D1 VA: 0x17D51D0
	public void set_infiniteClipPostExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x17D51E0 Offset: 0x17D52E1 VA: 0x17D51E0
	internal AnimationPlayableAsset.LoopMode get_infiniteClipLoop() { }

	// RVA: 0x17D51F0 Offset: 0x17D52F1 VA: 0x17D51F0
	internal void set_infiniteClipLoop(AnimationPlayableAsset.LoopMode value) { }

	[ContextMenu] // RVA: 0x12BFB0 Offset: 0x12C0B1 VA: 0x12BFB0
	// RVA: 0x17D5200 Offset: 0x17D5301 VA: 0x17D5200
	private void ResetOffsets() { }

	// RVA: 0x17D52A0 Offset: 0x17D53A1 VA: 0x17D52A0
	public TimelineClip CreateClip(AnimationClip clip) { }

	// RVA: 0x17D55C0 Offset: 0x17D56C1 VA: 0x17D55C0
	public void CreateInfiniteClip(string infiniteClipName) { }

	// RVA: 0x17D5700 Offset: 0x17D5801 VA: 0x17D5700
	public TimelineClip CreateRecordableClip(string animClipName) { }

	// RVA: 0x17D58D0 Offset: 0x17D59D1 VA: 0x17D58D0 Slot: 30
	protected override void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x17D5920 Offset: 0x17D5A21 VA: 0x17D5920 Slot: 31
	protected internal override int CalculateItemsHash() { }

	// RVA: 0x17D5290 Offset: 0x17D5391 VA: 0x17D5290
	internal void UpdateClipOffsets() { }

	// RVA: 0x17D59E0 Offset: 0x17D5AE1 VA: 0x17D59E0
	private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	// RVA: 0x17D64C0 Offset: 0x17D65C1 VA: 0x17D64C0 Slot: 35
	private Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x17D6530 Offset: 0x17D6631 VA: 0x17D6530 Slot: 26
	internal override Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x17D7450 Offset: 0x17D7551 VA: 0x17D7450
	private int GetDefaultBlendCount() { }

	// RVA: 0x17D7970 Offset: 0x17D7A71 VA: 0x17D7970
	private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset) { }

	// RVA: 0x17D79A0 Offset: 0x17D7AA1 VA: 0x17D79A0
	private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) { }

	// RVA: 0x17D7830 Offset: 0x17D7931 VA: 0x17D7830
	private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) { }

	// RVA: 0x17D7980 Offset: 0x17D7A81 VA: 0x17D7980
	private static bool UsesAbsoluteMotion(AppliedOffsetMode mode) { }

	// RVA: 0x17D7CF0 Offset: 0x17D7DF1 VA: 0x17D7CF0
	private bool HasController(GameObject gameObject) { }

	// RVA: 0x17D7AF0 Offset: 0x17D7BF1 VA: 0x17D7AF0
	internal Animator GetBinding(PlayableDirector director) { }

	// RVA: 0x17D7460 Offset: 0x17D7561 VA: 0x17D7460
	private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x17D74E0 Offset: 0x17D75E1 VA: 0x17D74E0
	private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	// RVA: 0x17D62D0 Offset: 0x17D63D1 VA: 0x17D62D0
	private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) { }

	// RVA: 0x17D7E60 Offset: 0x17D7F61 VA: 0x17D7E60 Slot: 27
	internal override void GetEvaluationTime(out double outStart, out double outDuration) { }

	// RVA: 0x17D7F30 Offset: 0x17D8031 VA: 0x17D7F30 Slot: 28
	internal override void GetSequenceTime(out double outStart, out double outDuration) { }

	// RVA: 0x17D5350 Offset: 0x17D5451 VA: 0x17D5350
	private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) { }

	// RVA: 0x17D8050 Offset: 0x17D8151 VA: 0x17D8050 Slot: 29
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x17D8060 Offset: 0x17D8161 VA: 0x17D8060
	private void GetAnimationClips(List<AnimationClip> animClips) { }

	// RVA: 0x17D73C0 Offset: 0x17D74C1 VA: 0x17D73C0
	private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform) { }

	// RVA: 0x17D7140 Offset: 0x17D7241 VA: 0x17D7140
	private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) { }

	// RVA: 0x17D6F50 Offset: 0x17D7051 VA: 0x17D6F50
	private Transform GetGenericRootNode(GameObject gameObject) { }

	// RVA: 0x17D5EE0 Offset: 0x17D5FE1 VA: 0x17D5EE0
	internal bool AnimatesRootTransform() { }

	// RVA: 0x17D8600 Offset: 0x17D8701 VA: 0x17D8600
	private static Transform FindInHierarchyBreadthFirst(Transform t, string name) { }

	// RVA: 0x17D87E0 Offset: 0x17D88E1 VA: 0x17D87E0
	public Vector3 get_openClipOffsetPosition() { }

	// RVA: 0x17D87F0 Offset: 0x17D88F1 VA: 0x17D87F0
	public void set_openClipOffsetPosition(Vector3 value) { }

	// RVA: 0x17D8800 Offset: 0x17D8901 VA: 0x17D8800
	public Quaternion get_openClipOffsetRotation() { }

	// RVA: 0x17D8890 Offset: 0x17D8991 VA: 0x17D8890
	public void set_openClipOffsetRotation(Quaternion value) { }

	// RVA: 0x17D88E0 Offset: 0x17D89E1 VA: 0x17D88E0
	public Vector3 get_openClipOffsetEulerAngles() { }

	// RVA: 0x17D88F0 Offset: 0x17D89F1 VA: 0x17D88F0
	public void set_openClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0x17D8900 Offset: 0x17D8A01 VA: 0x17D8900
	public TimelineClip.ClipExtrapolation get_openClipPreExtrapolation() { }

	// RVA: 0x17D8910 Offset: 0x17D8A11 VA: 0x17D8910
	public void set_openClipPreExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x17D8920 Offset: 0x17D8A21 VA: 0x17D8920
	public TimelineClip.ClipExtrapolation get_openClipPostExtrapolation() { }

	// RVA: 0x17D8930 Offset: 0x17D8A31 VA: 0x17D8930
	public void set_openClipPostExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x17D8940 Offset: 0x17D8A41 VA: 0x17D8940 Slot: 22
	internal override void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x17D8B30 Offset: 0x17D8C31 VA: 0x17D8B30
	public void .ctor() { }

	// RVA: 0x17D8CA0 Offset: 0x17D8DA1 VA: 0x17D8CA0
	private static void .cctor() { }
}

