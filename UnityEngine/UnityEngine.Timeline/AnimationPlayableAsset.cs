[NotKeyableAttribute] // RVA: 0x12A590 Offset: 0x12A691 VA: 0x12A590
[Serializable]
public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver // TypeDefIndex: 4532
{
	// Fields
	[SerializeField] // RVA: 0x12AE50 Offset: 0x12AF51 VA: 0x12AE50
	private AnimationClip m_Clip; // 0x18
	[SerializeField] // RVA: 0x12AE60 Offset: 0x12AF61 VA: 0x12AE60
	private Vector3 m_Position; // 0x20
	[SerializeField] // RVA: 0x12AE70 Offset: 0x12AF71 VA: 0x12AE70
	private Vector3 m_EulerAngles; // 0x2C
	[SerializeField] // RVA: 0x12AE80 Offset: 0x12AF81 VA: 0x12AE80
	private bool m_UseTrackMatchFields; // 0x38
	[SerializeField] // RVA: 0x12AE90 Offset: 0x12AF91 VA: 0x12AE90
	private MatchTargetFields m_MatchTargetFields; // 0x3C
	[SerializeField] // RVA: 0x12AEA0 Offset: 0x12AFA1 VA: 0x12AEA0
	private bool m_RemoveStartOffset; // 0x40
	[SerializeField] // RVA: 0x12AEB0 Offset: 0x12AFB1 VA: 0x12AEB0
	private bool m_ApplyFootIK; // 0x41
	[SerializeField] // RVA: 0x12AEC0 Offset: 0x12AFC1 VA: 0x12AEC0
	private AnimationPlayableAsset.LoopMode m_Loop; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x12AED0 Offset: 0x12AFD1 VA: 0x12AED0
	private AppliedOffsetMode <appliedOffsetMode>k__BackingField; // 0x48
	private static readonly int k_LatestVersion; // 0x0
	[SerializeField] // RVA: 0x12AEE0 Offset: 0x12AFE1 VA: 0x12AEE0
	[HideInInspector] // RVA: 0x12AEE0 Offset: 0x12AFE1 VA: 0x12AEE0
	private int m_Version; // 0x4C
	[SerializeField] // RVA: 0x12AF20 Offset: 0x12B021 VA: 0x12AF20
	[ObsoleteAttribute] // RVA: 0x12AF20 Offset: 0x12B021 VA: 0x12AF20
	[HideInInspector] // RVA: 0x12AF20 Offset: 0x12B021 VA: 0x12AF20
	private Quaternion m_Rotation; // 0x50

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	public bool useTrackMatchFields { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public bool removeStartOffset { get; set; }
	public bool applyFootIK { get; set; }
	public AnimationPlayableAsset.LoopMode loop { get; set; }
	internal bool hasRootTransforms { get; }
	internal AppliedOffsetMode appliedOffsetMode { get; set; }
	public AnimationClip clip { get; set; }
	public override double duration { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x17D32F0 Offset: 0x17D33F1 VA: 0x17D32F0
	public Vector3 get_position() { }

	// RVA: 0x17D3300 Offset: 0x17D3401 VA: 0x17D3300
	public void set_position(Vector3 value) { }

	// RVA: 0x17D3310 Offset: 0x17D3411 VA: 0x17D3310
	public Quaternion get_rotation() { }

	// RVA: 0x17D33A0 Offset: 0x17D34A1 VA: 0x17D33A0
	public void set_rotation(Quaternion value) { }

	// RVA: 0x17D33F0 Offset: 0x17D34F1 VA: 0x17D33F0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x17D3400 Offset: 0x17D3501 VA: 0x17D3400
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x17D3410 Offset: 0x17D3511 VA: 0x17D3410
	public bool get_useTrackMatchFields() { }

	// RVA: 0x17D3420 Offset: 0x17D3521 VA: 0x17D3420
	public void set_useTrackMatchFields(bool value) { }

	// RVA: 0x17D3430 Offset: 0x17D3531 VA: 0x17D3430
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0x17D3440 Offset: 0x17D3541 VA: 0x17D3440
	public void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0x17D3450 Offset: 0x17D3551 VA: 0x17D3450
	public bool get_removeStartOffset() { }

	// RVA: 0x17D3460 Offset: 0x17D3561 VA: 0x17D3460
	public void set_removeStartOffset(bool value) { }

	// RVA: 0x17D3470 Offset: 0x17D3571 VA: 0x17D3470
	public bool get_applyFootIK() { }

	// RVA: 0x17D3480 Offset: 0x17D3581 VA: 0x17D3480
	public void set_applyFootIK(bool value) { }

	// RVA: 0x17D3490 Offset: 0x17D3591 VA: 0x17D3490
	public AnimationPlayableAsset.LoopMode get_loop() { }

	// RVA: 0x17D34A0 Offset: 0x17D35A1 VA: 0x17D34A0
	public void set_loop(AnimationPlayableAsset.LoopMode value) { }

	// RVA: 0x17D34B0 Offset: 0x17D35B1 VA: 0x17D34B0
	internal bool get_hasRootTransforms() { }

	[CompilerGeneratedAttribute] // RVA: 0x12BE90 Offset: 0x12BF91 VA: 0x12BE90
	// RVA: 0x17D3670 Offset: 0x17D3771 VA: 0x17D3670
	internal AppliedOffsetMode get_appliedOffsetMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x12BEA0 Offset: 0x12BFA1 VA: 0x12BEA0
	// RVA: 0x17D3680 Offset: 0x17D3781 VA: 0x17D3680
	internal void set_appliedOffsetMode(AppliedOffsetMode value) { }

	// RVA: 0x17D3690 Offset: 0x17D3791 VA: 0x17D3690
	public AnimationClip get_clip() { }

	// RVA: 0x17D36A0 Offset: 0x17D37A1 VA: 0x17D36A0
	public void set_clip(AnimationClip value) { }

	// RVA: 0x17D3770 Offset: 0x17D3871 VA: 0x17D3770 Slot: 7
	public override double get_duration() { }

	[IteratorStateMachineAttribute] // RVA: 0x12BEB0 Offset: 0x12BFB1 VA: 0x12BEB0
	// RVA: 0x17D39B0 Offset: 0x17D3AB1 VA: 0x17D39B0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x17D3A80 Offset: 0x17D3B81 VA: 0x17D3A80 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x17D3B70 Offset: 0x17D3C71 VA: 0x17D3B70
	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, AnimationPlayableAsset.LoopMode loop) { }

	// RVA: 0x17D3F90 Offset: 0x17D4091 VA: 0x17D3F90
	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) { }

	// RVA: 0x17D3F70 Offset: 0x17D4071 VA: 0x17D3F70
	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) { }

	// RVA: 0x17D4020 Offset: 0x17D4121 VA: 0x17D4020 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x17D4150 Offset: 0x17D4251 VA: 0x17D4150
	public void ResetOffsets() { }

	// RVA: 0x17D41E0 Offset: 0x17D42E1 VA: 0x17D41E0 Slot: 10
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x17D3570 Offset: 0x17D3671 VA: 0x17D3570
	internal static bool HasRootTransforms(AnimationClip clip) { }

	// RVA: 0x17D42B0 Offset: 0x17D43B1 VA: 0x17D42B0 Slot: 11
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x17D4320 Offset: 0x17D4421 VA: 0x17D4320 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x17D43E0 Offset: 0x17D44E1 VA: 0x17D43E0
	private void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x17D4470 Offset: 0x17D4571 VA: 0x17D4470
	public void .ctor() { }

	// RVA: 0x17D4570 Offset: 0x17D4671 VA: 0x17D4570
	private static void .cctor() { }
}

