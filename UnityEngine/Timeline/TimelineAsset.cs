[ExcludeFromPresetAttribute] // RVA: 0x12A660 Offset: 0x12A761 VA: 0x12A660
[Serializable]
public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview // TypeDefIndex: 4551
{
	// Fields
	private const int k_LatestVersion = 0;
	[SerializeField] // RVA: 0x12B550 Offset: 0x12B651 VA: 0x12B550
	[HideInInspector] // RVA: 0x12B550 Offset: 0x12B651 VA: 0x12B550
	private int m_Version; // 0x18
	[HideInInspector] // RVA: 0x12B590 Offset: 0x12B691 VA: 0x12B590
	[SerializeField] // RVA: 0x12B590 Offset: 0x12B691 VA: 0x12B590
	private List<ScriptableObject> m_Tracks; // 0x20
	[HideInInspector] // RVA: 0x12B5D0 Offset: 0x12B6D1 VA: 0x12B5D0
	[SerializeField] // RVA: 0x12B5D0 Offset: 0x12B6D1 VA: 0x12B5D0
	private double m_FixedDuration; // 0x28
	[HideInInspector] // RVA: 0x12B610 Offset: 0x12B711 VA: 0x12B610
	private TrackAsset[] m_CacheOutputTracks; // 0x30
	[HideInInspector] // RVA: 0x12B620 Offset: 0x12B721 VA: 0x12B620
	private List<TrackAsset> m_CacheRootTracks; // 0x38
	[HideInInspector] // RVA: 0x12B630 Offset: 0x12B731 VA: 0x12B630
	private List<TrackAsset> m_CacheFlattenedTracks; // 0x40
	[HideInInspector] // RVA: 0x12B640 Offset: 0x12B741 VA: 0x12B640
	[SerializeField] // RVA: 0x12B640 Offset: 0x12B741 VA: 0x12B640
	private TimelineAsset.EditorSettings m_EditorSettings; // 0x48
	[SerializeField] // RVA: 0x12B680 Offset: 0x12B781 VA: 0x12B680
	private TimelineAsset.DurationMode m_DurationMode; // 0x50
	[HideInInspector] // RVA: 0x12B690 Offset: 0x12B791 VA: 0x12B690
	[SerializeField] // RVA: 0x12B690 Offset: 0x12B791 VA: 0x12B690
	private MarkerTrack m_MarkerTrack; // 0x58

	// Properties
	public TimelineAsset.EditorSettings editorSettings { get; }
	public override double duration { get; }
	public double fixedDuration { get; set; }
	public TimelineAsset.DurationMode durationMode { get; set; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }
	public int outputTrackCount { get; }
	public int rootTrackCount { get; }
	internal IEnumerable<TrackAsset> flattenedTracks { get; }
	public MarkerTrack markerTrack { get; }
	internal List<ScriptableObject> trackObjects { get; }

	// Methods

	// RVA: 0x17E91D0 Offset: 0x17E92D1 VA: 0x17E91D0
	private void UpgradeToLatestVersion() { }

	// RVA: 0x17E91E0 Offset: 0x17E92E1 VA: 0x17E91E0
	public TimelineAsset.EditorSettings get_editorSettings() { }

	// RVA: 0x17E91F0 Offset: 0x17E92F1 VA: 0x17E91F0 Slot: 7
	public override double get_duration() { }

	// RVA: 0x17E9780 Offset: 0x17E9881 VA: 0x17E9780
	public double get_fixedDuration() { }

	// RVA: 0x17E9950 Offset: 0x17E9A51 VA: 0x17E9950
	public void set_fixedDuration(double value) { }

	// RVA: 0x17E99D0 Offset: 0x17E9AD1 VA: 0x17E99D0
	public TimelineAsset.DurationMode get_durationMode() { }

	// RVA: 0x17E99E0 Offset: 0x17E9AE1 VA: 0x17E99E0
	public void set_durationMode(TimelineAsset.DurationMode value) { }

	[IteratorStateMachineAttribute] // RVA: 0x12BFF0 Offset: 0x12C0F1 VA: 0x12BFF0
	// RVA: 0x17E99F0 Offset: 0x17E9AF1 VA: 0x17E99F0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x17E9AC0 Offset: 0x17E9BC1 VA: 0x17E9AC0 Slot: 11
	public ClipCaps get_clipCaps() { }

	// RVA: 0x17E9E20 Offset: 0x17E9F21 VA: 0x17E9E20
	public int get_outputTrackCount() { }

	// RVA: 0x17EA290 Offset: 0x17EA391 VA: 0x17EA290
	public int get_rootTrackCount() { }

	// RVA: 0x17EA580 Offset: 0x17EA681 VA: 0x17EA580
	private void OnValidate() { }

	// RVA: 0x17EA650 Offset: 0x17EA751 VA: 0x17EA650
	internal static float GetValidFramerate(float framerate) { }

	// RVA: 0x17EA700 Offset: 0x17EA801 VA: 0x17EA700
	public TrackAsset GetRootTrack(int index) { }

	// RVA: 0x17E9DF0 Offset: 0x17E9EF1 VA: 0x17E9DF0
	public IEnumerable<TrackAsset> GetRootTracks() { }

	// RVA: 0x17EA780 Offset: 0x17EA881 VA: 0x17EA780
	public TrackAsset GetOutputTrack(int index) { }

	// RVA: 0x17EA7D0 Offset: 0x17EA8D1 VA: 0x17EA7D0
	public IEnumerable<TrackAsset> GetOutputTracks() { }

	// RVA: 0x17EA2F0 Offset: 0x17EA3F1 VA: 0x17EA2F0
	private void UpdateRootTrackCache() { }

	// RVA: 0x17E9E50 Offset: 0x17E9F51 VA: 0x17E9E50
	private void UpdateOutputTrackCache() { }

	// RVA: 0x17EA800 Offset: 0x17EA901 VA: 0x17EA800
	internal IEnumerable<TrackAsset> get_flattenedTracks() { }

	// RVA: 0x17EAC00 Offset: 0x17EAD01 VA: 0x17EAC00
	public MarkerTrack get_markerTrack() { }

	// RVA: 0x17EAC10 Offset: 0x17EAD11 VA: 0x17EAC10
	internal List<ScriptableObject> get_trackObjects() { }

	// RVA: 0x17EAC20 Offset: 0x17EAD21 VA: 0x17EAC20
	internal void AddTrackInternal(TrackAsset track) { }

	// RVA: 0x17EAD20 Offset: 0x17EAE21 VA: 0x17EAD20
	internal void RemoveTrack(TrackAsset track) { }

	// RVA: 0x17EAE60 Offset: 0x17EAF61 VA: 0x17EAE60 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x17EAFC0 Offset: 0x17EB0C1 VA: 0x17EAFC0 Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x17EAFD0 Offset: 0x17EB0D1 VA: 0x17EAFD0 Slot: 10
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x17EB020 Offset: 0x17EB121 VA: 0x17EB020
	private void __internalAwake() { }

	// RVA: 0x17DEA10 Offset: 0x17DEB11 VA: 0x17DEA10 Slot: 12
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x17EB1A0 Offset: 0x17EB2A1 VA: 0x17EB1A0
	public void CreateMarkerTrack() { }

	// RVA: 0x17EACD0 Offset: 0x17EADD1 VA: 0x17EACD0
	internal void Invalidate() { }

	// RVA: 0x17E9210 Offset: 0x17E9311 VA: 0x17E9210
	private double CalculateDuration() { }

	// RVA: 0x17EA920 Offset: 0x17EAA21 VA: 0x17EA920
	private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks) { }

	// RVA: 0x17EB2D0 Offset: 0x17EB3D1 VA: 0x17EB2D0
	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name) { }

	// RVA: -1 Offset: -1
	public T CreateTrack<T>(TrackAsset parent, string trackName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267190 Offset: 0x2267291 VA: 0x2267190
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: -1 Offset: -1
	public T CreateTrack<T>(string trackName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267090 Offset: 0x2267191 VA: 0x2267090
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: -1 Offset: -1
	public T CreateTrack<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266FA0 Offset: 0x22670A1 VA: 0x2266FA0
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: 0x17EB890 Offset: 0x17EB991 VA: 0x17EB890
	public bool DeleteClip(TimelineClip clip) { }

	// RVA: 0x17EBC30 Offset: 0x17EBD31 VA: 0x17EBC30
	public bool DeleteTrack(TrackAsset track) { }

	// RVA: 0x17EC250 Offset: 0x17EC351 VA: 0x17EC250
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0x17EB650 Offset: 0x17EB751 VA: 0x17EB650
	internal TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType) { }

	// RVA: 0x17EC0E0 Offset: 0x17EC1E1 VA: 0x17EC0E0
	private void DeleteRecordedAnimation(TrackAsset track) { }

	// RVA: 0x17EBAB0 Offset: 0x17EBBB1 VA: 0x17EBAB0
	private void DeleteRecordedAnimation(TimelineClip clip) { }

	// RVA: 0x17EC4B0 Offset: 0x17EC5B1 VA: 0x17EC4B0
	public void .ctor() { }
}

