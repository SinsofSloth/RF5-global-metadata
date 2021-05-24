[IgnoreOnPlayableTrackAttribute] // RVA: 0x12A670 Offset: 0x12A771 VA: 0x12A670
[Serializable]
public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner // TypeDefIndex: 4558
{
	// Fields
	private const int k_LatestVersion = 3;
	[SerializeField] // RVA: 0x12B6D0 Offset: 0x12B7D1 VA: 0x12B6D0
	[HideInInspector] // RVA: 0x12B6D0 Offset: 0x12B7D1 VA: 0x12B6D0
	private int m_Version; // 0x18
	[ObsoleteAttribute] // RVA: 0x12B710 Offset: 0x12B811 VA: 0x12B710
	[SerializeField] // RVA: 0x12B710 Offset: 0x12B811 VA: 0x12B710
	[HideInInspector] // RVA: 0x12B710 Offset: 0x12B811 VA: 0x12B710
	[FormerlySerializedAsAttribute] // RVA: 0x12B710 Offset: 0x12B811 VA: 0x12B710
	internal AnimationClip m_AnimClip; // 0x20
	private static TrackAsset.TransientBuildData s_BuildData; // 0x0
	internal const string kDefaultCurvesName = "Track Parameters";
	[CompilerGeneratedAttribute] // RVA: 0x12B7A0 Offset: 0x12B8A1 VA: 0x12B7A0
	private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x12B7B0 Offset: 0x12B8B1 VA: 0x12B7B0
	private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; // 0x20
	[SerializeField] // RVA: 0x12B7C0 Offset: 0x12B8C1 VA: 0x12B7C0
	[HideInInspector] // RVA: 0x12B7C0 Offset: 0x12B8C1 VA: 0x12B7C0
	private bool m_Locked; // 0x28
	[SerializeField] // RVA: 0x12B800 Offset: 0x12B901 VA: 0x12B800
	[HideInInspector] // RVA: 0x12B800 Offset: 0x12B901 VA: 0x12B800
	private bool m_Muted; // 0x29
	[SerializeField] // RVA: 0x12B840 Offset: 0x12B941 VA: 0x12B840
	[HideInInspector] // RVA: 0x12B840 Offset: 0x12B941 VA: 0x12B840
	private string m_CustomPlayableFullTypename; // 0x30
	[SerializeField] // RVA: 0x12B880 Offset: 0x12B981 VA: 0x12B880
	[HideInInspector] // RVA: 0x12B880 Offset: 0x12B981 VA: 0x12B880
	private AnimationClip m_Curves; // 0x38
	[SerializeField] // RVA: 0x12B8C0 Offset: 0x12B9C1 VA: 0x12B8C0
	[HideInInspector] // RVA: 0x12B8C0 Offset: 0x12B9C1 VA: 0x12B8C0
	private PlayableAsset m_Parent; // 0x40
	[SerializeField] // RVA: 0x12B900 Offset: 0x12BA01 VA: 0x12B900
	[HideInInspector] // RVA: 0x12B900 Offset: 0x12BA01 VA: 0x12B900
	private List<ScriptableObject> m_Children; // 0x48
	private int m_ItemsHash; // 0x50
	private TimelineClip[] m_ClipsCache; // 0x58
	private DiscreteTime m_Start; // 0x60
	private DiscreteTime m_End; // 0x68
	private bool m_CacheSorted; // 0x70
	private Nullable<bool> m_SupportsNotifications; // 0x71
	private static TrackAsset[] s_EmptyCache; // 0x28
	private IEnumerable<TrackAsset> m_ChildTrackCache; // 0x78
	private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; // 0x30
	[SerializeField] // RVA: 0x12B940 Offset: 0x12BA41 VA: 0x12B940
	[HideInInspector] // RVA: 0x12B940 Offset: 0x12BA41 VA: 0x12B940
	protected internal List<TimelineClip> m_Clips; // 0x80
	[SerializeField] // RVA: 0x12B980 Offset: 0x12BA81 VA: 0x12B980
	[HideInInspector] // RVA: 0x12B980 Offset: 0x12BA81 VA: 0x12B980
	private MarkerList m_Markers; // 0x88

	// Properties
	public double start { get; }
	public double end { get; }
	public sealed override double duration { get; }
	public bool muted { get; set; }
	public bool mutedInHierarchy { get; }
	public TimelineAsset timelineAsset { get; }
	public PlayableAsset parent { get; set; }
	internal TimelineClip[] clips { get; }
	public virtual bool isEmpty { get; }
	public bool hasClips { get; }
	public bool hasCurves { get; }
	public bool isSubTrack { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	internal string customPlayableTypename { get; set; }
	public AnimationClip curves { get; set; }
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.asset { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	internal List<ScriptableObject> subTracksObjects { get; }
	public bool locked { get; set; }
	public bool lockedInHierarchy { get; }
	public bool supportsNotifications { get; }

	// Methods

	// RVA: 0x1B3E500 Offset: 0x1B3E601 VA: 0x1B3E500 Slot: 20
	protected virtual void OnBeforeTrackSerialize() { }

	// RVA: 0x1B3E510 Offset: 0x1B3E611 VA: 0x1B3E510 Slot: 21
	protected virtual void OnAfterTrackDeserialize() { }

	// RVA: 0x1B3E520 Offset: 0x1B3E621 VA: 0x1B3E520 Slot: 22
	internal virtual void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x1B3E530 Offset: 0x1B3E631 VA: 0x1B3E530 Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1B3E6B0 Offset: 0x1B3E7B1 VA: 0x1B3E6B0 Slot: 10
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x1B3EAA0 Offset: 0x1B3EBA1 VA: 0x1B3EAA0
	private void UpgradeToLatestVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x12C060 Offset: 0x12C161 VA: 0x12C060
	// RVA: 0x1B3EAC0 Offset: 0x1B3EBC1 VA: 0x1B3EAC0
	internal static void add_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12C070 Offset: 0x12C171 VA: 0x12C070
	// RVA: 0x1B3EBB0 Offset: 0x1B3ECB1 VA: 0x1B3EBB0
	internal static void remove_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12C080 Offset: 0x12C181 VA: 0x12C080
	// RVA: 0x1B3ECA0 Offset: 0x1B3EDA1 VA: 0x1B3ECA0
	internal static void add_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12C090 Offset: 0x12C191 VA: 0x12C090
	// RVA: 0x1B3ED90 Offset: 0x1B3EE91 VA: 0x1B3ED90
	internal static void remove_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	// RVA: 0x1B3EE80 Offset: 0x1B3EF81 VA: 0x1B3EE80
	public double get_start() { }

	// RVA: 0x1B3F010 Offset: 0x1B3F111 VA: 0x1B3F010
	public double get_end() { }

	// RVA: 0x1B3F090 Offset: 0x1B3F191 VA: 0x1B3F090 Slot: 7
	public sealed override double get_duration() { }

	// RVA: 0x1B3F110 Offset: 0x1B3F211 VA: 0x1B3F110
	public bool get_muted() { }

	// RVA: 0x1B3F120 Offset: 0x1B3F221 VA: 0x1B3F120
	public void set_muted(bool value) { }

	// RVA: 0x1B3F130 Offset: 0x1B3F231 VA: 0x1B3F130
	public bool get_mutedInHierarchy() { }

	// RVA: 0x1B3B860 Offset: 0x1B3B961 VA: 0x1B3B860
	public TimelineAsset get_timelineAsset() { }

	// RVA: 0x1B3F310 Offset: 0x1B3F411 VA: 0x1B3F310
	public PlayableAsset get_parent() { }

	// RVA: 0x1B3F320 Offset: 0x1B3F421 VA: 0x1B3F320
	internal void set_parent(PlayableAsset value) { }

	// RVA: 0x1B3F330 Offset: 0x1B3F431 VA: 0x1B3F330
	public IEnumerable<TimelineClip> GetClips() { }

	// RVA: 0x1B3F340 Offset: 0x1B3F441 VA: 0x1B3F340
	internal TimelineClip[] get_clips() { }

	// RVA: 0x1B3F430 Offset: 0x1B3F531 VA: 0x1B3F430 Slot: 23
	public virtual bool get_isEmpty() { }

	// RVA: 0x1B3F530 Offset: 0x1B3F631 VA: 0x1B3F530
	public bool get_hasClips() { }

	// RVA: 0x1B3F5A0 Offset: 0x1B3F6A1 VA: 0x1B3F5A0 Slot: 13
	public bool get_hasCurves() { }

	// RVA: 0x1B3BD20 Offset: 0x1B3BE21 VA: 0x1B3BD20
	public bool get_isSubTrack() { }

	[IteratorStateMachineAttribute] // RVA: 0x12C0A0 Offset: 0x12C1A1 VA: 0x12C0A0
	// RVA: 0x1B3F660 Offset: 0x1B3F761 VA: 0x1B3F660 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x1B3F730 Offset: 0x1B3F831 VA: 0x1B3F730
	public IEnumerable<TrackAsset> GetChildTracks() { }

	// RVA: 0x1B3F9F0 Offset: 0x1B3FAF1 VA: 0x1B3F9F0
	internal string get_customPlayableTypename() { }

	// RVA: 0x1B3FA00 Offset: 0x1B3FB01 VA: 0x1B3FA00
	internal void set_customPlayableTypename(string value) { }

	// RVA: 0x1B3FA10 Offset: 0x1B3FB11 VA: 0x1B3FA10 Slot: 12
	public AnimationClip get_curves() { }

	// RVA: 0x1B3FA20 Offset: 0x1B3FB21 VA: 0x1B3FA20
	internal void set_curves(AnimationClip value) { }

	// RVA: 0x1B3FA30 Offset: 0x1B3FB31 VA: 0x1B3FA30 Slot: 16
	private string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0x1B3FA80 Offset: 0x1B3FB81 VA: 0x1B3FA80 Slot: 17
	private Object UnityEngine.Timeline.ICurvesOwner.get_asset() { }

	// RVA: 0x1B3FA90 Offset: 0x1B3FB91 VA: 0x1B3FA90 Slot: 18
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0x1B3FAA0 Offset: 0x1B3FBA1 VA: 0x1B3FAA0 Slot: 19
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0x1B3FAB0 Offset: 0x1B3FBB1 VA: 0x1B3FAB0
	internal List<ScriptableObject> get_subTracksObjects() { }

	// RVA: 0x1B3FAC0 Offset: 0x1B3FBC1 VA: 0x1B3FAC0
	public bool get_locked() { }

	// RVA: 0x1B3FAD0 Offset: 0x1B3FBD1 VA: 0x1B3FAD0
	public void set_locked(bool value) { }

	// RVA: 0x1B3FAE0 Offset: 0x1B3FBE1 VA: 0x1B3FAE0
	public bool get_lockedInHierarchy() { }

	// RVA: 0x1B3FCC0 Offset: 0x1B3FDC1 VA: 0x1B3FCC0
	public bool get_supportsNotifications() { }

	// RVA: 0x1B3FD70 Offset: 0x1B3FE71 VA: 0x1B3FD70
	private void __internalAwake() { }

	// RVA: 0x1B3FE50 Offset: 0x1B3FF51 VA: 0x1B3FE50 Slot: 15
	public void CreateCurves(string curvesClipName) { }

	// RVA: 0x1B3FF20 Offset: 0x1B40021 VA: 0x1B3FF20 Slot: 24
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x1B3FFA0 Offset: 0x1B400A1 VA: 0x1B3FFA0 Slot: 6
	public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x1B40010 Offset: 0x1B40111 VA: 0x1B40010
	public TimelineClip CreateDefaultClip() { }

	// RVA: -1 Offset: -1
	public TimelineClip CreateClip<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FE120 Offset: 0x34FE221 VA: 0x34FE120
	|-TrackAsset.CreateClip<object>
	|-TrackAsset.CreateClip<AnimationPlayableAsset>
	*/

	// RVA: 0x1B402F0 Offset: 0x1B403F1 VA: 0x1B402F0
	public bool DeleteClip(TimelineClip clip) { }

	// RVA: 0x1B40410 Offset: 0x1B40511 VA: 0x1B40410
	public IMarker CreateMarker(Type type, double time) { }

	// RVA: -1 Offset: -1
	public T CreateMarker<T>(double time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267280 Offset: 0x2267381 VA: 0x2267280
	|-TrackAsset.CreateMarker<object>
	*/

	// RVA: 0x1B40420 Offset: 0x1B40521 VA: 0x1B40420
	public bool DeleteMarker(IMarker marker) { }

	// RVA: 0x1B3EAB0 Offset: 0x1B3EBB1 VA: 0x1B3EAB0
	public IEnumerable<IMarker> GetMarkers() { }

	// RVA: 0x1B3F650 Offset: 0x1B3F751 VA: 0x1B3F650
	public int GetMarkerCount() { }

	// RVA: 0x1B40430 Offset: 0x1B40531 VA: 0x1B40430
	public IMarker GetMarker(int idx) { }

	// RVA: 0x1B40440 Offset: 0x1B40541 VA: 0x1B40440
	internal TimelineClip CreateClip(Type requestedType) { }

	// RVA: 0x1B402B0 Offset: 0x1B403B1 VA: 0x1B402B0
	internal TimelineClip CreateAndAddNewClipOfType(Type requestedType) { }

	// RVA: 0x1B40840 Offset: 0x1B40941 VA: 0x1B40840
	internal TimelineClip CreateClipOfType(Type requestedType) { }

	// RVA: 0x1B40D00 Offset: 0x1B40E01 VA: 0x1B40D00
	internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) { }

	// RVA: 0x1B40A50 Offset: 0x1B40B51 VA: 0x1B40A50
	private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) { }

	// RVA: 0x1B41240 Offset: 0x1B41341 VA: 0x1B41240
	internal IEnumerable<ScriptableObject> GetMarkersRaw() { }

	// RVA: 0x1B41250 Offset: 0x1B41351 VA: 0x1B41250
	internal void ClearMarkers() { }

	// RVA: 0x1B41260 Offset: 0x1B41361 VA: 0x1B41260
	internal void AddMarker(ScriptableObject e) { }

	// RVA: 0x1B41270 Offset: 0x1B41371 VA: 0x1B41270
	internal bool DeleteMarkerRaw(ScriptableObject marker) { }

	// RVA: 0x1B412C0 Offset: 0x1B413C1 VA: 0x1B412C0
	private int GetTimeRangeHash() { }

	// RVA: 0x1B39260 Offset: 0x1B39361 VA: 0x1B39260
	internal void AddClip(TimelineClip newClip) { }

	// RVA: 0x1B41790 Offset: 0x1B41891 VA: 0x1B41790
	private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) { }

	// RVA: 0x1B3D840 Offset: 0x1B3D941 VA: 0x1B3D840
	internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) { }

	// RVA: 0x1B42050 Offset: 0x1B42151 VA: 0x1B42050 Slot: 25
	internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x1B42630 Offset: 0x1B42731 VA: 0x1B42630
	private void GatherCompilableTracks(IList<TrackAsset> tracks) { }

	// RVA: 0x1B41980 Offset: 0x1B41A81 VA: 0x1B41980
	private void GatherNotificiations(List<IMarker> markers) { }

	// RVA: 0x1B42A70 Offset: 0x1B42B71 VA: 0x1B42A70 Slot: 26
	internal virtual Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x1B42470 Offset: 0x1B42571 VA: 0x1B42470
	internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend) { }

	// RVA: 0x1B3C990 Offset: 0x1B3CA91 VA: 0x1B3C990
	internal void SortClips() { }

	// RVA: 0x1B43060 Offset: 0x1B43161 VA: 0x1B43060
	internal void ClearClipsInternal() { }

	// RVA: 0x1B430E0 Offset: 0x1B431E1 VA: 0x1B430E0
	internal void ClearSubTracksInternal() { }

	// RVA: 0x1B38D20 Offset: 0x1B38E21 VA: 0x1B38D20
	internal void OnClipMove() { }

	// RVA: 0x1B40FB0 Offset: 0x1B410B1 VA: 0x1B40FB0
	internal TimelineClip CreateNewClipContainerInternal() { }

	// RVA: 0x1B43160 Offset: 0x1B43261 VA: 0x1B43160
	internal void AddChild(TrackAsset child) { }

	// RVA: 0x1B43230 Offset: 0x1B43331 VA: 0x1B43230
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0x1B43460 Offset: 0x1B43561 VA: 0x1B43460
	internal bool RemoveSubTrack(TrackAsset child) { }

	// RVA: 0x1B391E0 Offset: 0x1B392E1 VA: 0x1B391E0
	internal void RemoveClip(TimelineClip clip) { }

	// RVA: 0x1B43510 Offset: 0x1B43611 VA: 0x1B43510 Slot: 27
	internal virtual void GetEvaluationTime(out double outStart, out double outDuration) { }

	// RVA: 0x1B43C20 Offset: 0x1B43D21 VA: 0x1B43C20 Slot: 28
	internal virtual void GetSequenceTime(out double outStart, out double outDuration) { }

	// RVA: 0x1B43C30 Offset: 0x1B43D31 VA: 0x1B43C30 Slot: 29
	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x1B44370 Offset: 0x1B44471 VA: 0x1B44370
	internal GameObject GetGameObjectBinding(PlayableDirector director) { }

	// RVA: 0x1B405D0 Offset: 0x1B406D1 VA: 0x1B405D0
	internal bool ValidateClipType(Type clipType) { }

	// RVA: 0x1B44510 Offset: 0x1B44611 VA: 0x1B44510 Slot: 30
	protected virtual void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x1B3EF00 Offset: 0x1B3F001 VA: 0x1B3EF00
	private void UpdateDuration() { }

	// RVA: 0x1B44520 Offset: 0x1B44621 VA: 0x1B44520 Slot: 31
	protected internal virtual int CalculateItemsHash() { }

	// RVA: 0x1B448B0 Offset: 0x1B449B1 VA: 0x1B448B0 Slot: 32
	protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) { }

	// RVA: 0x1B3E9F0 Offset: 0x1B3EAF1 VA: 0x1B3E9F0
	internal void Invalidate() { }

	// RVA: 0x1B43800 Offset: 0x1B43901 VA: 0x1B43800
	internal double GetNotificationDuration() { }

	// RVA: 0x1B44B40 Offset: 0x1B44C41 VA: 0x1B44B40 Slot: 33
	internal virtual bool CanCompileClips() { }

	// RVA: 0x1B3C600 Offset: 0x1B3C701 VA: 0x1B3C600
	internal bool IsCompilable() { }

	// RVA: 0x1B3F760 Offset: 0x1B3F861 VA: 0x1B3F760
	private void UpdateChildTrackCache() { }

	// RVA: 0x1B44C30 Offset: 0x1B44D31 VA: 0x1B44C30 Slot: 34
	internal virtual int Hash() { }

	// RVA: 0x1B445C0 Offset: 0x1B446C1 VA: 0x1B445C0
	private int GetClipsHash() { }

	// RVA: 0x1B44790 Offset: 0x1B44891 VA: 0x1B44790
	protected static int GetAnimationClipHash(AnimationClip clip) { }

	// RVA: 0x1B437F0 Offset: 0x1B438F1 VA: 0x1B437F0
	private bool HasNotifications() { }

	// RVA: 0x1B429B0 Offset: 0x1B42AB1 VA: 0x1B429B0
	private bool CanCompileNotifications() { }

	// RVA: 0x1B41CB0 Offset: 0x1B41DB1 VA: 0x1B41CB0
	private bool CanCompileClipsRecursive() { }

	// RVA: 0x1B44C70 Offset: 0x1B44D71 VA: 0x1B44C70
	protected void .ctor() { }

	// RVA: 0x1B44D50 Offset: 0x1B44E51 VA: 0x1B44D50
	private static void .cctor() { }
}

